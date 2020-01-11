using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using System.Linq;


using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Plugins;
using Tekla.Structures.Dialog;
using Tekla.Structures.Dialog.UIControls;
using Tekla.Structures.Datatype;
//using Angle = Tekla.Structures.Datatype.Angle;
//using
using Distance = Tekla.Structures.Datatype.Distance;
using String = System.String;

namespace KneeWall
{
    public class StructuresData
    {
        [StructuresField("BeamName")]
        public string BeamName;

        [StructuresField("BeamProfile")]
        public string BeamProfile;

        [StructuresField("BeamMaterial")]
        public string BeamMaterial;

        [StructuresField("BeamFinish")]
        public string BeamFinish;

        [StructuresField("BeamClass")]
        public string BeamClass;

        [StructuresField("SheatingName")]
        public string SheatingName;

        [StructuresField("SheatingProfile")]
        public string SheatingProfile;

        [StructuresField("SheatingMaterial")]
        public string SheatingMaterial;

        [StructuresField("SheatingFinish")]
        public string SheatingFinish;

        [StructuresField("SheatingClass")]
        public string SheatingClass;

        [StructuresField("Spacing")]
        public int Spacing;

        [StructuresField("SheatingOverhang")]
        public double SheatingOverhang;

        [StructuresField("DrukregelName")]
        public string DrukregelName;

        [StructuresField("DrukregelProfile")]
        public string DrukregelProfile;

        [StructuresField("DrukregelMaterial")]
        public string DrukregelMaterial;

        [StructuresField("DrukregelFinish")]
        public string DrukregelFinish;

        [StructuresField("DrukregelClass")]
        public string DrukregelClass;

        [StructuresField("DrukregelAngle")]
        public double DrukregelAngle;

        [StructuresField("DrukregelMovement")]
        public double DrukregelMovement;

        [StructuresField("SheatingType")]
        public int SheatingType;

        [StructuresField("Length")]
        public double Length;
    }

    [Plugin("KneeWall")]
    [PluginUserInterface("KneeWall.KneeWallForm")]
    public class KneeWall : PluginBase
    {
        #region Fields
        private Model _Model;
        private StructuresData _Data;
        private string _BeamName = "SPOOR";
        private string _BeamProfile = "45*70";
        private string _BeamMaterial = "VUREN-C";
        private string _BeamFinish = string.Empty;
        private string _BeamClass = "13";

        private string _SheatingName = "SPAANPLAAT     (wit)";
        private string _SheatingProfile = "PL11*1218";
        private string _SheatingMaterial = "SPAANPLAAT";
        private string _SheatingFinish = string.Empty;
        private string _SheatingClass = "5";
        private double _SheatingOverhang;
        private int _SheatingType;
        private int _Spacing;

        private string _DrukregelName = "DRUKREGEL";
        private string _DrukregelProfile = "DR";
        private string _DrukregelMaterial = "VUREN";
        private string _DrukregelFinish = string.Empty;
        private string _DrukregelClass = "2";
        private double _DrukregelAngle;
        private double _DrukregelMovement;

        private double _Length;

        #endregion

        #region Properties
        private Model Model
        {
            get { return this._Model; }
            set { this._Model = value; }
        }

        private StructuresData Data
        {
            get { return this._Data; }
            set { this._Data = value; }
        }

        public Beam[] Rafters { get; set; }
        public Beam[] SheatingPanels { get; set; }
        public Beam TopBeam { get; set; }
        public Beam BottomBeam { get; set; }
        public Beam Drukregel { get; set; }

        #endregion

        #region Constructor
        public KneeWall(StructuresData StructuresData)
        {
            Model = new Model();
            Data = StructuresData;
        }
        #endregion

        #region Overriden methods
        public override List<InputDefinition> DefineInput()
        {
            List<InputDefinition> PointList = new List<InputDefinition>();
            Picker Picker = new Picker();
            ArrayList PickedPoints = Picker.PickPoints(Picker.PickPointEnum.PICK_TWO_POINTS);
            Point point = Picker.PickPoint("Pick any point on sheating panel");
            //InputDefinition Input1 = new InputDefinition(point);
            PickedPoints.Add(point);

            PointList.Add(new InputDefinition(PickedPoints));
            //PointList.Add(Input1);

            return PointList;
        }

        public override bool Run(List<InputDefinition> Input)
        {
            try
            {
                GetValuesFromDialog();

                ArrayList Points = (ArrayList) Input[0].GetInput();
                Point StartPoint = Points[0] as Point;
                Point EndPoint = Points[1] as Point;
                Point DirectionPoint = Points[2] as Point;

                SetUpRafters(StartPoint, EndPoint, DirectionPoint);
            }
            catch(Exception Exc)
            {
                MessageBox.Show(Exc.ToString());
            }

            return true;
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Gets the values from the dialog and sets the default values if needed
        /// </summary>
        /// commenttest
        /// comment
        private void GetValuesFromDialog()
        {
            _BeamName = Data.BeamName;
            _BeamProfile = Data.BeamProfile;
            _BeamMaterial = Data.BeamMaterial;
            _BeamFinish = Data.BeamFinish;
            _BeamClass = Data.BeamClass;

            _SheatingName = Data.SheatingName;
            _SheatingProfile = Data.SheatingProfile;
            _SheatingMaterial = Data.SheatingMaterial;
            _SheatingFinish = Data.SheatingFinish;
            _SheatingClass = Data.SheatingClass;
            _SheatingOverhang = Data.SheatingOverhang;
            _SheatingType = Data.SheatingType;

            _DrukregelName = Data.DrukregelName;
            _DrukregelProfile = Data.DrukregelProfile;
            _DrukregelMaterial = Data.DrukregelMaterial;
            _DrukregelFinish = Data.DrukregelFinish;
            _DrukregelClass = Data.DrukregelClass;
            _DrukregelAngle = Data.DrukregelAngle;
            _DrukregelMovement = Data.DrukregelMovement;

            _Length = Data.Length;

            _Spacing = Data.Spacing;

            if(IsDefaultValue(_BeamName))
                _BeamName = "SPOOR";
            if(IsDefaultValue(_BeamProfile))
                _BeamProfile = "45*70";
            if(IsDefaultValue(_BeamMaterial))
                _BeamMaterial = "VUREN-C";
            if(IsDefaultValue(_BeamClass))
                _BeamClass = "13";
            if (IsDefaultValue(_SheatingName))
                _SheatingName = "SPAANPLAAT";
            if (IsDefaultValue(_SheatingProfile))
                _SheatingProfile = "PL11*1218";
            if (IsDefaultValue(_SheatingMaterial))
                _SheatingMaterial = "SPAANPLAAT";
            if (IsDefaultValue(_SheatingClass))
                _SheatingClass = "4";
            if (IsDefaultValue(_SheatingOverhang))
                _SheatingOverhang = 0.0;

            if (IsDefaultValue(_DrukregelName))
                _DrukregelName = "DRUKREGEL";
            if (IsDefaultValue(_DrukregelProfile))
              _DrukregelProfile = "DR";
            if (IsDefaultValue(_DrukregelMaterial))
                _DrukregelMaterial = "VUREN";
            if (IsDefaultValue(_DrukregelClass))
                _DrukregelClass = "2";
            if (IsDefaultValue(_DrukregelAngle))
                _DrukregelAngle = 45;
            if (IsDefaultValue(_SheatingType))
                _SheatingType = 0;
            if (IsDefaultValue(_DrukregelMovement))
                _DrukregelMovement = 0.0;

            if (IsDefaultValue(_Spacing))
                _Spacing = 610;
            if (IsDefaultValue(_Length))
                _Length = 2440;

        }

        private void SetUpRafters(Point StartPoint, Point EndPoint, Point DirectionPoint)
        {
            Phase phase = new Phase();
            phase.PhaseNumber = 3;

            Rafters = new Beam[5];
            TopBeam = new Beam();
            BottomBeam = new Beam();
            SheatingPanels = new Beam[2];

            for (int i = 0; i < Rafters.Length; i++)
            {
                Rafters[i] = new Beam(Beam.BeamTypeEnum.BEAM);
                Rafters[i].Profile.ProfileString = _BeamProfile;
                Rafters[i].Name = _BeamName;
                Rafters[i].Material.MaterialString = _BeamMaterial;
                Rafters[i].PartNumber.Prefix = "Sp";
                Rafters[i].AssemblyNumber.Prefix = "Sp";
                Rafters[i].Finish = _BeamFinish;
                Rafters[i].Class = _BeamClass;
            }

            TopBeam = new Beam(Beam.BeamTypeEnum.BEAM);
            TopBeam.Profile.ProfileString = _BeamProfile;
            TopBeam.Name = _BeamName;
            TopBeam.Material.MaterialString = _BeamMaterial;
            TopBeam.PartNumber.Prefix = "Sp";
            TopBeam.AssemblyNumber.Prefix = "Sp";
            TopBeam.Finish = _BeamFinish;
            TopBeam.Class = _BeamClass;

            BottomBeam = new Beam(Beam.BeamTypeEnum.BEAM);
            BottomBeam.Profile.ProfileString = _BeamProfile;
            BottomBeam.Name = _BeamName;
            BottomBeam.Material.MaterialString = _BeamMaterial;
            BottomBeam.PartNumber.Prefix = "Sp";
            BottomBeam.AssemblyNumber.Prefix = "Sp";
            BottomBeam.Finish = _BeamFinish;
            BottomBeam.Class = _BeamClass;

            Drukregel = new Beam(Beam.BeamTypeEnum.BEAM);
            Drukregel.Profile.ProfileString = _DrukregelProfile;
            Drukregel.Name = _DrukregelName;
            Drukregel.Material.MaterialString = _DrukregelMaterial;
            Drukregel.PartNumber.Prefix = "Dr";
            Drukregel.AssemblyNumber.Prefix = "Dr";
            Drukregel.Finish = _DrukregelFinish;
            Drukregel.Class = _DrukregelClass;

            if (DirectionPoint.Y > StartPoint.Y)
            {
                Rafters.First().Position.Plane = Position.PlaneEnum.LEFT;
                Rafters.First().Position.Rotation = Position.RotationEnum.TOP;
                Rafters.First().Position.Depth = Position.DepthEnum.BEHIND;
                Rafters.First().StartPoint = new Point(StartPoint);
                Rafters.First().EndPoint = new Point(EndPoint);
                Rafters.First().Insert();
                Rafters.First().SetPhase(phase);

                //TransformationPlane tp = new TransformationPlane(Rafters.First().GetCoordinateSystem());
                //Model.GetWorkPlaneHandler().SetCurrentTransformationPlane(tp);

                double MinimumX = Rafters.First().GetSolid().MinimumPoint.X;
                double MinimumY = Rafters.First().GetSolid().MinimumPoint.Y;
                double MinimumZ = Rafters.First().GetSolid().MinimumPoint.Z;
                double MaximumX = Rafters.First().GetSolid().MaximumPoint.X;
                double MaximumY = Rafters.First().GetSolid().MaximumPoint.Y;
                double MaximumZ = Rafters.First().GetSolid().MaximumPoint.Z;

                Rafters.Last().Position.Plane = Position.PlaneEnum.LEFT;
                Rafters.Last().Position.Rotation = Position.RotationEnum.TOP;
                Rafters.Last().Position.Depth = Position.DepthEnum.FRONT;
                Rafters.Last().StartPoint = new Point(MinimumX + _Length, MinimumY, MinimumZ);
                Rafters.Last().EndPoint = new Point(MinimumX + _Length, MinimumY, MaximumZ);
                Rafters.Last().Insert();
                Rafters.Last().SetPhase(phase);

                TopBeam.Position.Plane = Position.PlaneEnum.LEFT;
                TopBeam.Position.Rotation = Position.RotationEnum.BELOW;
                TopBeam.Position.Depth = Position.DepthEnum.FRONT;
                TopBeam.StartPoint = new Point(MinimumX, MinimumY, MaximumZ);
                TopBeam.EndPoint = new Point(MinimumX + _Length, MinimumY, MaximumZ);

                if (!TopBeam.Insert())
                    MessageBox.Show("Failed to insert topbeam");

                TopBeam.SetPhase(phase);

                BottomBeam.Position.Plane = Position.PlaneEnum.LEFT;
                BottomBeam.Position.Rotation = Position.RotationEnum.BELOW;
                BottomBeam.Position.Depth = Position.DepthEnum.BEHIND;
                BottomBeam.StartPoint = new Point(MinimumX, MinimumY, MinimumZ);
                BottomBeam.EndPoint = new Point(MinimumX + _Length, MinimumY, MinimumZ);

                if (!BottomBeam.Insert())
                    MessageBox.Show("Failed to insert bottombeam");

                BottomBeam.SetPhase(phase);

                //INTERMEDIATE
                for (int j = 1; j < Rafters.Length - 1; j++)
                {
                    Rafters[j].Position.Plane = Position.PlaneEnum.LEFT;
                    Rafters[j].Position.Rotation = Position.RotationEnum.TOP;
                    Rafters[j].Position.Depth = Position.DepthEnum.MIDDLE;
                    //Rafters[j].StartPoint = tp.TransformationMatrixToLocal.Transform(StartPoint) - new Point(0, j * _Spacing, 0);
                    //Rafters[j].EndPoint = tp.TransformationMatrixToLocal.Transform(EndPoint) - new Point(0, j * _Spacing, 0);

                    Rafters[j].StartPoint = new Point(MinimumX + j * _Spacing, MinimumY, MinimumZ);
                    Rafters[j].EndPoint = new Point(MinimumX + j * _Spacing, MinimumY, MaximumZ);
                    Rafters[j].Insert();
                    Rafters[j].SetPhase(phase);

                }

                TopBeam.SetUserProperty("USER_FIELD_1", "x");
                BottomBeam.SetUserProperty("USER_FIELD_1", "x");
                Rafters.First().SetUserProperty("USER_FIELD_1", "x");
                Rafters.Last().SetUserProperty("USER_FIELD_1", "x");

                MinimumX = BottomBeam.GetSolid().MinimumPoint.X;
                MinimumY = BottomBeam.GetSolid().MinimumPoint.Y;
                MinimumZ = BottomBeam.GetSolid().MinimumPoint.Z;
                MaximumX = BottomBeam.GetSolid().MaximumPoint.X;
                MaximumY = BottomBeam.GetSolid().MaximumPoint.Y;
                MaximumZ = TopBeam.GetSolid().MaximumPoint.Z;

                for (int i = 0; i < SheatingPanels.Length; i++)
                {
                    SheatingPanels[i] = new Beam(Beam.BeamTypeEnum.BEAM);
                    SheatingPanels[i].Position.Plane = Position.PlaneEnum.LEFT;
                    SheatingPanels[i].Position.Rotation = Position.RotationEnum.TOP;
                    SheatingPanels[i].Position.Depth = Position.DepthEnum.BEHIND;
                    SheatingPanels[i].Profile.ProfileString = _SheatingProfile;
                    SheatingPanels[i].Material.MaterialString = _SheatingMaterial;
                    SheatingPanels[i].PartNumber.Prefix = "PL";
                    SheatingPanels[i].AssemblyNumber.Prefix = "R";
                    SheatingPanels[i].Finish = _SheatingFinish;
                    SheatingPanels[i].Name = _SheatingName;
                    SheatingPanels[i].Class = _SheatingClass;

                    if (_SheatingType == 0)
                    {
                        SheatingPanels[i].Name = "SPAANPLAAT";
                        SheatingPanels[i].Class = "4";
                    }

                    if (_SheatingType == 1)
                    {
                        SheatingPanels[i].Name = "SPAANPLAAT     (wit)";
                        SheatingPanels[i].Class = "5";
                    }
                }

                SheatingPanels.First().StartPoint = new Point(BottomBeam.GetSolid().MinimumPoint.X, BottomBeam.GetSolid().MaximumPoint.Y, BottomBeam.GetSolid().MinimumPoint.Z);
                SheatingPanels.First().EndPoint = new Point(BottomBeam.GetSolid().MinimumPoint.X, BottomBeam.GetSolid().MaximumPoint.Y, TopBeam.GetSolid().MaximumPoint.Z + _SheatingOverhang);
                SheatingPanels.First().Insert();
                SheatingPanels.First().SetPhase(phase);

                SheatingPanels.Last().StartPoint = new Point(BottomBeam.GetSolid().MinimumPoint.X + 1222, BottomBeam.GetSolid().MaximumPoint.Y, BottomBeam.GetSolid().MinimumPoint.Z);
                SheatingPanels.Last().EndPoint = new Point(BottomBeam.GetSolid().MinimumPoint.X + 1222, BottomBeam.GetSolid().MaximumPoint.Y, TopBeam.GetSolid().MaximumPoint.Z + _SheatingOverhang);
                SheatingPanels.Last().Insert();
                SheatingPanels.Last().SetPhase(phase);

                Drukregel.Position.Plane = Position.PlaneEnum.LEFT;
                Drukregel.Position.Rotation = Position.RotationEnum.BACK;
                Drukregel.Position.Depth = Position.DepthEnum.FRONT;

                Drukregel.Position.RotationOffset = -90 + _DrukregelAngle;

                Drukregel.StartPoint = new Point(MinimumX, MinimumY - _DrukregelMovement*Math.Cos((90-_DrukregelAngle)*Math.PI/180), MaximumZ + _DrukregelMovement * Math.Sin((90 - _DrukregelAngle) * Math.PI / 180));
                Drukregel.EndPoint = new Point(MinimumX + _Length, MinimumY - _DrukregelMovement * Math.Cos((90 - _DrukregelAngle) * Math.PI / 180), MaximumZ + _DrukregelMovement * Math.Sin((90 - _DrukregelAngle) * Math.PI / 180));

                if (!Drukregel.Insert())
                    MessageBox.Show("Failed to insert drukregel");

                String drukregelComment = Math.Abs(Math.Round(_DrukregelAngle)).ToString();

                Drukregel.SetUserProperty("comment", drukregelComment);
                Drukregel.SetPhase(phase);

                if (_SheatingType == 0)
                {
                    SheatingPanels.First().SetUserProperty("comment", "Naturel");
                    SheatingPanels.Last().SetUserProperty("comment", "Naturel");
                }
                if (_SheatingType == 1)
                {
                    SheatingPanels.First().SetUserProperty("comment", "Wit spanolak");
                    SheatingPanels.Last().SetUserProperty("comment", "Wit spanolak");
                }

                for (int i = 0; i < Rafters.Length; i++)
                {
                    Rafters[i].SetUserProperty("comment", "");
                }

                CutPlane DrukregelCut1 = new CutPlane();
                DrukregelCut1.Plane = new Plane();
                DrukregelCut1.Plane.Origin = new Point(MinimumX, MaximumY, MaximumZ);
                DrukregelCut1.Plane.AxisX = new Vector(0, 0, 1);
                DrukregelCut1.Plane.AxisY = new Vector(1, 0, 0);
                DrukregelCut1.Father = Drukregel;
                DrukregelCut1.Insert();

                CutPlane DrukregelCut3 = new CutPlane();
                DrukregelCut3.Plane = new Plane();
                DrukregelCut3.Plane.Origin = new Point(MinimumX, MinimumY, MaximumZ);
                DrukregelCut3.Plane.AxisX = new Vector(0, 1, 0);
                DrukregelCut3.Plane.AxisY = new Vector(1, 0, 0);
                DrukregelCut3.Father = Drukregel;
                DrukregelCut3.Insert();


            }

            else if (DirectionPoint.Y < StartPoint.Y)
            {
                Rafters.First().Position.Plane = Position.PlaneEnum.RIGHT;
                Rafters.First().Position.Rotation = Position.RotationEnum.BELOW;
                Rafters.First().Position.Depth = Position.DepthEnum.FRONT;
                Rafters.First().StartPoint = new Point(StartPoint);
                Rafters.First().EndPoint = new Point(EndPoint);
                Rafters.First().Insert();
                Rafters.First().SetPhase(phase);

                //TransformationPlane tp = new TransformationPlane(Rafters.First().GetCoordinateSystem());
                //Model.GetWorkPlaneHandler().SetCurrentTransformationPlane(tp);

                double MinimumX = Rafters.First().GetSolid().MinimumPoint.X;
                double MinimumY = Rafters.First().GetSolid().MinimumPoint.Y;
                double MinimumZ = Rafters.First().GetSolid().MinimumPoint.Z;
                double MaximumX = Rafters.First().GetSolid().MaximumPoint.X;
                double MaximumY = Rafters.First().GetSolid().MaximumPoint.Y;
                double MaximumZ = Rafters.First().GetSolid().MaximumPoint.Z;

                Rafters.Last().Position.Plane = Position.PlaneEnum.LEFT;
                Rafters.Last().Position.Rotation = Position.RotationEnum.BELOW;
                Rafters.Last().Position.Depth = Position.DepthEnum.BEHIND;
                Rafters.Last().StartPoint = new Point(MaximumX - _Length, MinimumY, MinimumZ);
                Rafters.Last().EndPoint = new Point(MaximumX - _Length, MinimumY, MaximumZ);
                Rafters.Last().Insert();
                Rafters.Last().SetPhase(phase);

                TopBeam.Position.Plane = Position.PlaneEnum.RIGHT;
                TopBeam.Position.Rotation = Position.RotationEnum.BELOW;
                TopBeam.Position.Depth = Position.DepthEnum.FRONT;
                TopBeam.StartPoint = new Point(MaximumX, MinimumY, MaximumZ);
                TopBeam.EndPoint = new Point(MaximumX - _Length, MinimumY, MaximumZ);

                if (!TopBeam.Insert())
                    MessageBox.Show("Failed to insert topbeam");

                TopBeam.SetPhase(phase);

                BottomBeam.Position.Plane = Position.PlaneEnum.LEFT;
                BottomBeam.Position.Rotation = Position.RotationEnum.BELOW;
                BottomBeam.Position.Depth = Position.DepthEnum.BEHIND;
                BottomBeam.StartPoint = new Point(MaximumX, MaximumY, MinimumZ);
                BottomBeam.EndPoint = new Point(MaximumX - _Length, MaximumY, MinimumZ);

                if (!BottomBeam.Insert())
                    MessageBox.Show("Failed to insert bottombeam");

                BottomBeam.SetPhase(phase);

                //INTERMEDIATE
                for (int j = 1; j < Rafters.Length - 1; j++)
                {
                    Rafters[j].Position.Plane = Position.PlaneEnum.LEFT;
                    Rafters[j].Position.Rotation = Position.RotationEnum.TOP;
                    Rafters[j].Position.Depth = Position.DepthEnum.MIDDLE;
                    //Rafters[j].StartPoint = tp.TransformationMatrixToLocal.Transform(StartPoint) - new Point(0, j * _Spacing, 0);
                    //Rafters[j].EndPoint = tp.TransformationMatrixToLocal.Transform(EndPoint) - new Point(0, j * _Spacing, 0);

                    Rafters[j].StartPoint = new Point(MaximumX - j * _Spacing, MinimumY, MinimumZ);
                    Rafters[j].EndPoint = new Point(MaximumX - j * _Spacing, MinimumY, MaximumZ);
                    Rafters[j].Insert();
                    Rafters[j].SetPhase(phase);

                }

                TopBeam.SetUserProperty("USER_FIELD_1", "x");
                BottomBeam.SetUserProperty("USER_FIELD_1", "x");
                Rafters.First().SetUserProperty("USER_FIELD_1", "x");
                Rafters.Last().SetUserProperty("USER_FIELD_1", "x");

                MinimumX = BottomBeam.GetSolid().MinimumPoint.X;
                MinimumY = BottomBeam.GetSolid().MinimumPoint.Y;
                MinimumZ = BottomBeam.GetSolid().MinimumPoint.Z;
                MaximumX = BottomBeam.GetSolid().MaximumPoint.X;
                MaximumY = BottomBeam.GetSolid().MaximumPoint.Y;
                MaximumZ = TopBeam.GetSolid().MaximumPoint.Z;

                for (int i = 0; i < SheatingPanels.Length; i++)
                {
                    SheatingPanels[i] = new Beam(Beam.BeamTypeEnum.BEAM);
                    SheatingPanels[i].Position.Plane = Position.PlaneEnum.RIGHT;
                    SheatingPanels[i].Position.Rotation = Position.RotationEnum.BELOW;
                    SheatingPanels[i].Position.Depth = Position.DepthEnum.FRONT;
                    SheatingPanels[i].Profile.ProfileString = _SheatingProfile;
                    SheatingPanels[i].Material.MaterialString = _SheatingMaterial;
                    SheatingPanels[i].PartNumber.Prefix = "PL";
                    SheatingPanels[i].AssemblyNumber.Prefix = "R";
                    SheatingPanels[i].Finish = _SheatingFinish;
                    SheatingPanels[i].Name = _SheatingName;
                    SheatingPanels[i].Class = _SheatingClass;

                    if (_SheatingType == 0)
                    {
                        SheatingPanels[i].Name = "SPAANPLAAT";
                        SheatingPanels[i].Class = "4";
                    }

                    if (_SheatingType == 1)
                    {
                        SheatingPanels[i].Name = "SPAANPLAAT     (wit)";
                        SheatingPanels[i].Class = "5";
                    }
                }

                SheatingPanels.First().StartPoint = new Point(BottomBeam.GetSolid().MaximumPoint.X, BottomBeam.GetSolid().MinimumPoint.Y, BottomBeam.GetSolid().MinimumPoint.Z);
                SheatingPanels.First().EndPoint = new Point(BottomBeam.GetSolid().MaximumPoint.X, BottomBeam.GetSolid().MinimumPoint.Y, TopBeam.GetSolid().MaximumPoint.Z + _SheatingOverhang);
                SheatingPanels.First().Insert();
                SheatingPanels.First().SetPhase(phase);

                SheatingPanels.Last().StartPoint = new Point(BottomBeam.GetSolid().MaximumPoint.X - 1222, BottomBeam.GetSolid().MinimumPoint.Y, BottomBeam.GetSolid().MinimumPoint.Z);
                SheatingPanels.Last().EndPoint = new Point(BottomBeam.GetSolid().MaximumPoint.X - 1222, BottomBeam.GetSolid().MinimumPoint.Y, TopBeam.GetSolid().MaximumPoint.Z + _SheatingOverhang);
                SheatingPanels.Last().Insert();
                SheatingPanels.Last().SetPhase(phase);

                Drukregel.Position.Plane = Position.PlaneEnum.LEFT;
                Drukregel.Position.Rotation = Position.RotationEnum.BACK;
                Drukregel.Position.Depth = Position.DepthEnum.FRONT;

                Drukregel.Position.RotationOffset = -90 + _DrukregelAngle;

                Drukregel.StartPoint = new Point(MaximumX, MaximumY + _DrukregelMovement * Math.Cos((90 - _DrukregelAngle) * Math.PI / 180), MaximumZ + _DrukregelMovement * Math.Sin((90 - _DrukregelAngle) * Math.PI / 180));
                Drukregel.EndPoint = new Point(MaximumX - _Length, MaximumY + _DrukregelMovement * Math.Cos((90 - _DrukregelAngle) * Math.PI / 180), MaximumZ + _DrukregelMovement * Math.Sin((90 - _DrukregelAngle) * Math.PI / 180));

                if (!Drukregel.Insert())
                    MessageBox.Show("Failed to insert drukregel");

                String drukregelComment = Math.Abs(Math.Round(_DrukregelAngle)).ToString();

                Drukregel.SetUserProperty("comment", drukregelComment);
                Drukregel.SetPhase(phase);

                if (_SheatingType == 0)
                {
                    SheatingPanels.First().SetUserProperty("comment", "Naturel");
                    SheatingPanels.Last().SetUserProperty("comment", "Naturel");
                }
                if (_SheatingType == 1)
                {
                    SheatingPanels.First().SetUserProperty("comment", "Wit spanolak");
                    SheatingPanels.Last().SetUserProperty("comment", "Wit spanolak");
                }

                for (int i = 0; i < Rafters.Length; i++)
                {
                    Rafters[i].SetUserProperty("comment", "");
                }

                CutPlane DrukregelCut1 = new CutPlane();
                DrukregelCut1.Plane = new Plane();
                DrukregelCut1.Plane.Origin = new Point(MinimumX, MinimumY, MaximumZ);
                DrukregelCut1.Plane.AxisX = new Vector(1, 0, 0);
                DrukregelCut1.Plane.AxisY = new Vector(0, 0, 1);
                DrukregelCut1.Father = Drukregel;
                DrukregelCut1.Insert();

                CutPlane DrukregelCut3 = new CutPlane();
                DrukregelCut3.Plane = new Plane();
                DrukregelCut3.Plane.Origin = new Point(MinimumX, MinimumY, MaximumZ);
                DrukregelCut3.Plane.AxisX = new Vector(0, 1, 0);
                DrukregelCut3.Plane.AxisY = new Vector(1, 0, 0);
                DrukregelCut3.Father = Drukregel;
                DrukregelCut3.Insert();
            }

            else if (DirectionPoint.X > StartPoint.X)
            {
                Rafters.First().Position.Plane = Position.PlaneEnum.RIGHT;
                Rafters.First().Position.Rotation = Position.RotationEnum.FRONT;
                Rafters.First().Position.Depth = Position.DepthEnum.BEHIND;
                Rafters.First().StartPoint = new Point(StartPoint);
                Rafters.First().EndPoint = new Point(EndPoint);
                Rafters.First().Insert();
                Rafters.First().SetPhase(phase);

                //TransformationPlane tp = new TransformationPlane(Rafters.First().GetCoordinateSystem());
                //Model.GetWorkPlaneHandler().SetCurrentTransformationPlane(tp);

                double MinimumX = Rafters.First().GetSolid().MinimumPoint.X;
                double MinimumY = Rafters.First().GetSolid().MinimumPoint.Y;
                double MinimumZ = Rafters.First().GetSolid().MinimumPoint.Z;
                double MaximumX = Rafters.First().GetSolid().MaximumPoint.X;
                double MaximumY = Rafters.First().GetSolid().MaximumPoint.Y;
                double MaximumZ = Rafters.First().GetSolid().MaximumPoint.Z;

                Rafters.Last().Position.Plane = Position.PlaneEnum.LEFT;
                Rafters.Last().Position.Rotation = Position.RotationEnum.FRONT;
                Rafters.Last().Position.Depth = Position.DepthEnum.BEHIND;
                Rafters.Last().StartPoint = new Point(MinimumX, MaximumY - _Length, MinimumZ);
                Rafters.Last().EndPoint = new Point(MinimumX, MaximumY - _Length, MaximumZ);
                Rafters.Last().Insert();
                Rafters.Last().SetPhase(phase);

                TopBeam.Position.Plane = Position.PlaneEnum.LEFT;
                TopBeam.Position.Rotation = Position.RotationEnum.BELOW;
                TopBeam.Position.Depth = Position.DepthEnum.FRONT;
                TopBeam.StartPoint = new Point(MinimumX, MaximumY, MaximumZ);
                TopBeam.EndPoint = new Point(MinimumX, MaximumY - _Length, MaximumZ);

                if (!TopBeam.Insert())
                    MessageBox.Show("Failed to insert topbeam");

                TopBeam.SetPhase(phase);

                BottomBeam.Position.Plane = Position.PlaneEnum.LEFT;
                BottomBeam.Position.Rotation = Position.RotationEnum.BELOW;
                BottomBeam.Position.Depth = Position.DepthEnum.BEHIND;
                BottomBeam.StartPoint = new Point(MinimumX, MaximumY, MinimumZ);
                BottomBeam.EndPoint = new Point(MinimumX, MaximumY - _Length, MinimumZ);

                if (!BottomBeam.Insert())
                    MessageBox.Show("Failed to insert bottombeam");

                BottomBeam.SetPhase(phase);

                //INTERMEDIATE
                for (int j = 1; j < Rafters.Length - 1; j++)
                {
                    Rafters[j].Position.Plane = Position.PlaneEnum.MIDDLE;
                    Rafters[j].Position.Rotation = Position.RotationEnum.FRONT;
                    Rafters[j].Position.Depth = Position.DepthEnum.BEHIND;
                    //Rafters[j].StartPoint = tp.TransformationMatrixToLocal.Transform(StartPoint) - new Point(0, j * _Spacing, 0);
                    //Rafters[j].EndPoint = tp.TransformationMatrixToLocal.Transform(EndPoint) - new Point(0, j * _Spacing, 0);

                    Rafters[j].StartPoint = new Point(MinimumX, MaximumY - j* _Spacing, MinimumZ);
                    Rafters[j].EndPoint = new Point(MinimumX, MaximumY - j * _Spacing, MaximumZ);
                    Rafters[j].Insert();
                    Rafters[j].SetPhase(phase);

                }

                TopBeam.SetUserProperty("USER_FIELD_1", "x");
                BottomBeam.SetUserProperty("USER_FIELD_1", "x");
                Rafters.First().SetUserProperty("USER_FIELD_1", "x");
                Rafters.Last().SetUserProperty("USER_FIELD_1", "x");

                MinimumX = BottomBeam.GetSolid().MinimumPoint.X;
                MinimumY = BottomBeam.GetSolid().MinimumPoint.Y;
                MinimumZ = BottomBeam.GetSolid().MinimumPoint.Z;
                MaximumX = BottomBeam.GetSolid().MaximumPoint.X;
                MaximumY = BottomBeam.GetSolid().MaximumPoint.Y;
                MaximumZ = TopBeam.GetSolid().MaximumPoint.Z;

                for (int i = 0; i < SheatingPanels.Length; i++)
                {
                    SheatingPanels[i] = new Beam(Beam.BeamTypeEnum.BEAM);
                    SheatingPanels[i].Position.Plane = Position.PlaneEnum.RIGHT;
                    SheatingPanels[i].Position.Rotation = Position.RotationEnum.FRONT;
                    SheatingPanels[i].Position.Depth = Position.DepthEnum.BEHIND;
                    SheatingPanels[i].Profile.ProfileString = _SheatingProfile;
                    SheatingPanels[i].Material.MaterialString = _SheatingMaterial;
                    SheatingPanels[i].PartNumber.Prefix = "PL";
                    SheatingPanels[i].AssemblyNumber.Prefix = "R";
                    SheatingPanels[i].Finish = _SheatingFinish;
                    SheatingPanels[i].Name = _SheatingName;
                    SheatingPanels[i].Class = _SheatingClass;

                    if (_SheatingType == 0)
                    {
                        SheatingPanels[i].Name = "SPAANPLAAT";
                        SheatingPanels[i].Class = "4";
                    }

                    if (_SheatingType == 1)
                    {
                        SheatingPanels[i].Name = "SPAANPLAAT     (wit)";
                        SheatingPanels[i].Class = "5";
                    }
                }

                SheatingPanels.First().StartPoint = new Point(BottomBeam.GetSolid().MaximumPoint.X, BottomBeam.GetSolid().MaximumPoint.Y, BottomBeam.GetSolid().MinimumPoint.Z);
                SheatingPanels.First().EndPoint = new Point(BottomBeam.GetSolid().MaximumPoint.X, BottomBeam.GetSolid().MaximumPoint.Y, TopBeam.GetSolid().MaximumPoint.Z + _SheatingOverhang);
                SheatingPanels.First().Insert();
                SheatingPanels.First().SetPhase(phase);

                SheatingPanels.Last().StartPoint = new Point(BottomBeam.GetSolid().MaximumPoint.X, BottomBeam.GetSolid().MaximumPoint.Y - 1222, BottomBeam.GetSolid().MinimumPoint.Z);
                SheatingPanels.Last().EndPoint = new Point(BottomBeam.GetSolid().MaximumPoint.X, BottomBeam.GetSolid().MaximumPoint.Y - 1222, TopBeam.GetSolid().MaximumPoint.Z + _SheatingOverhang);
                SheatingPanels.Last().Insert();
                SheatingPanels.Last().SetPhase(phase);

                Drukregel.Position.Plane = Position.PlaneEnum.LEFT;
                Drukregel.Position.Rotation = Position.RotationEnum.BACK;
                Drukregel.Position.Depth = Position.DepthEnum.FRONT;

                Drukregel.Position.RotationOffset = -90 + _DrukregelAngle;

                Drukregel.StartPoint = new Point(MinimumX - _DrukregelMovement * Math.Cos((90 - _DrukregelAngle) * Math.PI / 180), MaximumY, MaximumZ + _DrukregelMovement * Math.Sin((90 - _DrukregelAngle) * Math.PI / 180));
                Drukregel.EndPoint = new Point(MinimumX - _DrukregelMovement * Math.Cos((90 - _DrukregelAngle) * Math.PI / 180), MaximumY - _Length, MaximumZ + _DrukregelMovement * Math.Sin((90 - _DrukregelAngle) * Math.PI / 180));

                if (!Drukregel.Insert())
                    MessageBox.Show("Failed to insert drukregel");

                String drukregelComment = Math.Abs(Math.Round(_DrukregelAngle)).ToString();

                Drukregel.SetUserProperty("comment", drukregelComment);
                Drukregel.SetPhase(phase);

                if (_SheatingType == 0)
                {
                    SheatingPanels.First().SetUserProperty("comment", "Naturel");
                    SheatingPanels.Last().SetUserProperty("comment", "Naturel");
                }
                if (_SheatingType == 1)
                {
                    SheatingPanels.First().SetUserProperty("comment", "Wit spanolak");
                    SheatingPanels.Last().SetUserProperty("comment", "Wit spanolak");
                }

                for (int i = 0; i < Rafters.Length; i++)
                {
                    Rafters[i].SetUserProperty("comment", "");
                }

                CutPlane DrukregelCut1 = new CutPlane();
                DrukregelCut1.Plane = new Plane();
                DrukregelCut1.Plane.Origin = new Point(MaximumX, MaximumY, MaximumZ);
                DrukregelCut1.Plane.AxisX = new Vector(0, 1, 0);
                DrukregelCut1.Plane.AxisY = new Vector(0, 0, 1);
                DrukregelCut1.Father = Drukregel;
                DrukregelCut1.Insert();

                CutPlane DrukregelCut3 = new CutPlane();
                DrukregelCut3.Plane = new Plane();
                DrukregelCut3.Plane.Origin = new Point(MinimumX, MinimumY, MaximumZ);
                DrukregelCut3.Plane.AxisX = new Vector(0, 1, 0);
                DrukregelCut3.Plane.AxisY = new Vector(1, 0, 0);
                DrukregelCut3.Father = Drukregel;
                DrukregelCut3.Insert();
            }

            else if (DirectionPoint.X < StartPoint.X)
            {
                Rafters.First().Position.Plane = Position.PlaneEnum.LEFT;
                Rafters.First().Position.Rotation = Position.RotationEnum.BACK;
                Rafters.First().Position.Depth = Position.DepthEnum.FRONT;
                Rafters.First().StartPoint = new Point(StartPoint);
                Rafters.First().EndPoint = new Point(EndPoint);
                Rafters.First().Insert();
                Rafters.First().SetPhase(phase);

                //TransformationPlane tp = new TransformationPlane(Rafters.First().GetCoordinateSystem());
                //Model.GetWorkPlaneHandler().SetCurrentTransformationPlane(tp);

                double MinimumX = Rafters.First().GetSolid().MinimumPoint.X;
                double MinimumY = Rafters.First().GetSolid().MinimumPoint.Y;
                double MinimumZ = Rafters.First().GetSolid().MinimumPoint.Z;
                double MaximumX = Rafters.First().GetSolid().MaximumPoint.X;
                double MaximumY = Rafters.First().GetSolid().MaximumPoint.Y;
                double MaximumZ = Rafters.First().GetSolid().MaximumPoint.Z;

                Rafters.Last().Position.Plane = Position.PlaneEnum.RIGHT;
                Rafters.Last().Position.Rotation = Position.RotationEnum.BACK;
                Rafters.Last().Position.Depth = Position.DepthEnum.BEHIND;
                Rafters.Last().StartPoint = new Point(MinimumX, MinimumY + _Length, MinimumZ);
                Rafters.Last().EndPoint = new Point(MinimumX, MinimumY + _Length, MaximumZ);
                Rafters.Last().Insert();
                Rafters.Last().SetPhase(phase);

                TopBeam.Position.Plane = Position.PlaneEnum.RIGHT;
                TopBeam.Position.Rotation = Position.RotationEnum.BELOW;
                TopBeam.Position.Depth = Position.DepthEnum.FRONT;
                TopBeam.StartPoint = new Point(MinimumX, MinimumY, MaximumZ);
                TopBeam.EndPoint = new Point(MinimumX, MinimumY + _Length, MaximumZ);

                if (!TopBeam.Insert())
                    MessageBox.Show("Failed to insert topbeam");

                TopBeam.SetPhase(phase);

                BottomBeam.Position.Plane = Position.PlaneEnum.RIGHT;
                BottomBeam.Position.Rotation = Position.RotationEnum.BELOW;
                BottomBeam.Position.Depth = Position.DepthEnum.BEHIND;
                BottomBeam.StartPoint = new Point(MinimumX, MinimumY, MinimumZ);
                BottomBeam.EndPoint = new Point(MinimumX, MinimumY + _Length, MinimumZ);

                if (!BottomBeam.Insert())
                    MessageBox.Show("Failed to insert bottombeam");

                BottomBeam.SetPhase(phase);

                //INTERMEDIATE
                for (int j = 1; j < Rafters.Length - 1; j++)
                {
                    Rafters[j].Position.Plane = Position.PlaneEnum.MIDDLE;
                    Rafters[j].Position.Rotation = Position.RotationEnum.BACK;
                    Rafters[j].Position.Depth = Position.DepthEnum.BEHIND;
                    //Rafters[j].StartPoint = tp.TransformationMatrixToLocal.Transform(StartPoint) - new Point(0, j * _Spacing, 0);
                    //Rafters[j].EndPoint = tp.TransformationMatrixToLocal.Transform(EndPoint) - new Point(0, j * _Spacing, 0);

                    Rafters[j].StartPoint = new Point(MinimumX, MinimumY + j * _Spacing, MinimumZ);
                    Rafters[j].EndPoint = new Point(MinimumX, MinimumY + j * _Spacing, MaximumZ);
                    Rafters[j].Insert();
                    Rafters[j].SetPhase(phase);

                }

                TopBeam.SetUserProperty("USER_FIELD_1", "x");
                BottomBeam.SetUserProperty("USER_FIELD_1", "x");
                Rafters.First().SetUserProperty("USER_FIELD_1", "x");
                Rafters.Last().SetUserProperty("USER_FIELD_1", "x");

                MinimumX = BottomBeam.GetSolid().MinimumPoint.X;
                MinimumY = BottomBeam.GetSolid().MinimumPoint.Y;
                MinimumZ = BottomBeam.GetSolid().MinimumPoint.Z;
                MaximumX = BottomBeam.GetSolid().MaximumPoint.X;
                MaximumY = BottomBeam.GetSolid().MaximumPoint.Y;
                MaximumZ = TopBeam.GetSolid().MaximumPoint.Z;

                for (int i = 0; i < SheatingPanels.Length; i++)
                {
                    SheatingPanels[i] = new Beam(Beam.BeamTypeEnum.BEAM);
                    SheatingPanels[i].Position.Plane = Position.PlaneEnum.LEFT;
                    SheatingPanels[i].Position.Rotation = Position.RotationEnum.BACK;
                    SheatingPanels[i].Position.Depth = Position.DepthEnum.FRONT;
                    SheatingPanels[i].Profile.ProfileString = _SheatingProfile;
                    SheatingPanels[i].Material.MaterialString = _SheatingMaterial;
                    SheatingPanels[i].PartNumber.Prefix = "PL";
                    SheatingPanels[i].AssemblyNumber.Prefix = "R";
                    SheatingPanels[i].Finish = _SheatingFinish;
                    SheatingPanels[i].Name = _SheatingName;
                    SheatingPanels[i].Class = _SheatingClass;

                    if (_SheatingType == 0)
                    {
                        SheatingPanels[i].Name = "SPAANPLAAT";
                        SheatingPanels[i].Class = "4";
                    }

                    if (_SheatingType == 1)
                    {
                        SheatingPanels[i].Name = "SPAANPLAAT     (wit)";
                        SheatingPanels[i].Class = "5";
                    }
                }

                SheatingPanels.First().StartPoint = new Point(BottomBeam.GetSolid().MinimumPoint.X, BottomBeam.GetSolid().MinimumPoint.Y, BottomBeam.GetSolid().MinimumPoint.Z);
                SheatingPanels.First().EndPoint = new Point(BottomBeam.GetSolid().MinimumPoint.X, BottomBeam.GetSolid().MinimumPoint.Y, TopBeam.GetSolid().MaximumPoint.Z + _SheatingOverhang);
                SheatingPanels.First().Insert();
                SheatingPanels.First().SetPhase(phase);

                SheatingPanels.Last().StartPoint = new Point(BottomBeam.GetSolid().MinimumPoint.X, BottomBeam.GetSolid().MinimumPoint.Y + 1222, BottomBeam.GetSolid().MinimumPoint.Z);
                SheatingPanels.Last().EndPoint = new Point(BottomBeam.GetSolid().MinimumPoint.X, BottomBeam.GetSolid().MinimumPoint.Y + 1222, TopBeam.GetSolid().MaximumPoint.Z + _SheatingOverhang);
                SheatingPanels.Last().Insert();
                SheatingPanels.Last().SetPhase(phase);

                Drukregel.Position.Plane = Position.PlaneEnum.LEFT;
                Drukregel.Position.Rotation = Position.RotationEnum.BACK;
                Drukregel.Position.Depth = Position.DepthEnum.FRONT;

                Drukregel.Position.RotationOffset = -90 + _DrukregelAngle;

                Drukregel.StartPoint = new Point(MaximumX + _DrukregelMovement * Math.Cos((90 - _DrukregelAngle) * Math.PI / 180), MinimumY, MaximumZ + _DrukregelMovement * Math.Sin((90 - _DrukregelAngle) * Math.PI / 180));
                Drukregel.EndPoint = new Point(MaximumX + _DrukregelMovement * Math.Cos((90 - _DrukregelAngle) * Math.PI / 180), MinimumY + _Length, MaximumZ + _DrukregelMovement * Math.Sin((90 - _DrukregelAngle) * Math.PI / 180));

                if (!Drukregel.Insert())
                    MessageBox.Show("Failed to insert drukregel");

                String drukregelComment = Math.Abs(Math.Round(_DrukregelAngle)).ToString();

                Drukregel.SetUserProperty("comment", drukregelComment);
                Drukregel.SetPhase(phase);

                if (_SheatingType == 0)
                {
                    SheatingPanels.First().SetUserProperty("comment", "Naturel");
                    SheatingPanels.Last().SetUserProperty("comment", "Naturel");
                }
                if (_SheatingType == 1)
                {
                    SheatingPanels.First().SetUserProperty("comment", "Wit spanolak");
                    SheatingPanels.Last().SetUserProperty("comment", "Wit spanolak");
                }

                for (int i = 0; i < Rafters.Length; i++)
                {
                    Rafters[i].SetUserProperty("comment", "");
                }

                CutPlane DrukregelCut1 = new CutPlane();
                DrukregelCut1.Plane = new Plane();
                DrukregelCut1.Plane.Origin = new Point(MinimumX, MaximumY, MaximumZ);
                DrukregelCut1.Plane.AxisX = new Vector(0, 0, 1);
                DrukregelCut1.Plane.AxisY = new Vector(0, 1, 0);
                DrukregelCut1.Father = Drukregel;
                DrukregelCut1.Insert();

                CutPlane DrukregelCut3 = new CutPlane();
                DrukregelCut3.Plane = new Plane();
                DrukregelCut3.Plane.Origin = new Point(MinimumX, MinimumY, MaximumZ);
                DrukregelCut3.Plane.AxisX = new Vector(0, 1, 0);
                DrukregelCut3.Plane.AxisY = new Vector(1, 0, 0);
                DrukregelCut3.Father = Drukregel;
                DrukregelCut3.Insert();

            }

            else MessageBox.Show("Invalid points");

            Assembly assembly = BottomBeam.GetAssembly();
            assembly.Add(TopBeam);
            assembly.Add(Drukregel);

            foreach (Beam rafter in Rafters)
            {
                assembly.Add(rafter);
            }
            foreach (Beam sheating in SheatingPanels)
            {
                assembly.Add(sheating);
            }

            if (!assembly.Modify())
                MessageBox.Show("Assembly Modify Failed!");

            Model.GetWorkPlaneHandler().SetCurrentTransformationPlane(new TransformationPlane());
        }
        #endregion
    }
}

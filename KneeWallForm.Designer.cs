using System;
using System.Windows.Forms;
using Tekla.Structures.Dialog;
using Tekla.Structures.Dialog.UIControls;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Tekla.Structures.Datatype;

namespace KneeWall
{
    partial class KneeWallForm : PluginFormBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// comment
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /*protected override string LoadValuesPath(string fileName)
        {
            SetAttributeValue(DrukregelProfileTextBox, "DR");
            SetAttributeValue(SheatingOverhangTextBox, 0.0);
            SetAttributeValue(DrukregelAngleTextBox, 45.00);
            SetAttributeValue(BeamProfileTextBox, "45*70");

            string Result = base.LoadValuesPath(fileName);
            Apply();
            return Result;
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.saveLoad1 = new Tekla.Structures.Dialog.UIControls.SaveLoad();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PropertiesTabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BeamProfileCheckBox1 = new System.Windows.Forms.CheckBox();
            this.BeamProfileTextBox = new System.Windows.Forms.TextBox();
            this.SheatingOverhangCheckBox = new System.Windows.Forms.CheckBox();
            this.SheatingOverhangTextBox = new System.Windows.Forms.TextBox();
            this.DrukregelAngleCheckBox = new System.Windows.Forms.CheckBox();
            this.DrukregelAngleTextBox = new System.Windows.Forms.TextBox();
            this.DrukregelProfileCheckBox = new System.Windows.Forms.CheckBox();
            this.DrukregelProfileTextBox = new System.Windows.Forms.TextBox();
            this.SheatingTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.SheatingTypeComboBox = new System.Windows.Forms.ComboBox();
            this.LengthCheckBox = new System.Windows.Forms.CheckBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.okApplyModifyGetOnOffCancel1 = new Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.saveLoad2 = new Tekla.Structures.Dialog.UIControls.SaveLoad();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.PropertiesTabPage1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.structuresExtender.SetAttributeName(this.tableLayoutPanel1, null);
            this.structuresExtender.SetAttributeTypeName(this.tableLayoutPanel1, null);
            this.structuresExtender.SetBindPropertyName(this.tableLayoutPanel1, null);
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.saveLoad1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.okApplyModifyGetOnOffCancel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(707, 505);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // saveLoad1
            // 
            this.structuresExtender.SetAttributeName(this.saveLoad1, null);
            this.structuresExtender.SetAttributeTypeName(this.saveLoad1, null);
            this.saveLoad1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.structuresExtender.SetBindPropertyName(this.saveLoad1, null);
            this.saveLoad1.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveLoad1.HelpFileType = Tekla.Structures.Dialog.UIControls.SaveLoad.HelpFileTypeEnum.General;
            this.saveLoad1.HelpKeyword = "";
            this.saveLoad1.HelpUrl = "";
            this.saveLoad1.Location = new System.Drawing.Point(5, 5);
            this.saveLoad1.Margin = new System.Windows.Forms.Padding(5);
            this.saveLoad1.Name = "saveLoad1";
            this.saveLoad1.SaveAsText = "";
            this.saveLoad1.Size = new System.Drawing.Size(697, 53);
            this.saveLoad1.TabIndex = 0;
            this.saveLoad1.UserDefinedHelpFilePath = null;
            // 
            // tabControl1
            // 
            this.structuresExtender.SetAttributeName(this.tabControl1, null);
            this.structuresExtender.SetAttributeTypeName(this.tabControl1, null);
            this.structuresExtender.SetBindPropertyName(this.tabControl1, null);
            this.tabControl1.Controls.Add(this.PropertiesTabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(4, 67);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(699, 391);
            this.tabControl1.TabIndex = 2;
            // 
            // PropertiesTabPage1
            // 
            this.structuresExtender.SetAttributeName(this.PropertiesTabPage1, null);
            this.structuresExtender.SetAttributeTypeName(this.PropertiesTabPage1, null);
            this.structuresExtender.SetBindPropertyName(this.PropertiesTabPage1, null);
            this.PropertiesTabPage1.Controls.Add(this.tableLayoutPanel3);
            this.PropertiesTabPage1.Location = new System.Drawing.Point(4, 25);
            this.PropertiesTabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.PropertiesTabPage1.Name = "PropertiesTabPage1";
            this.PropertiesTabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.PropertiesTabPage1.Size = new System.Drawing.Size(691, 362);
            this.PropertiesTabPage1.TabIndex = 0;
            this.PropertiesTabPage1.Text = "Properties";
            this.PropertiesTabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.structuresExtender.SetAttributeName(this.tableLayoutPanel3, null);
            this.structuresExtender.SetAttributeTypeName(this.tableLayoutPanel3, null);
            this.structuresExtender.SetBindPropertyName(this.tableLayoutPanel3, null);
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.BeamProfileCheckBox1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.BeamProfileTextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.SheatingOverhangCheckBox, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.SheatingOverhangTextBox, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.DrukregelAngleCheckBox, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.DrukregelAngleTextBox, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.DrukregelProfileCheckBox, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.DrukregelProfileTextBox, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.SheatingTypeCheckBox, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.SheatingTypeComboBox, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.LengthCheckBox, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.LengthTextBox, 1, 6);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(683, 354);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // BeamProfileCheckBox1
            // 
            this.structuresExtender.SetAttributeName(this.BeamProfileCheckBox1, "BeamProfile");
            this.structuresExtender.SetAttributeTypeName(this.BeamProfileCheckBox1, null);
            this.BeamProfileCheckBox1.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.BeamProfileCheckBox1, null);
            this.structuresExtender.SetIsFilter(this.BeamProfileCheckBox1, true);
            this.BeamProfileCheckBox1.Location = new System.Drawing.Point(4, 4);
            this.BeamProfileCheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.BeamProfileCheckBox1.Name = "BeamProfileCheckBox1";
            this.BeamProfileCheckBox1.Size = new System.Drawing.Size(74, 21);
            this.BeamProfileCheckBox1.TabIndex = 2;
            this.BeamProfileCheckBox1.Text = "Profile:";
            this.BeamProfileCheckBox1.UseVisualStyleBackColor = true;
            // 
            // BeamProfileTextBox
            // 
            this.structuresExtender.SetAttributeName(this.BeamProfileTextBox, "BeamProfile");
            this.structuresExtender.SetAttributeTypeName(this.BeamProfileTextBox, "String");
            this.structuresExtender.SetBindPropertyName(this.BeamProfileTextBox, null);
            this.BeamProfileTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BeamProfileTextBox.Location = new System.Drawing.Point(151, 4);
            this.BeamProfileTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BeamProfileTextBox.Name = "BeamProfileTextBox";
            this.BeamProfileTextBox.Size = new System.Drawing.Size(528, 22);
            this.BeamProfileTextBox.TabIndex = 7;
            this.BeamProfileTextBox.Text = "45*70";
            SetAttributeValue(BeamProfileTextBox, "45*70");

            // 
            // SheatingOverhangCheckBox
            // 
            this.structuresExtender.SetAttributeName(this.SheatingOverhangCheckBox, "SheatingOverhang");
            this.structuresExtender.SetAttributeTypeName(this.SheatingOverhangCheckBox, null);
            this.SheatingOverhangCheckBox.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.SheatingOverhangCheckBox, null);
            this.structuresExtender.SetIsFilter(this.SheatingOverhangCheckBox, true);
            this.SheatingOverhangCheckBox.Location = new System.Drawing.Point(4, 34);
            this.SheatingOverhangCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.SheatingOverhangCheckBox.Name = "SheatingOverhangCheckBox";
            this.SheatingOverhangCheckBox.Size = new System.Drawing.Size(97, 21);
            this.SheatingOverhangCheckBox.TabIndex = 0;
            this.SheatingOverhangCheckBox.Text = "Overhang:";
            this.SheatingOverhangCheckBox.UseVisualStyleBackColor = true;
            // 
            // SheatingOverhangTextBox
            // 
            this.structuresExtender.SetAttributeName(this.SheatingOverhangTextBox, "SheatingOverhang");
            this.structuresExtender.SetAttributeTypeName(this.SheatingOverhangTextBox, "Distance");
            this.structuresExtender.SetBindPropertyName(this.SheatingOverhangTextBox, null);
            this.SheatingOverhangTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SheatingOverhangTextBox.Location = new System.Drawing.Point(151, 34);
            this.SheatingOverhangTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SheatingOverhangTextBox.Name = "SheatingOverhangTextBox";
            this.SheatingOverhangTextBox.Size = new System.Drawing.Size(528, 22);
            this.SheatingOverhangTextBox.TabIndex = 5;
            this.SheatingOverhangTextBox.Text = "0.0";
            // 
            // DrukregelAngleCheckBox
            // 
            this.structuresExtender.SetAttributeName(this.DrukregelAngleCheckBox, "DrukregelAngle");
            this.structuresExtender.SetAttributeTypeName(this.DrukregelAngleCheckBox, null);
            this.DrukregelAngleCheckBox.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.DrukregelAngleCheckBox, null);
            this.structuresExtender.SetIsFilter(this.DrukregelAngleCheckBox, true);
            this.DrukregelAngleCheckBox.Location = new System.Drawing.Point(4, 64);
            this.DrukregelAngleCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.DrukregelAngleCheckBox.Name = "DrukregelAngleCheckBox";
            this.DrukregelAngleCheckBox.Size = new System.Drawing.Size(135, 21);
            this.DrukregelAngleCheckBox.TabIndex = 0;
            this.DrukregelAngleCheckBox.Text = "Drukregel angle:";
            this.DrukregelAngleCheckBox.UseVisualStyleBackColor = true;
            // 
            // DrukregelAngleTextBox
            // 
            this.structuresExtender.SetAttributeName(this.DrukregelAngleTextBox, "DrukregelAngle");
            this.structuresExtender.SetAttributeTypeName(this.DrukregelAngleTextBox, "Double");
            this.structuresExtender.SetBindPropertyName(this.DrukregelAngleTextBox, null);
            this.DrukregelAngleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrukregelAngleTextBox.Location = new System.Drawing.Point(151, 64);
            this.DrukregelAngleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DrukregelAngleTextBox.Name = "DrukregelAngleTextBox";
            this.DrukregelAngleTextBox.Size = new System.Drawing.Size(528, 22);
            this.DrukregelAngleTextBox.TabIndex = 1;
            this.DrukregelAngleTextBox.Text = "45.00";
            // 
            // DrukregelProfileCheckBox
            // 
            this.structuresExtender.SetAttributeName(this.DrukregelProfileCheckBox, "DrukregelProfile");
            this.structuresExtender.SetAttributeTypeName(this.DrukregelProfileCheckBox, null);
            this.DrukregelProfileCheckBox.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.DrukregelProfileCheckBox, null);
            this.structuresExtender.SetIsFilter(this.DrukregelProfileCheckBox, true);
            this.DrukregelProfileCheckBox.Location = new System.Drawing.Point(4, 94);
            this.DrukregelProfileCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.DrukregelProfileCheckBox.Name = "DrukregelProfileCheckBox";
            this.DrukregelProfileCheckBox.Size = new System.Drawing.Size(139, 21);
            this.DrukregelProfileCheckBox.TabIndex = 2;
            this.DrukregelProfileCheckBox.Text = "Drukregel profile:";
            this.DrukregelProfileCheckBox.UseVisualStyleBackColor = true;
            // 
            // DrukregelProfileTextBox
            // 
            this.structuresExtender.SetAttributeName(this.DrukregelProfileTextBox, "DrukregelProfile");
            this.structuresExtender.SetAttributeTypeName(this.DrukregelProfileTextBox, "String");
            this.structuresExtender.SetBindPropertyName(this.DrukregelProfileTextBox, null);
            this.DrukregelProfileTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrukregelProfileTextBox.Location = new System.Drawing.Point(151, 94);
            this.DrukregelProfileTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DrukregelProfileTextBox.Name = "DrukregelProfileTextBox";
            this.DrukregelProfileTextBox.Size = new System.Drawing.Size(528, 22);
            this.DrukregelProfileTextBox.TabIndex = 7;
            this.DrukregelProfileTextBox.Text = "DR";
            // 
            // SheatingTypeCheckBox
            // 
            this.structuresExtender.SetAttributeName(this.SheatingTypeCheckBox, "SheatingType");
            this.structuresExtender.SetAttributeTypeName(this.SheatingTypeCheckBox, null);
            this.SheatingTypeCheckBox.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.SheatingTypeCheckBox, null);
            this.structuresExtender.SetIsFilter(this.SheatingTypeCheckBox, true);
            this.SheatingTypeCheckBox.Location = new System.Drawing.Point(4, 124);
            this.SheatingTypeCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.SheatingTypeCheckBox.Name = "SheatingTypeCheckBox";
            this.SheatingTypeCheckBox.Size = new System.Drawing.Size(117, 21);
            this.SheatingTypeCheckBox.TabIndex = 8;
            this.SheatingTypeCheckBox.Text = "Sheating type";
            this.SheatingTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // SheatingTypeComboBox
            // 
            this.structuresExtender.SetAttributeName(this.SheatingTypeComboBox, "SheatingType");
            this.structuresExtender.SetAttributeTypeName(this.SheatingTypeComboBox, "Integer");
            this.structuresExtender.SetBindPropertyName(this.SheatingTypeComboBox, "SelectedIndex");
            this.SheatingTypeComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SheatingTypeComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SheatingTypeComboBox.Items.AddRange(new object[] {
            "Naturel",
            "Wit Spanolak"});
            this.SheatingTypeComboBox.Location = new System.Drawing.Point(150, 122);
            this.SheatingTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SheatingTypeComboBox.Name = "SheatingTypeComboBox";
            this.SheatingTypeComboBox.Size = new System.Drawing.Size(151, 24);
            this.SheatingTypeComboBox.TabIndex = 9;
            this.SheatingTypeComboBox.Text = "Naturel";
            // 
            // LengthCheckBox
            // 
            this.structuresExtender.SetAttributeName(this.LengthCheckBox, "Length");
            this.structuresExtender.SetAttributeTypeName(this.LengthCheckBox, null);
            this.LengthCheckBox.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.LengthCheckBox, null);
            this.structuresExtender.SetIsFilter(this.LengthCheckBox, true);
            this.LengthCheckBox.Location = new System.Drawing.Point(4, 153);
            this.LengthCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.LengthCheckBox.Name = "LengthCheckBox";
            this.LengthCheckBox.Size = new System.Drawing.Size(137, 21);
            this.LengthCheckBox.TabIndex = 0;
            this.LengthCheckBox.Text = "Knee wall length:";
            this.LengthCheckBox.UseVisualStyleBackColor = true;
            // 
            // LengthTextBox
            // 
            this.structuresExtender.SetAttributeName(this.LengthTextBox, "Length");
            this.structuresExtender.SetAttributeTypeName(this.LengthTextBox, "Distance");
            this.structuresExtender.SetBindPropertyName(this.LengthTextBox, null);
            this.LengthTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LengthTextBox.Location = new System.Drawing.Point(151, 153);
            this.LengthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(528, 22);
            this.LengthTextBox.TabIndex = 1;
            this.LengthTextBox.Text = "2440";
            // 
            // okApplyModifyGetOnOffCancel1
            // 
            this.structuresExtender.SetAttributeName(this.okApplyModifyGetOnOffCancel1, null);
            this.structuresExtender.SetAttributeTypeName(this.okApplyModifyGetOnOffCancel1, null);
            this.okApplyModifyGetOnOffCancel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.structuresExtender.SetBindPropertyName(this.okApplyModifyGetOnOffCancel1, null);
            this.okApplyModifyGetOnOffCancel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okApplyModifyGetOnOffCancel1.Location = new System.Drawing.Point(5, 467);
            this.okApplyModifyGetOnOffCancel1.Margin = new System.Windows.Forms.Padding(5);
            this.okApplyModifyGetOnOffCancel1.Name = "okApplyModifyGetOnOffCancel1";
            this.okApplyModifyGetOnOffCancel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.okApplyModifyGetOnOffCancel1.Size = new System.Drawing.Size(697, 33);
            this.okApplyModifyGetOnOffCancel1.TabIndex = 3;
            this.okApplyModifyGetOnOffCancel1.OkClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_OkClicked);
            this.okApplyModifyGetOnOffCancel1.ApplyClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_ApplyClicked);
            this.okApplyModifyGetOnOffCancel1.ModifyClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_ModifyClicked);
            this.okApplyModifyGetOnOffCancel1.GetClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_GetClicked);
            this.okApplyModifyGetOnOffCancel1.OnOffClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_OnOffClicked);
            this.okApplyModifyGetOnOffCancel1.CancelClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_CancelClicked);
            // 
            // groupBox1
            // 
            this.structuresExtender.SetAttributeName(this.groupBox1, null);
            this.structuresExtender.SetAttributeTypeName(this.groupBox1, null);
            this.structuresExtender.SetBindPropertyName(this.groupBox1, null);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(330, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(3, 105);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.structuresExtender.SetAttributeName(this.tableLayoutPanel2, null);
            this.structuresExtender.SetAttributeTypeName(this.tableLayoutPanel2, null);
            this.structuresExtender.SetBindPropertyName(this.tableLayoutPanel2, null);
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.saveLoad2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // saveLoad2
            // 
            this.structuresExtender.SetAttributeName(this.saveLoad2, null);
            this.structuresExtender.SetAttributeTypeName(this.saveLoad2, null);
            this.saveLoad2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.structuresExtender.SetBindPropertyName(this.saveLoad2, null);
            this.tableLayoutPanel2.SetColumnSpan(this.saveLoad2, 4);
            this.saveLoad2.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveLoad2.HelpFileType = Tekla.Structures.Dialog.UIControls.SaveLoad.HelpFileTypeEnum.General;
            this.saveLoad2.HelpKeyword = "";
            this.saveLoad2.HelpUrl = "";
            this.saveLoad2.Location = new System.Drawing.Point(4, 4);
            this.saveLoad2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveLoad2.Name = "saveLoad2";
            this.saveLoad2.SaveAsText = "";
            this.saveLoad2.Size = new System.Drawing.Size(192, 12);
            this.saveLoad2.TabIndex = 0;
            this.saveLoad2.UserDefinedHelpFilePath = null;
            // 
            // tabControl2
            // 
            this.structuresExtender.SetAttributeName(this.tabControl2, null);
            this.structuresExtender.SetAttributeTypeName(this.tabControl2, null);
            this.structuresExtender.SetBindPropertyName(this.tabControl2, null);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(3, -6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(90, 1);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.structuresExtender.SetAttributeName(this.tabPage3, null);
            this.structuresExtender.SetAttributeTypeName(this.tabPage3, null);
            this.structuresExtender.SetBindPropertyName(this.tabPage3, null);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(82, 0);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.structuresExtender.SetAttributeName(this.tabPage4, null);
            this.structuresExtender.SetAttributeTypeName(this.tabPage4, null);
            this.structuresExtender.SetBindPropertyName(this.tabPage4, null);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(82, 0);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // KneeWallForm
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(707, 505);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KneeWallForm";
            this.Text = "KneeWallForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.PropertiesTabPage1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Tekla.Structures.Dialog.UIControls.SaveLoad saveLoad1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PropertiesTabPage1;
        //private System.Windows.Forms.TabPage ReinforcementPropertiesTabPage;
        private Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel okApplyModifyGetOnOffCancel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Tekla.Structures.Dialog.UIControls.SaveLoad saveLoad2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox DrukregelAngleCheckBox;
        private System.Windows.Forms.TextBox DrukregelAngleTextBox;
        //private System.Windows.Forms.CheckBox BeamClassCheckBox4;
        private System.Windows.Forms.CheckBox BeamProfileCheckBox1;
        //private System.Windows.Forms.CheckBox BeamMaterialCheckBox;
        //private System.Windows.Forms.CheckBox BeamFinishCheckBox;
        //private Tekla.Structures.Dialog.UIControls.ProfileCatalog profileCatalog1;
        private System.Windows.Forms.TextBox BeamProfileTextBox;
        private System.Windows.Forms.TextBox DrukregelProfileTextBox;
        private System.Windows.Forms.CheckBox DrukregelProfileCheckBox;
        //private System.Windows.Forms.TextBox BeamMaterialTextBox;
        //private System.Windows.Forms.TextBox BeamFinishTextBox;
        //private System.Windows.Forms.TextBox BeamClassTextBox;
        //private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.CheckBox SheatingOverhangCheckBox;
        //private System.Windows.Forms.CheckBox RebarClassCheckBox;
        //private System.Windows.Forms.CheckBox RebarSizeCheckBox;
        //private System.Windows.Forms.CheckBox RebarGradeCheckBox;
        //private System.Windows.Forms.CheckBox RebarBendingRadiusCheckBox;
        private System.Windows.Forms.TextBox SheatingOverhangTextBox;
        //private System.Windows.Forms.TextBox RebarSizeTextBox;
        //private System.Windows.Forms.TextBox RebarGradeTextBox;
        //private System.Windows.Forms.TextBox RebarBendingRadiusTextBox;
        //private System.Windows.Forms.TextBox RebarClassTextBox;
        //private Tekla.Structures.Dialog.UIControls.ReinforcementCatalog reinforcementCatalog1;
        private System.Windows.Forms.GroupBox groupBox1;
        //private System.Windows.Forms.TextBox RebarSpacingTextBox;
        //private System.Windows.Forms.CheckBox RebarSpacingCheckBox;
        private System.Windows.Forms.ComboBox SheatingTypeComboBox;
        private System.Windows.Forms.CheckBox SheatingTypeCheckBox;
        private System.Windows.Forms.CheckBox LengthCheckBox;
        private System.Windows.Forms.TextBox LengthTextBox;

    }
}
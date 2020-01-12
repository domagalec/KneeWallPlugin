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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KneeWallForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.saveLoad1 = new Tekla.Structures.Dialog.UIControls.SaveLoad();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PropertiesTabPage1 = new System.Windows.Forms.TabPage();
            this.BeamProfileCheckBox1 = new System.Windows.Forms.CheckBox();
            this.BeamProfileTextBox = new System.Windows.Forms.TextBox();
            this.SheatingOverhangCheckBox = new System.Windows.Forms.CheckBox();
            this.SheatingOverhangTextBox = new System.Windows.Forms.TextBox();
            this.DrukregelAngleCheckBox = new System.Windows.Forms.CheckBox();
            this.DrukregelAngleTextBox = new System.Windows.Forms.TextBox();
            this.DrukregelProfileCheckBox = new System.Windows.Forms.CheckBox();
            this.DrukregelProfileTextBox = new System.Windows.Forms.TextBox();
            this.DrukregelMovementCheckBox = new System.Windows.Forms.CheckBox();
            this.DrukregelMovementTextBox = new System.Windows.Forms.TextBox();
            this.SheatingTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.SheatingTypeComboBox = new System.Windows.Forms.ComboBox();
            this.okApplyModifyGetOnOffCancel1 = new Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel();
            this.LengthCheckBox = new System.Windows.Forms.CheckBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.saveLoad2 = new Tekla.Structures.Dialog.UIControls.SaveLoad();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.PropertiesTabPage1.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(697, 505);
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
            this.saveLoad1.Size = new System.Drawing.Size(687, 53);
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
            this.tabControl1.Size = new System.Drawing.Size(689, 391);
            this.tabControl1.TabIndex = 2;
            // 
            // PropertiesTabPage1
            // 
            this.structuresExtender.SetAttributeName(this.PropertiesTabPage1, null);
            this.structuresExtender.SetAttributeTypeName(this.PropertiesTabPage1, null);
            this.PropertiesTabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PropertiesTabPage1.BackgroundImage")));
            this.PropertiesTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.structuresExtender.SetBindPropertyName(this.PropertiesTabPage1, null);
            this.PropertiesTabPage1.Controls.Add(this.BeamProfileCheckBox1);
            this.PropertiesTabPage1.Controls.Add(this.BeamProfileTextBox);
            this.PropertiesTabPage1.Controls.Add(this.SheatingOverhangCheckBox);
            this.PropertiesTabPage1.Controls.Add(this.SheatingOverhangTextBox);
            this.PropertiesTabPage1.Controls.Add(this.DrukregelAngleCheckBox);
            this.PropertiesTabPage1.Controls.Add(this.DrukregelAngleTextBox);
            this.PropertiesTabPage1.Controls.Add(this.DrukregelProfileCheckBox);
            this.PropertiesTabPage1.Controls.Add(this.DrukregelProfileTextBox);
            this.PropertiesTabPage1.Controls.Add(this.DrukregelMovementCheckBox);
            this.PropertiesTabPage1.Controls.Add(this.DrukregelMovementTextBox);
            this.PropertiesTabPage1.Controls.Add(this.SheatingTypeCheckBox);
            this.PropertiesTabPage1.Controls.Add(this.SheatingTypeComboBox);
            this.PropertiesTabPage1.Location = new System.Drawing.Point(4, 25);
            this.PropertiesTabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.PropertiesTabPage1.Name = "PropertiesTabPage1";
            this.PropertiesTabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.PropertiesTabPage1.Size = new System.Drawing.Size(681, 362);
            this.PropertiesTabPage1.TabIndex = 0;
            this.PropertiesTabPage1.Text = "Properties";
            this.PropertiesTabPage1.UseVisualStyleBackColor = true;
            // 
            // BeamProfileCheckBox1
            // 
            this.structuresExtender.SetAttributeName(this.BeamProfileCheckBox1, "BeamProfile");
            this.structuresExtender.SetAttributeTypeName(this.BeamProfileCheckBox1, null);
            this.BeamProfileCheckBox1.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.BeamProfileCheckBox1, null);
            this.structuresExtender.SetIsFilter(this.BeamProfileCheckBox1, true);
            this.BeamProfileCheckBox1.Location = new System.Drawing.Point(387, 32);
            this.BeamProfileCheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.BeamProfileCheckBox1.Name = "BeamProfileCheckBox1";
            this.BeamProfileCheckBox1.Size = new System.Drawing.Size(137, 21);
            this.BeamProfileCheckBox1.TabIndex = 2;
            this.BeamProfileCheckBox1.Text = "Knee wall profile:";
            this.BeamProfileCheckBox1.UseVisualStyleBackColor = true;
            // 
            // BeamProfileTextBox
            // 
            this.structuresExtender.SetAttributeName(this.BeamProfileTextBox, "BeamProfile");
            this.structuresExtender.SetAttributeTypeName(this.BeamProfileTextBox, "String");
            this.structuresExtender.SetBindPropertyName(this.BeamProfileTextBox, null);
            this.BeamProfileTextBox.Location = new System.Drawing.Point(532, 30);
            this.BeamProfileTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BeamProfileTextBox.Name = "BeamProfileTextBox";
            this.BeamProfileTextBox.Size = new System.Drawing.Size(100, 22);
            this.BeamProfileTextBox.TabIndex = 5;
            this.BeamProfileTextBox.Text = "45*70";
            // 
            // SheatingOverhangCheckBox
            // 
            this.structuresExtender.SetAttributeName(this.SheatingOverhangCheckBox, "SheatingOverhang");
            this.structuresExtender.SetAttributeTypeName(this.SheatingOverhangCheckBox, null);
            this.SheatingOverhangCheckBox.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.SheatingOverhangCheckBox, null);
            this.structuresExtender.SetIsFilter(this.SheatingOverhangCheckBox, true);
            this.SheatingOverhangCheckBox.Location = new System.Drawing.Point(149, 100);
            this.SheatingOverhangCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.SheatingOverhangCheckBox.Name = "SheatingOverhangCheckBox";
            this.SheatingOverhangCheckBox.Size = new System.Drawing.Size(18, 17);
            this.SheatingOverhangCheckBox.TabIndex = 0;
            this.SheatingOverhangCheckBox.UseVisualStyleBackColor = true;
            // 
            // SheatingOverhangTextBox
            // 
            this.structuresExtender.SetAttributeName(this.SheatingOverhangTextBox, "SheatingOverhang");
            this.structuresExtender.SetAttributeTypeName(this.SheatingOverhangTextBox, "Distance");
            this.structuresExtender.SetBindPropertyName(this.SheatingOverhangTextBox, null);
            this.SheatingOverhangTextBox.Location = new System.Drawing.Point(175, 96);
            this.SheatingOverhangTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SheatingOverhangTextBox.Name = "SheatingOverhangTextBox";
            this.SheatingOverhangTextBox.Size = new System.Drawing.Size(48, 22);
            this.SheatingOverhangTextBox.TabIndex = 1;
            this.SheatingOverhangTextBox.Text = "0.0";
            // 
            // DrukregelAngleCheckBox
            // 
            this.structuresExtender.SetAttributeName(this.DrukregelAngleCheckBox, "DrukregelAngle");
            this.structuresExtender.SetAttributeTypeName(this.DrukregelAngleCheckBox, null);
            this.DrukregelAngleCheckBox.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.DrukregelAngleCheckBox, null);
            this.structuresExtender.SetIsFilter(this.DrukregelAngleCheckBox, true);
            this.DrukregelAngleCheckBox.Location = new System.Drawing.Point(465, 166);
            this.DrukregelAngleCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.DrukregelAngleCheckBox.Name = "DrukregelAngleCheckBox";
            this.DrukregelAngleCheckBox.Size = new System.Drawing.Size(18, 17);
            this.DrukregelAngleCheckBox.TabIndex = 0;
            this.DrukregelAngleCheckBox.UseVisualStyleBackColor = true;
            // 
            // DrukregelAngleTextBox
            // 
            this.structuresExtender.SetAttributeName(this.DrukregelAngleTextBox, "DrukregelAngle");
            this.structuresExtender.SetAttributeTypeName(this.DrukregelAngleTextBox, "Double");
            this.structuresExtender.SetBindPropertyName(this.DrukregelAngleTextBox, null);
            this.DrukregelAngleTextBox.Location = new System.Drawing.Point(491, 162);
            this.DrukregelAngleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DrukregelAngleTextBox.Name = "DrukregelAngleTextBox";
            this.DrukregelAngleTextBox.Size = new System.Drawing.Size(48, 22);
            this.DrukregelAngleTextBox.TabIndex = 2;
            this.DrukregelAngleTextBox.Text = "45.00";
            // 
            // DrukregelProfileCheckBox
            // 
            this.structuresExtender.SetAttributeName(this.DrukregelProfileCheckBox, "DrukregelProfile");
            this.structuresExtender.SetAttributeTypeName(this.DrukregelProfileCheckBox, null);
            this.DrukregelProfileCheckBox.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.DrukregelProfileCheckBox, null);
            this.structuresExtender.SetIsFilter(this.DrukregelProfileCheckBox, true);
            this.DrukregelProfileCheckBox.Location = new System.Drawing.Point(387, 61);
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
            this.DrukregelProfileTextBox.Location = new System.Drawing.Point(532, 59);
            this.DrukregelProfileTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DrukregelProfileTextBox.Name = "DrukregelProfileTextBox";
            this.DrukregelProfileTextBox.Size = new System.Drawing.Size(48, 22);
            this.DrukregelProfileTextBox.TabIndex = 7;
            this.DrukregelProfileTextBox.Text = "DR";
            // 
            // DrukregelMovementCheckBox
            // 
            this.structuresExtender.SetAttributeName(this.DrukregelMovementCheckBox, "DrukregelMovement");
            this.structuresExtender.SetAttributeTypeName(this.DrukregelMovementCheckBox, null);
            this.DrukregelMovementCheckBox.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.DrukregelMovementCheckBox, null);
            this.structuresExtender.SetIsFilter(this.DrukregelMovementCheckBox, true);
            this.DrukregelMovementCheckBox.Location = new System.Drawing.Point(387, 212);
            this.DrukregelMovementCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.DrukregelMovementCheckBox.Name = "DrukregelMovementCheckBox";
            this.DrukregelMovementCheckBox.Size = new System.Drawing.Size(18, 17);
            this.DrukregelMovementCheckBox.TabIndex = 0;
            this.DrukregelMovementCheckBox.UseVisualStyleBackColor = true;
            // 
            // DrukregelMovementTextBox
            // 
            this.structuresExtender.SetAttributeName(this.DrukregelMovementTextBox, "DrukregelMovement");
            this.structuresExtender.SetAttributeTypeName(this.DrukregelMovementTextBox, "Distance");
            this.structuresExtender.SetBindPropertyName(this.DrukregelMovementTextBox, null);
            this.DrukregelMovementTextBox.Location = new System.Drawing.Point(413, 208);
            this.DrukregelMovementTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DrukregelMovementTextBox.Name = "DrukregelMovementTextBox";
            this.DrukregelMovementTextBox.Size = new System.Drawing.Size(48, 22);
            this.DrukregelMovementTextBox.TabIndex = 3;
            this.DrukregelMovementTextBox.Text = "0.0";
            // 
            // SheatingTypeCheckBox
            // 
            this.structuresExtender.SetAttributeName(this.SheatingTypeCheckBox, "SheatingType");
            this.structuresExtender.SetAttributeTypeName(this.SheatingTypeCheckBox, null);
            this.SheatingTypeCheckBox.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.SheatingTypeCheckBox, null);
            this.structuresExtender.SetIsFilter(this.SheatingTypeCheckBox, true);
            this.SheatingTypeCheckBox.Location = new System.Drawing.Point(78, 265);
            this.SheatingTypeCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.SheatingTypeCheckBox.Name = "SheatingTypeCheckBox";
            this.SheatingTypeCheckBox.Size = new System.Drawing.Size(18, 17);
            this.SheatingTypeCheckBox.TabIndex = 8;
            this.SheatingTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // SheatingTypeComboBox
            // 
            this.structuresExtender.SetAttributeName(this.SheatingTypeComboBox, "SheatingType");
            this.structuresExtender.SetAttributeTypeName(this.SheatingTypeComboBox, "Integer");
            this.structuresExtender.SetBindPropertyName(this.SheatingTypeComboBox, "SelectedIndex");
            this.SheatingTypeComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SheatingTypeComboBox.Items.AddRange(new object[] {
            "Naturel",
            "Wit Spanolak"});
            this.SheatingTypeComboBox.Location = new System.Drawing.Point(103, 261);
            this.SheatingTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SheatingTypeComboBox.Name = "SheatingTypeComboBox";
            this.SheatingTypeComboBox.Size = new System.Drawing.Size(120, 24);
            this.SheatingTypeComboBox.TabIndex = 4;
            this.SheatingTypeComboBox.Text = "Naturel";
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
            this.okApplyModifyGetOnOffCancel1.Size = new System.Drawing.Size(687, 33);
            this.okApplyModifyGetOnOffCancel1.TabIndex = 3;
            this.okApplyModifyGetOnOffCancel1.OkClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_OkClicked);
            this.okApplyModifyGetOnOffCancel1.ApplyClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_ApplyClicked);
            this.okApplyModifyGetOnOffCancel1.ModifyClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_ModifyClicked);
            this.okApplyModifyGetOnOffCancel1.GetClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_GetClicked);
            this.okApplyModifyGetOnOffCancel1.OnOffClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_OnOffClicked);
            this.okApplyModifyGetOnOffCancel1.CancelClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_CancelClicked);
            // 
            // LengthCheckBox
            // 
            this.structuresExtender.SetAttributeName(this.LengthCheckBox, "Length");
            this.structuresExtender.SetAttributeTypeName(this.LengthCheckBox, null);
            this.LengthCheckBox.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.LengthCheckBox, null);
            this.structuresExtender.SetIsFilter(this.LengthCheckBox, true);
            this.LengthCheckBox.Location = new System.Drawing.Point(387, 91);
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
            this.LengthTextBox.Location = new System.Drawing.Point(532, 89);
            this.LengthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(96, 22);
            this.LengthTextBox.TabIndex = 1;
            this.LengthTextBox.Text = "2440";
            // 
            // tableLayoutPanel3
            // 
            this.structuresExtender.SetAttributeName(this.tableLayoutPanel3, null);
            this.structuresExtender.SetAttributeTypeName(this.tableLayoutPanel3, null);
            this.structuresExtender.SetBindPropertyName(this.tableLayoutPanel3, null);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.structuresExtender.SetAttributeName(this.groupBox1, null);
            this.structuresExtender.SetAttributeTypeName(this.groupBox1, null);
            this.structuresExtender.SetBindPropertyName(this.groupBox1, null);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.structuresExtender.SetAttributeName(this.tableLayoutPanel2, null);
            this.structuresExtender.SetAttributeTypeName(this.tableLayoutPanel2, null);
            this.structuresExtender.SetBindPropertyName(this.tableLayoutPanel2, null);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // saveLoad2
            // 
            this.structuresExtender.SetAttributeName(this.saveLoad2, null);
            this.structuresExtender.SetAttributeTypeName(this.saveLoad2, null);
            this.saveLoad2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.structuresExtender.SetBindPropertyName(this.saveLoad2, null);
            this.saveLoad2.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveLoad2.HelpFileType = Tekla.Structures.Dialog.UIControls.SaveLoad.HelpFileTypeEnum.General;
            this.saveLoad2.HelpKeyword = "";
            this.saveLoad2.HelpUrl = "";
            this.saveLoad2.Location = new System.Drawing.Point(0, 0);
            this.saveLoad2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveLoad2.Name = "saveLoad2";
            this.saveLoad2.SaveAsText = "";
            this.saveLoad2.Size = new System.Drawing.Size(797, 53);
            this.saveLoad2.TabIndex = 0;
            this.saveLoad2.UserDefinedHelpFilePath = null;
            // 
            // tabControl2
            // 
            this.structuresExtender.SetAttributeName(this.tabControl2, null);
            this.structuresExtender.SetAttributeTypeName(this.tabControl2, null);
            this.structuresExtender.SetBindPropertyName(this.tabControl2, null);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(200, 100);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.structuresExtender.SetAttributeName(this.tabPage3, null);
            this.structuresExtender.SetAttributeTypeName(this.tabPage3, null);
            this.structuresExtender.SetBindPropertyName(this.tabPage3, null);
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(200, 100);
            this.tabPage3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.structuresExtender.SetAttributeName(this.tabPage4, null);
            this.structuresExtender.SetAttributeTypeName(this.tabPage4, null);
            this.structuresExtender.SetBindPropertyName(this.tabPage4, null);
            this.tabPage4.Location = new System.Drawing.Point(0, 0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(200, 100);
            this.tabPage4.TabIndex = 0;
            // 
            // KneeWallForm
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(697, 505);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KneeWallForm";
            this.Text = "KneeWallForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.PropertiesTabPage1.ResumeLayout(false);
            this.PropertiesTabPage1.PerformLayout();
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
        private System.Windows.Forms.CheckBox DrukregelMovementCheckBox;
        private System.Windows.Forms.TextBox DrukregelMovementTextBox;
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
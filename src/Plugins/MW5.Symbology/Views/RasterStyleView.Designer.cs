﻿using MW5.UI.Controls;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace MW5.Plugins.Symbology.Views
{
    partial class RasterStyleView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RasterStyleView));
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo2 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItemStyleInfo treeNodeAdvSubItemStyleInfo2 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItemStyleInfo();
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdvStyleInfo treeColumnAdvStyleInfo2 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv treeColumnAdv3 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv();
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv treeColumnAdv4 = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.dynamicVisibilityControl1 = new MW5.Plugins.Symbology.Controls.DynamicVisibilityControl();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkLayerPreview = new System.Windows.Forms.CheckBox();
            this.chkLayerVisible = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.txtBriefInfo = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProjectionDetails = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtProjection = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatasourceName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLayerName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.rasterInfoTreeView1 = new MW5.Plugins.Symbology.Controls.RasterInfoTreeView();
            this.tabPageAdv4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.rasterColorSchemeView = new MW5.Plugins.Symbology.Controls.RasterColorSchemeView();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.btnClearColorAdjustments = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbrHue = new System.Windows.Forms.TrackBar();
            this.tbrSaturation = new System.Windows.Forms.TrackBar();
            this.tbrGamma = new System.Windows.Forms.TrackBar();
            this.tbrConstrast = new System.Windows.Forms.TrackBar();
            this.tbrBrightness = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboUpsampling = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cboDownsampling = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelColorize = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.tbrColorizeIntensity = new System.Windows.Forms.TrackBar();
            this.label16 = new System.Windows.Forms.Label();
            this.clpColorize = new MW5.Plugins.Symbology.Controls.ColorPicker.Office2007ColorPicker(this.components);
            this.chkColorize = new System.Windows.Forms.CheckBox();
            this.chkGreyScale = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.tabPageAdv5 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.configPanelControl1 = new MW5.UI.Controls.ConfigPanelControl();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnClearOverviews = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuildOverviews = new Syncfusion.Windows.Forms.ButtonAdv();
            this.cboOverviewType = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboOverviewSampling = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPageAdv6 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.txtGdalInfo = new System.Windows.Forms.RichTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cboDynamicScaleMode = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cboMaxScale = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cboMinScale = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnApply = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLayerVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBriefInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatasourceName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLayerName)).BeginInit();
            this.tabPageAdv2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rasterInfoTreeView1)).BeginInit();
            this.tabPageAdv4.SuspendLayout();
            this.tabPageAdv3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrConstrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBrightness)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboUpsampling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDownsampling)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelColorize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrColorizeIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGreyScale)).BeginInit();
            this.tabPageAdv5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl1)).BeginInit();
            this.configPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboOverviewType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOverviewSampling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPageAdv6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboDynamicScaleMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaxScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMinScale)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(636, 443);
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabControlAdv1.BorderVisible = true;
            this.tabControlAdv1.BorderWidth = 1;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv4);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv3);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv5);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv6);
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.ImageList = this.imageList1;
            this.tabControlAdv1.ItemSize = new System.Drawing.Size(120, 50);
            this.tabControlAdv1.Location = new System.Drawing.Point(3, 12);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Padding = new System.Drawing.Point(5, 10);
            this.tabControlAdv1.RotateTextWhenVertical = true;
            this.tabControlAdv1.Size = new System.Drawing.Size(636, 443);
            this.tabControlAdv1.TabIndex = 0;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererBlendLight);
            this.tabControlAdv1.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.dynamicVisibilityControl1);
            this.tabPageAdv1.Controls.Add(this.groupBox10);
            this.tabPageAdv1.Controls.Add(this.chkLayerVisible);
            this.tabPageAdv1.Controls.Add(this.txtBriefInfo);
            this.tabPageAdv1.Controls.Add(this.label5);
            this.tabPageAdv1.Controls.Add(this.btnProjectionDetails);
            this.tabPageAdv1.Controls.Add(this.txtProjection);
            this.tabPageAdv1.Controls.Add(this.label4);
            this.tabPageAdv1.Controls.Add(this.txtDatasourceName);
            this.tabPageAdv1.Controls.Add(this.label3);
            this.tabPageAdv1.Controls.Add(this.txtLayerName);
            this.tabPageAdv1.Controls.Add(this.label2);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageIndex = 0;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(120, 1);
            this.tabPageAdv1.Margin = new System.Windows.Forms.Padding(20);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(515, 441);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "General";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // dynamicVisibilityControl1
            // 
            this.dynamicVisibilityControl1.CurrentScale = 0D;
            this.dynamicVisibilityControl1.CurrentZoom = 0;
            this.dynamicVisibilityControl1.Location = new System.Drawing.Point(22, 213);
            this.dynamicVisibilityControl1.MaxScale = 1000000D;
            this.dynamicVisibilityControl1.MaxZoom = 24;
            this.dynamicVisibilityControl1.MinScale = 100D;
            this.dynamicVisibilityControl1.MinZoom = 1;
            this.dynamicVisibilityControl1.Mode = MW5.Api.Enums.DynamicVisibilityMode.Scale;
            this.dynamicVisibilityControl1.Name = "dynamicVisibilityControl1";
            this.dynamicVisibilityControl1.Size = new System.Drawing.Size(232, 207);
            this.dynamicVisibilityControl1.TabIndex = 164;
            this.dynamicVisibilityControl1.UseDynamicVisiblity = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.pictureBox1);
            this.groupBox10.Controls.Add(this.chkLayerPreview);
            this.groupBox10.Location = new System.Drawing.Point(269, 213);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(227, 210);
            this.groupBox10.TabIndex = 180;
            this.groupBox10.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 163;
            this.pictureBox1.TabStop = false;
            // 
            // chkLayerPreview
            // 
            this.chkLayerPreview.AutoSize = true;
            this.chkLayerPreview.Location = new System.Drawing.Point(6, 0);
            this.chkLayerPreview.Name = "chkLayerPreview";
            this.chkLayerPreview.Size = new System.Drawing.Size(93, 17);
            this.chkLayerPreview.TabIndex = 162;
            this.chkLayerPreview.Text = "Show preview";
            this.chkLayerPreview.UseVisualStyleBackColor = true;
            // 
            // chkLayerVisible
            // 
            this.chkLayerVisible.BeforeTouchSize = new System.Drawing.Size(63, 21);
            this.chkLayerVisible.Location = new System.Drawing.Point(433, 24);
            this.chkLayerVisible.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.chkLayerVisible.Name = "chkLayerVisible";
            this.chkLayerVisible.Size = new System.Drawing.Size(63, 21);
            this.chkLayerVisible.TabIndex = 179;
            this.chkLayerVisible.Text = "Visible";
            this.chkLayerVisible.ThemesEnabled = false;
            // 
            // txtBriefInfo
            // 
            this.txtBriefInfo.BeforeTouchSize = new System.Drawing.Size(100, 20);
            this.txtBriefInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBriefInfo.Location = new System.Drawing.Point(128, 145);
            this.txtBriefInfo.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBriefInfo.Name = "txtBriefInfo";
            this.txtBriefInfo.ReadOnly = true;
            this.txtBriefInfo.Size = new System.Drawing.Size(368, 20);
            this.txtBriefInfo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBriefInfo.TabIndex = 8;
            this.txtBriefInfo.Text = "800 * 600 pixels, 3 bands; rendered as RGB image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Information";
            // 
            // btnProjectionDetails
            // 
            this.btnProjectionDetails.BeforeTouchSize = new System.Drawing.Size(63, 23);
            this.btnProjectionDetails.IsBackStageButton = false;
            this.btnProjectionDetails.Location = new System.Drawing.Point(433, 101);
            this.btnProjectionDetails.Name = "btnProjectionDetails";
            this.btnProjectionDetails.Size = new System.Drawing.Size(63, 23);
            this.btnProjectionDetails.TabIndex = 6;
            this.btnProjectionDetails.Text = "Details";
            // 
            // txtProjection
            // 
            this.txtProjection.BeforeTouchSize = new System.Drawing.Size(100, 20);
            this.txtProjection.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProjection.Location = new System.Drawing.Point(128, 104);
            this.txtProjection.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtProjection.Name = "txtProjection";
            this.txtProjection.ReadOnly = true;
            this.txtProjection.Size = new System.Drawing.Size(299, 20);
            this.txtProjection.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtProjection.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Coordinate system";
            // 
            // txtDatasourceName
            // 
            this.txtDatasourceName.BeforeTouchSize = new System.Drawing.Size(100, 20);
            this.txtDatasourceName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatasourceName.Location = new System.Drawing.Point(128, 63);
            this.txtDatasourceName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDatasourceName.Name = "txtDatasourceName";
            this.txtDatasourceName.ReadOnly = true;
            this.txtDatasourceName.Size = new System.Drawing.Size(368, 20);
            this.txtDatasourceName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDatasourceName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datasource name";
            // 
            // txtLayerName
            // 
            this.txtLayerName.BeforeTouchSize = new System.Drawing.Size(100, 20);
            this.txtLayerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLayerName.Location = new System.Drawing.Point(128, 24);
            this.txtLayerName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtLayerName.Name = "txtLayerName";
            this.txtLayerName.Size = new System.Drawing.Size(299, 20);
            this.txtLayerName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtLayerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Layer name";
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Controls.Add(this.rasterInfoTreeView1);
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageIndex = 1;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(120, 1);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(515, 441);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "Info";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // rasterInfoTreeView1
            // 
            this.rasterInfoTreeView1.AutoAdjustMultiLineHeight = true;
            treeNodeAdvStyleInfo2.ThemesEnabled = false;
            this.rasterInfoTreeView1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair("Standard", treeNodeAdvStyleInfo2),
            new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair("Standard - SubItem", treeNodeAdvSubItemStyleInfo2),
            new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair("Standard - Column", treeColumnAdvStyleInfo2)});
            this.rasterInfoTreeView1.BeforeTouchSize = new System.Drawing.Size(515, 441);
            this.rasterInfoTreeView1.BorderColor = System.Drawing.Color.Silver;
            this.rasterInfoTreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            treeColumnAdv3.Highlighted = false;
            treeColumnAdv3.Text = "Name";
            treeColumnAdv3.Width = 260;
            treeColumnAdv4.Highlighted = false;
            treeColumnAdv4.Text = "Value";
            treeColumnAdv4.Width = 200;
            this.rasterInfoTreeView1.Columns.AddRange(new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdv[] {
            treeColumnAdv3,
            treeColumnAdv4});
            this.rasterInfoTreeView1.ColumnsHeaderBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control);
            this.rasterInfoTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rasterInfoTreeView1.FullRowSelect = true;
            this.rasterInfoTreeView1.GutterSpace = 12;
            // 
            // 
            // 
            this.rasterInfoTreeView1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rasterInfoTreeView1.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.rasterInfoTreeView1.HelpTextControl.Name = "m_helpText";
            this.rasterInfoTreeView1.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.rasterInfoTreeView1.HelpTextControl.TabIndex = 0;
            this.rasterInfoTreeView1.HelpTextControl.Text = "help text";
            this.rasterInfoTreeView1.HideSelection = false;
            this.rasterInfoTreeView1.Location = new System.Drawing.Point(0, 0);
            this.rasterInfoTreeView1.Margin = new System.Windows.Forms.Padding(5);
            this.rasterInfoTreeView1.Name = "rasterInfoTreeView1";
            this.rasterInfoTreeView1.ShowColumnsHeader = false;
            this.rasterInfoTreeView1.ShowLines = false;
            this.rasterInfoTreeView1.ShowRootLines = false;
            this.rasterInfoTreeView1.Size = new System.Drawing.Size(515, 441);
            this.rasterInfoTreeView1.Style = Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.MultiColumnVisualStyle.Metro;
            this.rasterInfoTreeView1.TabIndex = 0;
            this.rasterInfoTreeView1.Text = "rasterInfoTreeView1";
            this.rasterInfoTreeView1.ThemesEnabled = false;
            // 
            // 
            // 
            this.rasterInfoTreeView1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.rasterInfoTreeView1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rasterInfoTreeView1.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.rasterInfoTreeView1.ToolTipControl.Name = "m_toolTip";
            this.rasterInfoTreeView1.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.rasterInfoTreeView1.ToolTipControl.TabIndex = 1;
            this.rasterInfoTreeView1.ToolTipControl.Text = "toolTip";
            // 
            // tabPageAdv4
            // 
            this.tabPageAdv4.Controls.Add(this.rasterColorSchemeView);
            this.tabPageAdv4.Image = null;
            this.tabPageAdv4.ImageIndex = 2;
            this.tabPageAdv4.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv4.Location = new System.Drawing.Point(120, 1);
            this.tabPageAdv4.Name = "tabPageAdv4";
            this.tabPageAdv4.ShowCloseButton = true;
            this.tabPageAdv4.Size = new System.Drawing.Size(515, 441);
            this.tabPageAdv4.TabIndex = 4;
            this.tabPageAdv4.Text = "Colors";
            this.tabPageAdv4.ThemesEnabled = false;
            // 
            // rasterColorSchemeView
            // 
            this.rasterColorSchemeView.ColorScheme = null;
            this.rasterColorSchemeView.Location = new System.Drawing.Point(6, 5);
            this.rasterColorSchemeView.Name = "rasterColorSchemeView";
            this.rasterColorSchemeView.Size = new System.Drawing.Size(500, 433);
            this.rasterColorSchemeView.TabIndex = 0;
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.Controls.Add(this.btnClearColorAdjustments);
            this.tabPageAdv3.Controls.Add(this.groupBox3);
            this.tabPageAdv3.Controls.Add(this.groupBox2);
            this.tabPageAdv3.Controls.Add(this.groupBox1);
            this.tabPageAdv3.Controls.Add(this.chkGreyScale);
            this.tabPageAdv3.Image = null;
            this.tabPageAdv3.ImageIndex = 3;
            this.tabPageAdv3.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv3.Location = new System.Drawing.Point(120, 1);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.ShowCloseButton = true;
            this.tabPageAdv3.Size = new System.Drawing.Size(515, 441);
            this.tabPageAdv3.TabIndex = 3;
            this.tabPageAdv3.Text = "Rendering";
            this.tabPageAdv3.ThemesEnabled = false;
            // 
            // btnClearColorAdjustments
            // 
            this.btnClearColorAdjustments.BeforeTouchSize = new System.Drawing.Size(82, 23);
            this.btnClearColorAdjustments.IsBackStageButton = false;
            this.btnClearColorAdjustments.Location = new System.Drawing.Point(410, 291);
            this.btnClearColorAdjustments.Name = "btnClearColorAdjustments";
            this.btnClearColorAdjustments.Size = new System.Drawing.Size(82, 23);
            this.btnClearColorAdjustments.TabIndex = 62;
            this.btnClearColorAdjustments.Text = "Set defaults";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbrHue);
            this.groupBox3.Controls.Add(this.tbrSaturation);
            this.groupBox3.Controls.Add(this.tbrGamma);
            this.groupBox3.Controls.Add(this.tbrConstrast);
            this.groupBox3.Controls.Add(this.tbrBrightness);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(23, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 184);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adjustments";
            // 
            // tbrHue
            // 
            this.tbrHue.AutoSize = false;
            this.tbrHue.Location = new System.Drawing.Point(19, 149);
            this.tbrHue.Maximum = 180;
            this.tbrHue.Minimum = -180;
            this.tbrHue.Name = "tbrHue";
            this.tbrHue.Size = new System.Drawing.Size(209, 24);
            this.tbrHue.SmallChange = 10;
            this.tbrHue.TabIndex = 61;
            this.tbrHue.TickFrequency = 20;
            // 
            // tbrSaturation
            // 
            this.tbrSaturation.AutoSize = false;
            this.tbrSaturation.Location = new System.Drawing.Point(243, 97);
            this.tbrSaturation.Maximum = 60;
            this.tbrSaturation.Name = "tbrSaturation";
            this.tbrSaturation.Size = new System.Drawing.Size(209, 24);
            this.tbrSaturation.SmallChange = 10;
            this.tbrSaturation.TabIndex = 60;
            this.tbrSaturation.TickFrequency = 4;
            this.tbrSaturation.Value = 20;
            // 
            // tbrGamma
            // 
            this.tbrGamma.AutoSize = false;
            this.tbrGamma.Location = new System.Drawing.Point(19, 97);
            this.tbrGamma.Maximum = 80;
            this.tbrGamma.Minimum = 4;
            this.tbrGamma.Name = "tbrGamma";
            this.tbrGamma.Size = new System.Drawing.Size(209, 24);
            this.tbrGamma.SmallChange = 10;
            this.tbrGamma.TabIndex = 59;
            this.tbrGamma.TickFrequency = 4;
            this.tbrGamma.Value = 20;
            // 
            // tbrConstrast
            // 
            this.tbrConstrast.AutoSize = false;
            this.tbrConstrast.Location = new System.Drawing.Point(243, 43);
            this.tbrConstrast.Maximum = 80;
            this.tbrConstrast.Minimum = 4;
            this.tbrConstrast.Name = "tbrConstrast";
            this.tbrConstrast.Size = new System.Drawing.Size(209, 24);
            this.tbrConstrast.SmallChange = 10;
            this.tbrConstrast.TabIndex = 58;
            this.tbrConstrast.TickFrequency = 4;
            this.tbrConstrast.Value = 20;
            // 
            // tbrBrightness
            // 
            this.tbrBrightness.AutoSize = false;
            this.tbrBrightness.Location = new System.Drawing.Point(19, 43);
            this.tbrBrightness.Maximum = 20;
            this.tbrBrightness.Minimum = -20;
            this.tbrBrightness.Name = "tbrBrightness";
            this.tbrBrightness.Size = new System.Drawing.Size(209, 24);
            this.tbrBrightness.SmallChange = 10;
            this.tbrBrightness.TabIndex = 57;
            this.tbrBrightness.TickFrequency = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Brightness";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Contrast";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(246, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Saturation";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 55;
            this.label15.Text = "Gamma";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "Hue";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cboUpsampling);
            this.groupBox2.Controls.Add(this.cboDownsampling);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(16, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 80);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interpolation mode";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Upsampling";
            // 
            // cboUpsampling
            // 
            this.cboUpsampling.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboUpsampling.BeforeTouchSize = new System.Drawing.Size(201, 21);
            this.cboUpsampling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpsampling.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboUpsampling.Location = new System.Drawing.Point(15, 44);
            this.cboUpsampling.Name = "cboUpsampling";
            this.cboUpsampling.Size = new System.Drawing.Size(201, 21);
            this.cboUpsampling.TabIndex = 44;
            // 
            // cboDownsampling
            // 
            this.cboDownsampling.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDownsampling.BeforeTouchSize = new System.Drawing.Size(207, 21);
            this.cboDownsampling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDownsampling.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboDownsampling.Location = new System.Drawing.Point(232, 44);
            this.cboDownsampling.Name = "cboDownsampling";
            this.cboDownsampling.Size = new System.Drawing.Size(207, 21);
            this.cboDownsampling.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(234, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Downsampling";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelColorize);
            this.groupBox1.Controls.Add(this.chkColorize);
            this.groupBox1.Location = new System.Drawing.Point(23, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 63);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            // 
            // panelColorize
            // 
            this.panelColorize.Controls.Add(this.label17);
            this.panelColorize.Controls.Add(this.tbrColorizeIntensity);
            this.panelColorize.Controls.Add(this.label16);
            this.panelColorize.Controls.Add(this.clpColorize);
            this.panelColorize.Location = new System.Drawing.Point(19, 21);
            this.panelColorize.Name = "panelColorize";
            this.panelColorize.Size = new System.Drawing.Size(433, 33);
            this.panelColorize.TabIndex = 65;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 64;
            this.label17.Text = "Color";
            // 
            // tbrColorizeIntensity
            // 
            this.tbrColorizeIntensity.AutoSize = false;
            this.tbrColorizeIntensity.Location = new System.Drawing.Point(196, 3);
            this.tbrColorizeIntensity.Maximum = 100;
            this.tbrColorizeIntensity.Name = "tbrColorizeIntensity";
            this.tbrColorizeIntensity.Size = new System.Drawing.Size(209, 24);
            this.tbrColorizeIntensity.SmallChange = 10;
            this.tbrColorizeIntensity.TabIndex = 62;
            this.tbrColorizeIntensity.TickFrequency = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(144, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 63;
            this.label16.Text = "Intensity";
            // 
            // clpColorize
            // 
            this.clpColorize.Color = System.Drawing.Color.Orange;
            this.clpColorize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clpColorize.DropDownHeight = 1;
            this.clpColorize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clpColorize.FormattingEnabled = true;
            this.clpColorize.IntegralHeight = false;
            this.clpColorize.Items.AddRange(new object[] {
            "Color"});
            this.clpColorize.Location = new System.Drawing.Point(42, 6);
            this.clpColorize.Name = "clpColorize";
            this.clpColorize.Size = new System.Drawing.Size(74, 21);
            this.clpColorize.TabIndex = 60;
            // 
            // chkColorize
            // 
            this.chkColorize.AutoSize = true;
            this.chkColorize.Location = new System.Drawing.Point(12, 0);
            this.chkColorize.Name = "chkColorize";
            this.chkColorize.Size = new System.Drawing.Size(63, 17);
            this.chkColorize.TabIndex = 61;
            this.chkColorize.Text = "Colorize";
            this.chkColorize.UseVisualStyleBackColor = true;
            // 
            // chkGreyScale
            // 
            this.chkGreyScale.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.chkGreyScale.Location = new System.Drawing.Point(35, 291);
            this.chkGreyScale.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.chkGreyScale.Name = "chkGreyScale";
            this.chkGreyScale.Size = new System.Drawing.Size(150, 21);
            this.chkGreyScale.TabIndex = 57;
            this.chkGreyScale.Text = "Greyscale";
            this.chkGreyScale.ThemesEnabled = false;
            // 
            // tabPageAdv5
            // 
            this.tabPageAdv5.Controls.Add(this.configPanelControl1);
            this.tabPageAdv5.Controls.Add(this.label9);
            this.tabPageAdv5.Controls.Add(this.pictureBox2);
            this.tabPageAdv5.Image = null;
            this.tabPageAdv5.ImageIndex = 4;
            this.tabPageAdv5.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv5.Location = new System.Drawing.Point(120, 1);
            this.tabPageAdv5.Name = "tabPageAdv5";
            this.tabPageAdv5.ShowCloseButton = true;
            this.tabPageAdv5.Size = new System.Drawing.Size(515, 441);
            this.tabPageAdv5.TabIndex = 5;
            this.tabPageAdv5.Text = "Pyramids";
            this.tabPageAdv5.ThemesEnabled = false;
            // 
            // configPanelControl1
            // 
            this.configPanelControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configPanelControl1.Controls.Add(this.checkedListBox1);
            this.configPanelControl1.Controls.Add(this.btnClearOverviews);
            this.configPanelControl1.Controls.Add(this.label8);
            this.configPanelControl1.Controls.Add(this.btnBuildOverviews);
            this.configPanelControl1.Controls.Add(this.cboOverviewType);
            this.configPanelControl1.Controls.Add(this.label6);
            this.configPanelControl1.Controls.Add(this.label10);
            this.configPanelControl1.Controls.Add(this.cboOverviewSampling);
            this.configPanelControl1.HeaderText = "Pyramid generation";
            this.configPanelControl1.Location = new System.Drawing.Point(12, 121);
            this.configPanelControl1.Name = "configPanelControl1";
            this.configPanelControl1.Size = new System.Drawing.Size(500, 179);
            this.configPanelControl1.TabIndex = 49;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "1 : 2",
            "1 : 4",
            "1 : 8",
            "1 : 16",
            "1 : 32"});
            this.checkedListBox1.Location = new System.Drawing.Point(357, 53);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 49;
            // 
            // btnClearOverviews
            // 
            this.btnClearOverviews.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnClearOverviews.IsBackStageButton = false;
            this.btnClearOverviews.Location = new System.Drawing.Point(92, 140);
            this.btnClearOverviews.Name = "btnClearOverviews";
            this.btnClearOverviews.Size = new System.Drawing.Size(75, 23);
            this.btnClearOverviews.TabIndex = 48;
            this.btnClearOverviews.Text = "Clear";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Overview format:";
            // 
            // btnBuildOverviews
            // 
            this.btnBuildOverviews.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnBuildOverviews.IsBackStageButton = false;
            this.btnBuildOverviews.Location = new System.Drawing.Point(11, 140);
            this.btnBuildOverviews.Name = "btnBuildOverviews";
            this.btnBuildOverviews.Size = new System.Drawing.Size(75, 23);
            this.btnBuildOverviews.TabIndex = 47;
            this.btnBuildOverviews.Text = "Generate";
            // 
            // cboOverviewType
            // 
            this.cboOverviewType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOverviewType.BeforeTouchSize = new System.Drawing.Size(319, 21);
            this.cboOverviewType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOverviewType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboOverviewType.Location = new System.Drawing.Point(11, 53);
            this.cboOverviewType.Name = "cboOverviewType";
            this.cboOverviewType.Size = new System.Drawing.Size(319, 21);
            this.cboOverviewType.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Resampling method:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(354, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Available scales:";
            // 
            // cboOverviewSampling
            // 
            this.cboOverviewSampling.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOverviewSampling.BeforeTouchSize = new System.Drawing.Size(320, 21);
            this.cboOverviewSampling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOverviewSampling.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboOverviewSampling.Location = new System.Drawing.Point(10, 102);
            this.cboOverviewSampling.Name = "cboOverviewSampling";
            this.cboOverviewSampling.Size = new System.Drawing.Size(320, 21);
            this.cboOverviewSampling.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(64, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(431, 78);
            this.label9.TabIndex = 44;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // tabPageAdv6
            // 
            this.tabPageAdv6.Controls.Add(this.txtGdalInfo);
            this.tabPageAdv6.Image = null;
            this.tabPageAdv6.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv6.Location = new System.Drawing.Point(120, 1);
            this.tabPageAdv6.Name = "tabPageAdv6";
            this.tabPageAdv6.ShowCloseButton = true;
            this.tabPageAdv6.Size = new System.Drawing.Size(515, 441);
            this.tabPageAdv6.TabIndex = 6;
            this.tabPageAdv6.Text = "Temp info";
            this.tabPageAdv6.ThemesEnabled = false;
            // 
            // txtGdalInfo
            // 
            this.txtGdalInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGdalInfo.Location = new System.Drawing.Point(11, 14);
            this.txtGdalInfo.Name = "txtGdalInfo";
            this.txtGdalInfo.Size = new System.Drawing.Size(505, 412);
            this.txtGdalInfo.TabIndex = 5;
            this.txtGdalInfo.Text = "";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "img_options32.png");
            this.imageList1.Images.SetKeyName(1, "img_info32.png");
            this.imageList1.Images.SetKeyName(2, "img_colors32.png");
            this.imageList1.Images.SetKeyName(3, "img_contrast32.png");
            this.imageList1.Images.SetKeyName(4, "img_pyramid32.png");
            // 
            // cboDynamicScaleMode
            // 
            this.cboDynamicScaleMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDynamicScaleMode.BeforeTouchSize = new System.Drawing.Size(199, 21);
            this.cboDynamicScaleMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDynamicScaleMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboDynamicScaleMode.Location = new System.Drawing.Point(11, 28);
            this.cboDynamicScaleMode.Name = "cboDynamicScaleMode";
            this.cboDynamicScaleMode.Size = new System.Drawing.Size(199, 21);
            this.cboDynamicScaleMode.TabIndex = 7;
            // 
            // cboMaxScale
            // 
            this.cboMaxScale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMaxScale.BeforeTouchSize = new System.Drawing.Size(142, 21);
            this.cboMaxScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaxScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboMaxScale.Location = new System.Drawing.Point(11, 126);
            this.cboMaxScale.Name = "cboMaxScale";
            this.cboMaxScale.Size = new System.Drawing.Size(142, 21);
            this.cboMaxScale.TabIndex = 4;
            // 
            // cboMinScale
            // 
            this.cboMinScale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMinScale.BeforeTouchSize = new System.Drawing.Size(142, 21);
            this.cboMinScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMinScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboMinScale.Location = new System.Drawing.Point(11, 77);
            this.cboMinScale.Name = "cboMinScale";
            this.cboMinScale.Size = new System.Drawing.Size(142, 21);
            this.cboMinScale.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(85, 26);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IsBackStageButton = false;
            this.btnCancel.Location = new System.Drawing.Point(544, 461);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 26);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Cancel";
            // 
            // btnOk
            // 
            this.btnOk.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2000;
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(85, 26);
            this.btnOk.IsBackStageButton = false;
            this.btnOk.Location = new System.Drawing.Point(453, 461);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 26);
            this.btnOk.TabIndex = 35;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyle = false;
            // 
            // btnApply
            // 
            this.btnApply.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2000;
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnApply.BeforeTouchSize = new System.Drawing.Size(85, 26);
            this.btnApply.IsBackStageButton = false;
            this.btnApply.Location = new System.Drawing.Point(361, 461);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(85, 26);
            this.btnApply.TabIndex = 37;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyle = false;
            // 
            // RasterStyleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 491);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tabControlAdv1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "RasterStyleView";
            this.Text = "Raster Layer Properties";
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv1.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLayerVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBriefInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatasourceName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLayerName)).EndInit();
            this.tabPageAdv2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rasterInfoTreeView1)).EndInit();
            this.tabPageAdv4.ResumeLayout(false);
            this.tabPageAdv3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrConstrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBrightness)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboUpsampling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDownsampling)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelColorize.ResumeLayout(false);
            this.panelColorize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrColorizeIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGreyScale)).EndInit();
            this.tabPageAdv5.ResumeLayout(false);
            this.tabPageAdv5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configPanelControl1)).EndInit();
            this.configPanelControl1.ResumeLayout(false);
            this.configPanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboOverviewType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOverviewSampling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPageAdv6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboDynamicScaleMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaxScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMinScale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv4;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv3;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv5;
        private System.Windows.Forms.ImageList imageList1;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBriefInfo;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.ButtonAdv btnProjectionDetails;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtProjection;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDatasourceName;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtLayerName;
        private System.Windows.Forms.Label label2;
        private ComboBoxAdv cboMaxScale;
        private ComboBoxAdv cboMinScale;
        private ComboBoxAdv cboDynamicScaleMode;
        private CheckBoxAdv chkLayerVisible;
        private System.Windows.Forms.Label label12;
        private ComboBoxAdv cboDownsampling;
        private System.Windows.Forms.Label label11;
        private ComboBoxAdv cboUpsampling;
        private UI.Controls.ConfigPanelControl configPanelControl1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private ButtonAdv btnClearOverviews;
        private System.Windows.Forms.Label label8;
        private ButtonAdv btnBuildOverviews;
        private ComboBoxAdv cboOverviewType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private ComboBoxAdv cboOverviewSampling;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private TabPageAdv tabPageAdv6;
        private System.Windows.Forms.RichTextBox txtGdalInfo;
        private Controls.RasterInfoTreeView rasterInfoTreeView1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkLayerPreview;
        private ButtonAdv btnApply;
        private Controls.RasterColorSchemeView rasterColorSchemeView;
        private Controls.DynamicVisibilityControl dynamicVisibilityControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkColorize;
        private Controls.ColorPicker.Office2007ColorPicker clpColorize;
        private CheckBoxAdv chkGreyScale;
        private System.Windows.Forms.TrackBar tbrHue;
        private System.Windows.Forms.TrackBar tbrSaturation;
        private System.Windows.Forms.TrackBar tbrGamma;
        private System.Windows.Forms.TrackBar tbrConstrast;
        private System.Windows.Forms.TrackBar tbrBrightness;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar tbrColorizeIntensity;
        private System.Windows.Forms.Label label17;
        private ButtonAdv btnClearColorAdjustments;
        private System.Windows.Forms.Panel panelColorize;
    }
}
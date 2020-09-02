﻿using System.Linq;

namespace grapher
{
    partial class RawAcceleration
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series31 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series32 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series33 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series34 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series35 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series36 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.AccelerationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.accelTypeDropX = new System.Windows.Forms.ComboBox();
            this.sensitivityBoxX = new System.Windows.Forms.TextBox();
            this.sensitivityLabel = new System.Windows.Forms.Label();
            this.rotationBox = new System.Windows.Forms.TextBox();
            this.rotationLabel = new System.Windows.Forms.Label();
            this.accelerationBoxX = new System.Windows.Forms.TextBox();
            this.constantOneLabelX = new System.Windows.Forms.Label();
            this.capBoxX = new System.Windows.Forms.TextBox();
            this.capLabelX = new System.Windows.Forms.Label();
            this.weightBoxX = new System.Windows.Forms.TextBox();
            this.weightLabelX = new System.Windows.Forms.Label();
            this.weightBoxY = new System.Windows.Forms.TextBox();
            this.limitBoxX = new System.Windows.Forms.TextBox();
            this.constantTwoLabelX = new System.Windows.Forms.Label();
            this.midpointBoxX = new System.Windows.Forms.TextBox();
            this.constantThreeLabelX = new System.Windows.Forms.Label();
            this.offsetBoxX = new System.Windows.Forms.TextBox();
            this.offsetLabelX = new System.Windows.Forms.Label();
            this.writeButton = new System.Windows.Forms.Button();
            this.sensitivityBoxY = new System.Windows.Forms.TextBox();
            this.capBoxY = new System.Windows.Forms.TextBox();
            this.sensXYLock = new System.Windows.Forms.CheckBox();
            this.LockXYLabel = new System.Windows.Forms.Label();
            this.VelocityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graphsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showVelocityGainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleByDPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DPITextBox = new System.Windows.Forms.ToolStripTextBox();
            this.pollRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PollRateTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.ScaleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensitivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.velocityGainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wholeVectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byVectorComponentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoWriteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccelerationChartY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.VelocityChartY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GainChartY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MouseLabel = new System.Windows.Forms.Label();
            this.ActiveValueTitle = new System.Windows.Forms.Label();
            this.SensitivityActiveXLabel = new System.Windows.Forms.Label();
            this.SensitivityActiveYLabel = new System.Windows.Forms.Label();
            this.RotationActiveLabel = new System.Windows.Forms.Label();
            this.AccelTypeActiveLabelX = new System.Windows.Forms.Label();
            this.AccelerationActiveLabelX = new System.Windows.Forms.Label();
            this.CapActiveXLabel = new System.Windows.Forms.Label();
            this.WeightActiveXLabel = new System.Windows.Forms.Label();
            this.WeightActiveYLabel = new System.Windows.Forms.Label();
            this.CapActiveYLabel = new System.Windows.Forms.Label();
            this.OffsetActiveXLabel = new System.Windows.Forms.Label();
            this.LimitExpActiveXLabel = new System.Windows.Forms.Label();
            this.MidpointActiveXLabel = new System.Windows.Forms.Label();
            this.accelerationBoxY = new System.Windows.Forms.TextBox();
            this.offsetBoxY = new System.Windows.Forms.TextBox();
            this.limitBoxY = new System.Windows.Forms.TextBox();
            this.midpointBoxY = new System.Windows.Forms.TextBox();
            this.accelTypeDropY = new System.Windows.Forms.ComboBox();
            this.AccelerationActiveLabelY = new System.Windows.Forms.Label();
            this.OffsetActiveYLabel = new System.Windows.Forms.Label();
            this.LimitExpActiveYLabel = new System.Windows.Forms.Label();
            this.MidpointActiveYLabel = new System.Windows.Forms.Label();
            this.ByComponentXYLock = new System.Windows.Forms.CheckBox();
            this.constantOneLabelY = new System.Windows.Forms.Label();
            this.capLabelY = new System.Windows.Forms.Label();
            this.weightLabelY = new System.Windows.Forms.Label();
            this.offsetLabelY = new System.Windows.Forms.Label();
            this.constantTwoLabelY = new System.Windows.Forms.Label();
            this.constantThreeLabelY = new System.Windows.Forms.Label();
            this.OptionSetXTitle = new System.Windows.Forms.Label();
            this.OptionSetYTitle = new System.Windows.Forms.Label();
            this.AccelTypeActiveLabelY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerationChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelocityChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GainChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerationChartY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelocityChartY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GainChartY)).BeginInit();
            this.SuspendLayout();
            // 
            // AccelerationChart
            // 
            chartArea13.AxisX.Title = "Speed (counts/ms)";
            chartArea13.AxisY.Title = "Sensitivity (magnitude ratio)";
            chartArea13.Name = "ChartArea1";
            this.AccelerationChart.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.AccelerationChart.Legends.Add(legend13);
            this.AccelerationChart.Location = new System.Drawing.Point(432, 0);
            this.AccelerationChart.Name = "AccelerationChart";
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series25.Legend = "Legend1";
            series25.Name = "Accelerated Sensitivity";
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series26.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series26.Legend = "Legend1";
            series26.Name = "LastAccelVal";
            this.AccelerationChart.Series.Add(series25);
            this.AccelerationChart.Series.Add(series26);
            this.AccelerationChart.Size = new System.Drawing.Size(723, 328);
            this.AccelerationChart.TabIndex = 0;
            this.AccelerationChart.Text = "Sensitivity";
            // 
            // accelTypeDropX
            // 
            this.accelTypeDropX.FormattingEnabled = true;
            this.accelTypeDropX.Location = new System.Drawing.Point(105, 110);
            this.accelTypeDropX.Name = "accelTypeDropX";
            this.accelTypeDropX.Size = new System.Drawing.Size(76, 21);
            this.accelTypeDropX.TabIndex = 2;
            this.accelTypeDropX.Text = "Accel Type";
            // 
            // sensitivityBoxX
            // 
            this.sensitivityBoxX.Location = new System.Drawing.Point(105, 46);
            this.sensitivityBoxX.Name = "sensitivityBoxX";
            this.sensitivityBoxX.Size = new System.Drawing.Size(34, 20);
            this.sensitivityBoxX.TabIndex = 3;
            // 
            // sensitivityLabel
            // 
            this.sensitivityLabel.AutoSize = true;
            this.sensitivityLabel.Location = new System.Drawing.Point(24, 49);
            this.sensitivityLabel.Name = "sensitivityLabel";
            this.sensitivityLabel.Size = new System.Drawing.Size(54, 13);
            this.sensitivityLabel.TabIndex = 4;
            this.sensitivityLabel.Text = "Sensitivity";
            // 
            // rotationBox
            // 
            this.rotationBox.Location = new System.Drawing.Point(105, 72);
            this.rotationBox.Name = "rotationBox";
            this.rotationBox.Size = new System.Drawing.Size(76, 20);
            this.rotationBox.TabIndex = 5;
            // 
            // rotationLabel
            // 
            this.rotationLabel.AutoSize = true;
            this.rotationLabel.Location = new System.Drawing.Point(34, 75);
            this.rotationLabel.Name = "rotationLabel";
            this.rotationLabel.Size = new System.Drawing.Size(47, 13);
            this.rotationLabel.TabIndex = 6;
            this.rotationLabel.Text = "Rotation";
            // 
            // accelerationBoxX
            // 
            this.accelerationBoxX.Location = new System.Drawing.Point(105, 137);
            this.accelerationBoxX.Name = "accelerationBoxX";
            this.accelerationBoxX.Size = new System.Drawing.Size(76, 20);
            this.accelerationBoxX.TabIndex = 7;
            // 
            // constantOneLabelX
            // 
            this.constantOneLabelX.AutoSize = true;
            this.constantOneLabelX.Location = new System.Drawing.Point(24, 140);
            this.constantOneLabelX.Name = "constantOneLabelX";
            this.constantOneLabelX.Size = new System.Drawing.Size(66, 13);
            this.constantOneLabelX.TabIndex = 9;
            this.constantOneLabelX.Text = "Acceleration";
            this.constantOneLabelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // capBoxX
            // 
            this.capBoxX.Location = new System.Drawing.Point(105, 163);
            this.capBoxX.Name = "capBoxX";
            this.capBoxX.Size = new System.Drawing.Size(76, 20);
            this.capBoxX.TabIndex = 10;
            // 
            // capLabelX
            // 
            this.capLabelX.AutoSize = true;
            this.capLabelX.Location = new System.Drawing.Point(43, 166);
            this.capLabelX.Name = "capLabelX";
            this.capLabelX.Size = new System.Drawing.Size(26, 13);
            this.capLabelX.TabIndex = 11;
            this.capLabelX.Text = "Cap";
            this.capLabelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weightBoxX
            // 
            this.weightBoxX.Location = new System.Drawing.Point(105, 189);
            this.weightBoxX.Name = "weightBoxX";
            this.weightBoxX.Size = new System.Drawing.Size(76, 20);
            this.weightBoxX.TabIndex = 12;
            // 
            // weightLabelX
            // 
            this.weightLabelX.AutoSize = true;
            this.weightLabelX.Location = new System.Drawing.Point(40, 192);
            this.weightLabelX.Name = "weightLabelX";
            this.weightLabelX.Size = new System.Drawing.Size(41, 13);
            this.weightLabelX.TabIndex = 13;
            this.weightLabelX.Text = "Weight";
            this.weightLabelX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // weightBoxY
            // 
            this.weightBoxY.Location = new System.Drawing.Point(267, 189);
            this.weightBoxY.Name = "weightBoxY";
            this.weightBoxY.Size = new System.Drawing.Size(76, 20);
            this.weightBoxY.TabIndex = 14;
            // 
            // limitBoxX
            // 
            this.limitBoxX.Location = new System.Drawing.Point(105, 241);
            this.limitBoxX.Name = "limitBoxX";
            this.limitBoxX.Size = new System.Drawing.Size(76, 20);
            this.limitBoxX.TabIndex = 15;
            // 
            // constantTwoLabelX
            // 
            this.constantTwoLabelX.AutoSize = true;
            this.constantTwoLabelX.Location = new System.Drawing.Point(24, 244);
            this.constantTwoLabelX.Name = "constantTwoLabelX";
            this.constantTwoLabelX.Size = new System.Drawing.Size(78, 13);
            this.constantTwoLabelX.TabIndex = 16;
            this.constantTwoLabelX.Text = "Limit/Exponent";
            this.constantTwoLabelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // midpointBoxX
            // 
            this.midpointBoxX.Location = new System.Drawing.Point(105, 267);
            this.midpointBoxX.Name = "midpointBoxX";
            this.midpointBoxX.Size = new System.Drawing.Size(76, 20);
            this.midpointBoxX.TabIndex = 17;
            // 
            // constantThreeLabelX
            // 
            this.constantThreeLabelX.AutoSize = true;
            this.constantThreeLabelX.Location = new System.Drawing.Point(34, 270);
            this.constantThreeLabelX.Name = "constantThreeLabelX";
            this.constantThreeLabelX.Size = new System.Drawing.Size(47, 13);
            this.constantThreeLabelX.TabIndex = 18;
            this.constantThreeLabelX.Text = "Midpoint";
            this.constantThreeLabelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // offsetBoxX
            // 
            this.offsetBoxX.Location = new System.Drawing.Point(105, 215);
            this.offsetBoxX.Name = "offsetBoxX";
            this.offsetBoxX.Size = new System.Drawing.Size(76, 20);
            this.offsetBoxX.TabIndex = 19;
            // 
            // offsetLabelX
            // 
            this.offsetLabelX.AutoSize = true;
            this.offsetLabelX.Location = new System.Drawing.Point(43, 218);
            this.offsetLabelX.Name = "offsetLabelX";
            this.offsetLabelX.Size = new System.Drawing.Size(35, 13);
            this.offsetLabelX.TabIndex = 20;
            this.offsetLabelX.Text = "Offset";
            this.offsetLabelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(153, 293);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(102, 23);
            this.writeButton.TabIndex = 21;
            this.writeButton.Text = "Write To Driver";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // sensitivityBoxY
            // 
            this.sensitivityBoxY.Location = new System.Drawing.Point(147, 46);
            this.sensitivityBoxY.Name = "sensitivityBoxY";
            this.sensitivityBoxY.Size = new System.Drawing.Size(34, 20);
            this.sensitivityBoxY.TabIndex = 22;
            // 
            // capBoxY
            // 
            this.capBoxY.Location = new System.Drawing.Point(267, 163);
            this.capBoxY.Name = "capBoxY";
            this.capBoxY.Size = new System.Drawing.Size(76, 20);
            this.capBoxY.TabIndex = 23;
            // 
            // sensXYLock
            // 
            this.sensXYLock.AutoSize = true;
            this.sensXYLock.Checked = true;
            this.sensXYLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sensXYLock.Location = new System.Drawing.Point(219, 49);
            this.sensXYLock.Name = "sensXYLock";
            this.sensXYLock.Size = new System.Drawing.Size(15, 14);
            this.sensXYLock.TabIndex = 24;
            this.sensXYLock.UseVisualStyleBackColor = true;
            // 
            // LockXYLabel
            // 
            this.LockXYLabel.AutoSize = true;
            this.LockXYLabel.Location = new System.Drawing.Point(195, 30);
            this.LockXYLabel.Name = "LockXYLabel";
            this.LockXYLabel.Size = new System.Drawing.Size(60, 13);
            this.LockXYLabel.TabIndex = 27;
            this.LockXYLabel.Text = "Lock X && Y";
            // 
            // VelocityChart
            // 
            chartArea14.AxisX.Title = "Speed (count/ms)";
            chartArea14.AxisY.Title = "Output Speed (counts/ms)";
            chartArea14.Name = "ChartArea1";
            this.VelocityChart.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.VelocityChart.Legends.Add(legend14);
            this.VelocityChart.Location = new System.Drawing.Point(432, 334);
            this.VelocityChart.Name = "VelocityChart";
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series27.Legend = "Legend1";
            series27.Name = "Mouse Velocity";
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series28.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series28.Legend = "Legend1";
            series28.Name = "LastVelocityVal";
            this.VelocityChart.Series.Add(series27);
            this.VelocityChart.Series.Add(series28);
            this.VelocityChart.Size = new System.Drawing.Size(723, 307);
            this.VelocityChart.TabIndex = 28;
            this.VelocityChart.Text = "chart1";
            // 
            // GainChart
            // 
            chartArea15.AxisX.Title = "Speed (counts/ms)";
            chartArea15.AxisY.Title = "Slope of Velocity Chart";
            chartArea15.Name = "ChartArea1";
            this.GainChart.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.GainChart.Legends.Add(legend15);
            this.GainChart.Location = new System.Drawing.Point(432, 647);
            this.GainChart.Name = "GainChart";
            series29.ChartArea = "ChartArea1";
            series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series29.Legend = "Legend1";
            series29.Name = "Velocity Gain";
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series30.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series30.Legend = "Legend1";
            series30.Name = "LastGainVal";
            this.GainChart.Series.Add(series29);
            this.GainChart.Series.Add(series30);
            this.GainChart.Size = new System.Drawing.Size(723, 309);
            this.GainChart.TabIndex = 29;
            this.GainChart.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphsToolStripMenuItem,
            this.advancedToolStripMenuItem,
            this.startupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1884, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // graphsToolStripMenuItem
            // 
            this.graphsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.graphsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showVelocityGainToolStripMenuItem,
            this.scaleByDPIToolStripMenuItem});
            this.graphsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.graphsToolStripMenuItem.Name = "graphsToolStripMenuItem";
            this.graphsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.graphsToolStripMenuItem.Text = "Charts";
            // 
            // showVelocityGainToolStripMenuItem
            // 
            this.showVelocityGainToolStripMenuItem.Name = "showVelocityGainToolStripMenuItem";
            this.showVelocityGainToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.showVelocityGainToolStripMenuItem.Text = "Show Velocity && Gain";
            // 
            // scaleByDPIToolStripMenuItem
            // 
            this.scaleByDPIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dPIToolStripMenuItem,
            this.pollRateToolStripMenuItem,
            this.ScaleMenuItem});
            this.scaleByDPIToolStripMenuItem.Name = "scaleByDPIToolStripMenuItem";
            this.scaleByDPIToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.scaleByDPIToolStripMenuItem.Text = "Scale by Mouse Settngs";
            // 
            // dPIToolStripMenuItem
            // 
            this.dPIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DPITextBox});
            this.dPIToolStripMenuItem.Name = "dPIToolStripMenuItem";
            this.dPIToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.dPIToolStripMenuItem.Text = "DPI";
            // 
            // DPITextBox
            // 
            this.DPITextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DPITextBox.Name = "DPITextBox";
            this.DPITextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // pollRateToolStripMenuItem
            // 
            this.pollRateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PollRateTextBox});
            this.pollRateToolStripMenuItem.Name = "pollRateToolStripMenuItem";
            this.pollRateToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.pollRateToolStripMenuItem.Text = "Poll Rate";
            // 
            // PollRateTextBox
            // 
            this.PollRateTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PollRateTextBox.Name = "PollRateTextBox";
            this.PollRateTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // ScaleMenuItem
            // 
            this.ScaleMenuItem.Name = "ScaleMenuItem";
            this.ScaleMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ScaleMenuItem.Text = "Re-scale by above";
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capStyleToolStripMenuItem,
            this.toolStripMenuItem1});
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.advancedToolStripMenuItem.Text = "Advanced";
            // 
            // capStyleToolStripMenuItem
            // 
            this.capStyleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sensitivityToolStripMenuItem,
            this.velocityGainToolStripMenuItem});
            this.capStyleToolStripMenuItem.Name = "capStyleToolStripMenuItem";
            this.capStyleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.capStyleToolStripMenuItem.Text = "Cap Style";
            // 
            // sensitivityToolStripMenuItem
            // 
            this.sensitivityToolStripMenuItem.Checked = true;
            this.sensitivityToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sensitivityToolStripMenuItem.Name = "sensitivityToolStripMenuItem";
            this.sensitivityToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.sensitivityToolStripMenuItem.Text = "Sensitivity";
            // 
            // velocityGainToolStripMenuItem
            // 
            this.velocityGainToolStripMenuItem.Name = "velocityGainToolStripMenuItem";
            this.velocityGainToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.velocityGainToolStripMenuItem.Text = "Velocity Gain";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wholeVectorToolStripMenuItem,
            this.byVectorComponentToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem1.Text = "Application Style";
            // 
            // wholeVectorToolStripMenuItem
            // 
            this.wholeVectorToolStripMenuItem.Checked = true;
            this.wholeVectorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wholeVectorToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.wholeVectorToolStripMenuItem.Name = "wholeVectorToolStripMenuItem";
            this.wholeVectorToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.wholeVectorToolStripMenuItem.Text = "Whole";
            // 
            // byVectorComponentToolStripMenuItem
            // 
            this.byVectorComponentToolStripMenuItem.Name = "byVectorComponentToolStripMenuItem";
            this.byVectorComponentToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.byVectorComponentToolStripMenuItem.Text = "By Component";
            // 
            // startupToolStripMenuItem
            // 
            this.startupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutoWriteMenuItem});
            this.startupToolStripMenuItem.Name = "startupToolStripMenuItem";
            this.startupToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.startupToolStripMenuItem.Text = "Startup";
            // 
            // AutoWriteMenuItem
            // 
            this.AutoWriteMenuItem.Checked = true;
            this.AutoWriteMenuItem.CheckOnClick = true;
            this.AutoWriteMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoWriteMenuItem.Name = "AutoWriteMenuItem";
            this.AutoWriteMenuItem.Size = new System.Drawing.Size(229, 22);
            this.AutoWriteMenuItem.Text = "Apply Settings File on Startup";
            // 
            // AccelerationChartY
            // 
            chartArea16.AxisX.Title = "Speed (counts/ms)";
            chartArea16.AxisY.Title = "Sensitivity (magnitude ratio)";
            chartArea16.Name = "ChartArea1";
            this.AccelerationChartY.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            this.AccelerationChartY.Legends.Add(legend16);
            this.AccelerationChartY.Location = new System.Drawing.Point(1161, 0);
            this.AccelerationChartY.Name = "AccelerationChartY";
            series31.ChartArea = "ChartArea1";
            series31.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series31.Legend = "Legend1";
            series31.Name = "Accelerated Sensitivity";
            series32.ChartArea = "ChartArea1";
            series32.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series32.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series32.Legend = "Legend1";
            series32.Name = "LastAccelVal";
            this.AccelerationChartY.Series.Add(series31);
            this.AccelerationChartY.Series.Add(series32);
            this.AccelerationChartY.Size = new System.Drawing.Size(723, 328);
            this.AccelerationChartY.TabIndex = 31;
            this.AccelerationChartY.Text = "chart1";
            // 
            // VelocityChartY
            // 
            chartArea17.AxisX.Title = "Speed (count/ms)";
            chartArea17.AxisY.Title = "Output Speed (counts/ms)";
            chartArea17.Name = "ChartArea1";
            this.VelocityChartY.ChartAreas.Add(chartArea17);
            legend17.Name = "Legend1";
            this.VelocityChartY.Legends.Add(legend17);
            this.VelocityChartY.Location = new System.Drawing.Point(1161, 334);
            this.VelocityChartY.Name = "VelocityChartY";
            series33.ChartArea = "ChartArea1";
            series33.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series33.Legend = "Legend1";
            series33.Name = "Mouse Velocity";
            series34.ChartArea = "ChartArea1";
            series34.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series34.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series34.Legend = "Legend1";
            series34.Name = "LastVelocityVal";
            this.VelocityChartY.Series.Add(series33);
            this.VelocityChartY.Series.Add(series34);
            this.VelocityChartY.Size = new System.Drawing.Size(723, 307);
            this.VelocityChartY.TabIndex = 32;
            this.VelocityChartY.Text = "chart1";
            // 
            // GainChartY
            // 
            chartArea18.AxisX.Title = "Speed (counts/ms)";
            chartArea18.AxisY.Title = "Slope of Velocity Chart";
            chartArea18.Name = "ChartArea1";
            this.GainChartY.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.GainChartY.Legends.Add(legend18);
            this.GainChartY.Location = new System.Drawing.Point(1161, 647);
            this.GainChartY.Name = "GainChartY";
            series35.ChartArea = "ChartArea1";
            series35.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series35.Legend = "Legend1";
            series35.Name = "Velocity Gain";
            series36.ChartArea = "ChartArea1";
            series36.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series36.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series36.Legend = "Legend1";
            series36.Name = "LastGainVal";
            this.GainChartY.Series.Add(series35);
            this.GainChartY.Series.Add(series36);
            this.GainChartY.Size = new System.Drawing.Size(723, 309);
            this.GainChartY.TabIndex = 33;
            this.GainChartY.Text = "chart1";
            // 
            // MouseLabel
            // 
            this.MouseLabel.AutoSize = true;
            this.MouseLabel.Location = new System.Drawing.Point(1, 24);
            this.MouseLabel.Name = "MouseLabel";
            this.MouseLabel.Size = new System.Drawing.Size(80, 13);
            this.MouseLabel.TabIndex = 34;
            this.MouseLabel.Text = "Last (x, y): (x, y)";
            // 
            // ActiveValueTitle
            // 
            this.ActiveValueTitle.AutoSize = true;
            this.ActiveValueTitle.Location = new System.Drawing.Point(359, 30);
            this.ActiveValueTitle.Name = "ActiveValueTitle";
            this.ActiveValueTitle.Size = new System.Drawing.Size(67, 13);
            this.ActiveValueTitle.TabIndex = 35;
            this.ActiveValueTitle.Text = "Active Value";
            // 
            // SensitivityActiveXLabel
            // 
            this.SensitivityActiveXLabel.AutoSize = true;
            this.SensitivityActiveXLabel.Location = new System.Drawing.Point(359, 53);
            this.SensitivityActiveXLabel.Name = "SensitivityActiveXLabel";
            this.SensitivityActiveXLabel.Size = new System.Drawing.Size(14, 13);
            this.SensitivityActiveXLabel.TabIndex = 36;
            this.SensitivityActiveXLabel.Text = "X";
            // 
            // SensitivityActiveYLabel
            // 
            this.SensitivityActiveYLabel.AutoSize = true;
            this.SensitivityActiveYLabel.Location = new System.Drawing.Point(403, 53);
            this.SensitivityActiveYLabel.Name = "SensitivityActiveYLabel";
            this.SensitivityActiveYLabel.Size = new System.Drawing.Size(14, 13);
            this.SensitivityActiveYLabel.TabIndex = 37;
            this.SensitivityActiveYLabel.Text = "Y";
            // 
            // RotationActiveLabel
            // 
            this.RotationActiveLabel.AutoSize = true;
            this.RotationActiveLabel.Location = new System.Drawing.Point(384, 75);
            this.RotationActiveLabel.Name = "RotationActiveLabel";
            this.RotationActiveLabel.Size = new System.Drawing.Size(13, 13);
            this.RotationActiveLabel.TabIndex = 38;
            this.RotationActiveLabel.Text = "0";
            // 
            // AccelTypeActiveLabelX
            // 
            this.AccelTypeActiveLabelX.AutoSize = true;
            this.AccelTypeActiveLabelX.Location = new System.Drawing.Point(359, 113);
            this.AccelTypeActiveLabelX.Name = "AccelTypeActiveLabelX";
            this.AccelTypeActiveLabelX.Size = new System.Drawing.Size(13, 13);
            this.AccelTypeActiveLabelX.TabIndex = 39;
            this.AccelTypeActiveLabelX.Text = "0";
            // 
            // AccelerationActiveLabelX
            // 
            this.AccelerationActiveLabelX.AutoSize = true;
            this.AccelerationActiveLabelX.Location = new System.Drawing.Point(359, 140);
            this.AccelerationActiveLabelX.Name = "AccelerationActiveLabelX";
            this.AccelerationActiveLabelX.Size = new System.Drawing.Size(13, 13);
            this.AccelerationActiveLabelX.TabIndex = 40;
            this.AccelerationActiveLabelX.Text = "0";
            // 
            // CapActiveXLabel
            // 
            this.CapActiveXLabel.AutoSize = true;
            this.CapActiveXLabel.Location = new System.Drawing.Point(359, 166);
            this.CapActiveXLabel.Name = "CapActiveXLabel";
            this.CapActiveXLabel.Size = new System.Drawing.Size(13, 13);
            this.CapActiveXLabel.TabIndex = 41;
            this.CapActiveXLabel.Text = "0";
            // 
            // WeightActiveXLabel
            // 
            this.WeightActiveXLabel.AutoSize = true;
            this.WeightActiveXLabel.Location = new System.Drawing.Point(359, 192);
            this.WeightActiveXLabel.Name = "WeightActiveXLabel";
            this.WeightActiveXLabel.Size = new System.Drawing.Size(13, 13);
            this.WeightActiveXLabel.TabIndex = 42;
            this.WeightActiveXLabel.Text = "0";
            // 
            // WeightActiveYLabel
            // 
            this.WeightActiveYLabel.AutoSize = true;
            this.WeightActiveYLabel.Location = new System.Drawing.Point(403, 192);
            this.WeightActiveYLabel.Name = "WeightActiveYLabel";
            this.WeightActiveYLabel.Size = new System.Drawing.Size(13, 13);
            this.WeightActiveYLabel.TabIndex = 43;
            this.WeightActiveYLabel.Text = "0";
            // 
            // CapActiveYLabel
            // 
            this.CapActiveYLabel.AutoSize = true;
            this.CapActiveYLabel.Location = new System.Drawing.Point(403, 166);
            this.CapActiveYLabel.Name = "CapActiveYLabel";
            this.CapActiveYLabel.Size = new System.Drawing.Size(13, 13);
            this.CapActiveYLabel.TabIndex = 44;
            this.CapActiveYLabel.Text = "0";
            // 
            // OffsetActiveXLabel
            // 
            this.OffsetActiveXLabel.AutoSize = true;
            this.OffsetActiveXLabel.Location = new System.Drawing.Point(359, 218);
            this.OffsetActiveXLabel.Name = "OffsetActiveXLabel";
            this.OffsetActiveXLabel.Size = new System.Drawing.Size(13, 13);
            this.OffsetActiveXLabel.TabIndex = 45;
            this.OffsetActiveXLabel.Text = "0";
            // 
            // LimitExpActiveXLabel
            // 
            this.LimitExpActiveXLabel.AutoSize = true;
            this.LimitExpActiveXLabel.Location = new System.Drawing.Point(359, 244);
            this.LimitExpActiveXLabel.Name = "LimitExpActiveXLabel";
            this.LimitExpActiveXLabel.Size = new System.Drawing.Size(13, 13);
            this.LimitExpActiveXLabel.TabIndex = 46;
            this.LimitExpActiveXLabel.Text = "0";
            // 
            // MidpointActiveXLabel
            // 
            this.MidpointActiveXLabel.AutoSize = true;
            this.MidpointActiveXLabel.Location = new System.Drawing.Point(360, 270);
            this.MidpointActiveXLabel.Name = "MidpointActiveXLabel";
            this.MidpointActiveXLabel.Size = new System.Drawing.Size(13, 13);
            this.MidpointActiveXLabel.TabIndex = 47;
            this.MidpointActiveXLabel.Text = "0";
            // 
            // accelerationBoxY
            // 
            this.accelerationBoxY.Location = new System.Drawing.Point(267, 137);
            this.accelerationBoxY.Name = "accelerationBoxY";
            this.accelerationBoxY.Size = new System.Drawing.Size(76, 20);
            this.accelerationBoxY.TabIndex = 48;
            // 
            // offsetBoxY
            // 
            this.offsetBoxY.Location = new System.Drawing.Point(267, 215);
            this.offsetBoxY.Name = "offsetBoxY";
            this.offsetBoxY.Size = new System.Drawing.Size(76, 20);
            this.offsetBoxY.TabIndex = 49;
            // 
            // limitBoxY
            // 
            this.limitBoxY.Location = new System.Drawing.Point(267, 241);
            this.limitBoxY.Name = "limitBoxY";
            this.limitBoxY.Size = new System.Drawing.Size(76, 20);
            this.limitBoxY.TabIndex = 50;
            // 
            // midpointBoxY
            // 
            this.midpointBoxY.Location = new System.Drawing.Point(267, 267);
            this.midpointBoxY.Name = "midpointBoxY";
            this.midpointBoxY.Size = new System.Drawing.Size(76, 20);
            this.midpointBoxY.TabIndex = 51;
            // 
            // accelTypeDropY
            // 
            this.accelTypeDropY.FormattingEnabled = true;
            this.accelTypeDropY.Location = new System.Drawing.Point(267, 110);
            this.accelTypeDropY.Name = "accelTypeDropY";
            this.accelTypeDropY.Size = new System.Drawing.Size(76, 21);
            this.accelTypeDropY.TabIndex = 52;
            this.accelTypeDropY.Text = "Accel Type";
            // 
            // AccelerationActiveLabelY
            // 
            this.AccelerationActiveLabelY.AutoSize = true;
            this.AccelerationActiveLabelY.Location = new System.Drawing.Point(403, 140);
            this.AccelerationActiveLabelY.Name = "AccelerationActiveLabelY";
            this.AccelerationActiveLabelY.Size = new System.Drawing.Size(13, 13);
            this.AccelerationActiveLabelY.TabIndex = 53;
            this.AccelerationActiveLabelY.Text = "0";
            // 
            // OffsetActiveYLabel
            // 
            this.OffsetActiveYLabel.AutoSize = true;
            this.OffsetActiveYLabel.Location = new System.Drawing.Point(403, 218);
            this.OffsetActiveYLabel.Name = "OffsetActiveYLabel";
            this.OffsetActiveYLabel.Size = new System.Drawing.Size(13, 13);
            this.OffsetActiveYLabel.TabIndex = 54;
            this.OffsetActiveYLabel.Text = "0";
            // 
            // LimitExpActiveYLabel
            // 
            this.LimitExpActiveYLabel.AutoSize = true;
            this.LimitExpActiveYLabel.Location = new System.Drawing.Point(403, 244);
            this.LimitExpActiveYLabel.Name = "LimitExpActiveYLabel";
            this.LimitExpActiveYLabel.Size = new System.Drawing.Size(13, 13);
            this.LimitExpActiveYLabel.TabIndex = 55;
            this.LimitExpActiveYLabel.Text = "0";
            // 
            // MidpointActiveYLabel
            // 
            this.MidpointActiveYLabel.AutoSize = true;
            this.MidpointActiveYLabel.Location = new System.Drawing.Point(403, 270);
            this.MidpointActiveYLabel.Name = "MidpointActiveYLabel";
            this.MidpointActiveYLabel.Size = new System.Drawing.Size(13, 13);
            this.MidpointActiveYLabel.TabIndex = 56;
            this.MidpointActiveYLabel.Text = "0";
            // 
            // ByComponentXYLock
            // 
            this.ByComponentXYLock.AutoSize = true;
            this.ByComponentXYLock.Checked = true;
            this.ByComponentXYLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ByComponentXYLock.Location = new System.Drawing.Point(219, 113);
            this.ByComponentXYLock.Name = "ByComponentXYLock";
            this.ByComponentXYLock.Size = new System.Drawing.Size(15, 14);
            this.ByComponentXYLock.TabIndex = 57;
            this.ByComponentXYLock.UseVisualStyleBackColor = true;
            // 
            // constantOneLabelY
            // 
            this.constantOneLabelY.AutoSize = true;
            this.constantOneLabelY.Location = new System.Drawing.Point(195, 140);
            this.constantOneLabelY.Name = "constantOneLabelY";
            this.constantOneLabelY.Size = new System.Drawing.Size(66, 13);
            this.constantOneLabelY.TabIndex = 58;
            this.constantOneLabelY.Text = "Acceleration";
            // 
            // capLabelY
            // 
            this.capLabelY.AutoSize = true;
            this.capLabelY.Location = new System.Drawing.Point(208, 166);
            this.capLabelY.Name = "capLabelY";
            this.capLabelY.Size = new System.Drawing.Size(26, 13);
            this.capLabelY.TabIndex = 59;
            this.capLabelY.Text = "Cap";
            // 
            // weightLabelY
            // 
            this.weightLabelY.AutoSize = true;
            this.weightLabelY.Location = new System.Drawing.Point(202, 192);
            this.weightLabelY.Name = "weightLabelY";
            this.weightLabelY.Size = new System.Drawing.Size(41, 13);
            this.weightLabelY.TabIndex = 60;
            this.weightLabelY.Text = "Weight";
            // 
            // offsetLabelY
            // 
            this.offsetLabelY.AutoSize = true;
            this.offsetLabelY.Location = new System.Drawing.Point(208, 218);
            this.offsetLabelY.Name = "offsetLabelY";
            this.offsetLabelY.Size = new System.Drawing.Size(35, 13);
            this.offsetLabelY.TabIndex = 61;
            this.offsetLabelY.Text = "Offset";
            // 
            // constantTwoLabelY
            // 
            this.constantTwoLabelY.AutoSize = true;
            this.constantTwoLabelY.Location = new System.Drawing.Point(196, 244);
            this.constantTwoLabelY.Name = "constantTwoLabelY";
            this.constantTwoLabelY.Size = new System.Drawing.Size(51, 13);
            this.constantTwoLabelY.TabIndex = 62;
            this.constantTwoLabelY.Text = "Limit/Exp";
            // 
            // constantThreeLabelY
            // 
            this.constantThreeLabelY.AutoSize = true;
            this.constantThreeLabelY.Location = new System.Drawing.Point(200, 270);
            this.constantThreeLabelY.Name = "constantThreeLabelY";
            this.constantThreeLabelY.Size = new System.Drawing.Size(47, 13);
            this.constantThreeLabelY.TabIndex = 63;
            this.constantThreeLabelY.Text = "Midpoint";
            // 
            // OptionSetXTitle
            // 
            this.OptionSetXTitle.AutoSize = true;
            this.OptionSetXTitle.Location = new System.Drawing.Point(142, 94);
            this.OptionSetXTitle.Name = "OptionSetXTitle";
            this.OptionSetXTitle.Size = new System.Drawing.Size(14, 13);
            this.OptionSetXTitle.TabIndex = 64;
            this.OptionSetXTitle.Text = "X";
            // 
            // OptionSetYTitle
            // 
            this.OptionSetYTitle.AutoSize = true;
            this.OptionSetYTitle.Location = new System.Drawing.Point(300, 94);
            this.OptionSetYTitle.Name = "OptionSetYTitle";
            this.OptionSetYTitle.Size = new System.Drawing.Size(14, 13);
            this.OptionSetYTitle.TabIndex = 65;
            this.OptionSetYTitle.Text = "Y";
            // 
            // AccelTypeActiveLabelY
            // 
            this.AccelTypeActiveLabelY.AutoSize = true;
            this.AccelTypeActiveLabelY.Location = new System.Drawing.Point(403, 113);
            this.AccelTypeActiveLabelY.Name = "AccelTypeActiveLabelY";
            this.AccelTypeActiveLabelY.Size = new System.Drawing.Size(13, 13);
            this.AccelTypeActiveLabelY.TabIndex = 66;
            this.AccelTypeActiveLabelY.Text = "0";
            // 
            // RawAcceleration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 956);
            this.Controls.Add(this.AccelTypeActiveLabelY);
            this.Controls.Add(this.OptionSetYTitle);
            this.Controls.Add(this.OptionSetXTitle);
            this.Controls.Add(this.constantThreeLabelY);
            this.Controls.Add(this.constantTwoLabelY);
            this.Controls.Add(this.offsetLabelY);
            this.Controls.Add(this.weightLabelY);
            this.Controls.Add(this.capLabelY);
            this.Controls.Add(this.constantOneLabelY);
            this.Controls.Add(this.ByComponentXYLock);
            this.Controls.Add(this.MidpointActiveYLabel);
            this.Controls.Add(this.LimitExpActiveYLabel);
            this.Controls.Add(this.OffsetActiveYLabel);
            this.Controls.Add(this.AccelerationActiveLabelY);
            this.Controls.Add(this.accelTypeDropY);
            this.Controls.Add(this.midpointBoxY);
            this.Controls.Add(this.limitBoxY);
            this.Controls.Add(this.offsetBoxY);
            this.Controls.Add(this.accelerationBoxY);
            this.Controls.Add(this.MidpointActiveXLabel);
            this.Controls.Add(this.LimitExpActiveXLabel);
            this.Controls.Add(this.OffsetActiveXLabel);
            this.Controls.Add(this.CapActiveYLabel);
            this.Controls.Add(this.WeightActiveYLabel);
            this.Controls.Add(this.WeightActiveXLabel);
            this.Controls.Add(this.CapActiveXLabel);
            this.Controls.Add(this.AccelerationActiveLabelX);
            this.Controls.Add(this.AccelTypeActiveLabelX);
            this.Controls.Add(this.RotationActiveLabel);
            this.Controls.Add(this.SensitivityActiveYLabel);
            this.Controls.Add(this.SensitivityActiveXLabel);
            this.Controls.Add(this.ActiveValueTitle);
            this.Controls.Add(this.MouseLabel);
            this.Controls.Add(this.GainChartY);
            this.Controls.Add(this.VelocityChartY);
            this.Controls.Add(this.AccelerationChartY);
            this.Controls.Add(this.GainChart);
            this.Controls.Add(this.VelocityChart);
            this.Controls.Add(this.LockXYLabel);
            this.Controls.Add(this.sensXYLock);
            this.Controls.Add(this.capBoxY);
            this.Controls.Add(this.sensitivityBoxY);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.offsetLabelX);
            this.Controls.Add(this.offsetBoxX);
            this.Controls.Add(this.constantThreeLabelX);
            this.Controls.Add(this.midpointBoxX);
            this.Controls.Add(this.constantTwoLabelX);
            this.Controls.Add(this.limitBoxX);
            this.Controls.Add(this.weightBoxY);
            this.Controls.Add(this.weightLabelX);
            this.Controls.Add(this.weightBoxX);
            this.Controls.Add(this.capLabelX);
            this.Controls.Add(this.capBoxX);
            this.Controls.Add(this.constantOneLabelX);
            this.Controls.Add(this.accelerationBoxX);
            this.Controls.Add(this.rotationLabel);
            this.Controls.Add(this.rotationBox);
            this.Controls.Add(this.sensitivityLabel);
            this.Controls.Add(this.sensitivityBoxX);
            this.Controls.Add(this.accelTypeDropX);
            this.Controls.Add(this.AccelerationChart);
            this.Controls.Add(this.menuStrip1);
            this.Name = "RawAcceleration";
            this.Text = "Raw Acceleration Graph";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RawAcceleration_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.AccelerationChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelocityChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GainChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerationChartY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelocityChartY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GainChartY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart AccelerationChart;
        private System.Windows.Forms.ComboBox accelTypeDropX;
        private System.Windows.Forms.TextBox sensitivityBoxX;
        private System.Windows.Forms.Label sensitivityLabel;
        private System.Windows.Forms.TextBox rotationBox;
        private System.Windows.Forms.Label rotationLabel;
        private System.Windows.Forms.TextBox accelerationBoxX;
        private System.Windows.Forms.Label constantOneLabelX;
        private System.Windows.Forms.TextBox capBoxX;
        private System.Windows.Forms.Label capLabelX;
        private System.Windows.Forms.TextBox weightBoxX;
        private System.Windows.Forms.Label weightLabelX;
        private System.Windows.Forms.TextBox weightBoxY;
        private System.Windows.Forms.TextBox limitBoxX;
        private System.Windows.Forms.Label constantTwoLabelX;
        private System.Windows.Forms.TextBox midpointBoxX;
        private System.Windows.Forms.Label constantThreeLabelX;
        private System.Windows.Forms.TextBox offsetBoxX;
        private System.Windows.Forms.Label offsetLabelX;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.TextBox sensitivityBoxY;
        private System.Windows.Forms.TextBox capBoxY;
        private System.Windows.Forms.CheckBox sensXYLock;
        private System.Windows.Forms.Label LockXYLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart VelocityChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart GainChart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem graphsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showVelocityGainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sensitivityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem velocityGainToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart AccelerationChartY;
        private System.Windows.Forms.DataVisualization.Charting.Chart VelocityChartY;
        private System.Windows.Forms.DataVisualization.Charting.Chart GainChartY;
        private System.Windows.Forms.Label MouseLabel;
        private System.Windows.Forms.ToolStripMenuItem scaleByDPIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dPIToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox DPITextBox;
        private System.Windows.Forms.ToolStripMenuItem pollRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox PollRateTextBox;
        private System.Windows.Forms.ToolStripMenuItem ScaleMenuItem;
        private System.Windows.Forms.Label ActiveValueTitle;
        private System.Windows.Forms.Label SensitivityActiveXLabel;
        private System.Windows.Forms.Label SensitivityActiveYLabel;
        private System.Windows.Forms.Label RotationActiveLabel;
        private System.Windows.Forms.Label AccelTypeActiveLabelX;
        private System.Windows.Forms.Label AccelerationActiveLabelX;
        private System.Windows.Forms.Label CapActiveXLabel;
        private System.Windows.Forms.Label WeightActiveXLabel;
        private System.Windows.Forms.Label WeightActiveYLabel;
        private System.Windows.Forms.Label CapActiveYLabel;
        private System.Windows.Forms.Label OffsetActiveXLabel;
        private System.Windows.Forms.Label LimitExpActiveXLabel;
        private System.Windows.Forms.Label MidpointActiveXLabel;
        private System.Windows.Forms.ToolStripMenuItem startupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AutoWriteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wholeVectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byVectorComponentToolStripMenuItem;
        private System.Windows.Forms.TextBox accelerationBoxY;
        private System.Windows.Forms.TextBox offsetBoxY;
        private System.Windows.Forms.TextBox limitBoxY;
        private System.Windows.Forms.TextBox midpointBoxY;
        private System.Windows.Forms.ComboBox accelTypeDropY;
        private System.Windows.Forms.Label AccelerationActiveLabelY;
        private System.Windows.Forms.Label OffsetActiveYLabel;
        private System.Windows.Forms.Label LimitExpActiveYLabel;
        private System.Windows.Forms.Label MidpointActiveYLabel;
        private System.Windows.Forms.CheckBox ByComponentXYLock;
        private System.Windows.Forms.Label constantOneLabelY;
        private System.Windows.Forms.Label capLabelY;
        private System.Windows.Forms.Label weightLabelY;
        private System.Windows.Forms.Label offsetLabelY;
        private System.Windows.Forms.Label constantTwoLabelY;
        private System.Windows.Forms.Label constantThreeLabelY;
        private System.Windows.Forms.Label OptionSetXTitle;
        private System.Windows.Forms.Label OptionSetYTitle;
        private System.Windows.Forms.Label AccelTypeActiveLabelY;
    }
}


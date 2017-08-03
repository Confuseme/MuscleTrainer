namespace MuscleTrainer
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.GroupBoxDream = new System.Windows.Forms.GroupBox();
            this.ButtonCopyZ = new System.Windows.Forms.Button();
            this.ButtonCopyY = new System.Windows.Forms.Button();
            this.ButtonCopyX = new System.Windows.Forms.Button();
            this.PictureBoxMap = new System.Windows.Forms.PictureBox();
            this.TextBoxZRead = new System.Windows.Forms.TextBox();
            this.TextBoxYRead = new System.Windows.Forms.TextBox();
            this.TextBoxXRead = new System.Windows.Forms.TextBox();
            this.LabelZ = new System.Windows.Forms.Label();
            this.LabelY = new System.Windows.Forms.Label();
            this.NumericUpDownZ = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.ButtonSetZ = new System.Windows.Forms.Button();
            this.ButtonSetY = new System.Windows.Forms.Button();
            this.ButtonSetX = new System.Windows.Forms.Button();
            this.LabelX = new System.Windows.Forms.Label();
            this.NumericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.TimerUpdate = new System.Windows.Forms.Timer(this.components);
            this.GroupBoxEmulator = new System.Windows.Forms.GroupBox();
            this.LabelEpsxe = new System.Windows.Forms.Label();
            this.LabelPsxfin = new System.Windows.Forms.Label();
            this.GroupBoxChart = new System.Windows.Forms.GroupBox();
            this.LabelChartY = new System.Windows.Forms.Label();
            this.LabelChartX = new System.Windows.Forms.Label();
            this.GroupBoxMap = new System.Windows.Forms.GroupBox();
            this.LabelMapPos = new System.Windows.Forms.Label();
            this.LabelMap = new System.Windows.Forms.Label();
            this.GroupBoxTex = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelEvents = new System.Windows.Forms.Label();
            this.LabelEventY = new System.Windows.Forms.Label();
            this.LabelEventX = new System.Windows.Forms.Label();
            this.labelGrayman = new System.Windows.Forms.Label();
            this.GroupBoxDream.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownX)).BeginInit();
            this.GroupBoxEmulator.SuspendLayout();
            this.GroupBoxChart.SuspendLayout();
            this.GroupBoxMap.SuspendLayout();
            this.GroupBoxTex.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxDream
            // 
            this.GroupBoxDream.Controls.Add(this.ButtonCopyZ);
            this.GroupBoxDream.Controls.Add(this.ButtonCopyY);
            this.GroupBoxDream.Controls.Add(this.ButtonCopyX);
            this.GroupBoxDream.Controls.Add(this.PictureBoxMap);
            this.GroupBoxDream.Controls.Add(this.TextBoxZRead);
            this.GroupBoxDream.Controls.Add(this.TextBoxYRead);
            this.GroupBoxDream.Controls.Add(this.TextBoxXRead);
            this.GroupBoxDream.Controls.Add(this.LabelZ);
            this.GroupBoxDream.Controls.Add(this.LabelY);
            this.GroupBoxDream.Controls.Add(this.NumericUpDownZ);
            this.GroupBoxDream.Controls.Add(this.NumericUpDownY);
            this.GroupBoxDream.Controls.Add(this.ButtonSetZ);
            this.GroupBoxDream.Controls.Add(this.ButtonSetY);
            this.GroupBoxDream.Controls.Add(this.ButtonSetX);
            this.GroupBoxDream.Controls.Add(this.LabelX);
            this.GroupBoxDream.Controls.Add(this.NumericUpDownX);
            this.GroupBoxDream.Location = new System.Drawing.Point(12, 5);
            this.GroupBoxDream.Name = "GroupBoxDream";
            this.GroupBoxDream.Size = new System.Drawing.Size(320, 384);
            this.GroupBoxDream.TabIndex = 9;
            this.GroupBoxDream.TabStop = false;
            this.GroupBoxDream.Text = "Dream Emulator Position";
            // 
            // ButtonCopyZ
            // 
            this.ButtonCopyZ.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ButtonCopyZ.Location = new System.Drawing.Point(137, 80);
            this.ButtonCopyZ.Name = "ButtonCopyZ";
            this.ButtonCopyZ.Size = new System.Drawing.Size(20, 20);
            this.ButtonCopyZ.TabIndex = 15;
            this.ButtonCopyZ.Text = "à";
            this.ButtonCopyZ.UseVisualStyleBackColor = true;
            this.ButtonCopyZ.Click += new System.EventHandler(this.ButtonCopyZ_Click);
            // 
            // ButtonCopyY
            // 
            this.ButtonCopyY.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ButtonCopyY.Location = new System.Drawing.Point(137, 50);
            this.ButtonCopyY.Name = "ButtonCopyY";
            this.ButtonCopyY.Size = new System.Drawing.Size(20, 20);
            this.ButtonCopyY.TabIndex = 14;
            this.ButtonCopyY.Text = "à";
            this.ButtonCopyY.UseVisualStyleBackColor = true;
            this.ButtonCopyY.Click += new System.EventHandler(this.ButtonCopyY_Click);
            // 
            // ButtonCopyX
            // 
            this.ButtonCopyX.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ButtonCopyX.Location = new System.Drawing.Point(137, 20);
            this.ButtonCopyX.Name = "ButtonCopyX";
            this.ButtonCopyX.Size = new System.Drawing.Size(20, 20);
            this.ButtonCopyX.TabIndex = 11;
            this.ButtonCopyX.Text = "à";
            this.ButtonCopyX.UseVisualStyleBackColor = true;
            this.ButtonCopyX.Click += new System.EventHandler(this.ButtonCopyX_Click);
            // 
            // PictureBoxMap
            // 
            this.PictureBoxMap.Image = global::MuscleTrainer.Properties.Resources.map;
            this.PictureBoxMap.Location = new System.Drawing.Point(34, 116);
            this.PictureBoxMap.Name = "PictureBoxMap";
            this.PictureBoxMap.Size = new System.Drawing.Size(254, 254);
            this.PictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxMap.TabIndex = 13;
            this.PictureBoxMap.TabStop = false;
            // 
            // TextBoxZRead
            // 
            this.TextBoxZRead.Location = new System.Drawing.Point(31, 80);
            this.TextBoxZRead.Name = "TextBoxZRead";
            this.TextBoxZRead.ReadOnly = true;
            this.TextBoxZRead.Size = new System.Drawing.Size(100, 20);
            this.TextBoxZRead.TabIndex = 12;
            this.TextBoxZRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextBoxYRead
            // 
            this.TextBoxYRead.Location = new System.Drawing.Point(31, 50);
            this.TextBoxYRead.Name = "TextBoxYRead";
            this.TextBoxYRead.ReadOnly = true;
            this.TextBoxYRead.Size = new System.Drawing.Size(100, 20);
            this.TextBoxYRead.TabIndex = 11;
            this.TextBoxYRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextBoxXRead
            // 
            this.TextBoxXRead.Location = new System.Drawing.Point(31, 20);
            this.TextBoxXRead.Name = "TextBoxXRead";
            this.TextBoxXRead.ReadOnly = true;
            this.TextBoxXRead.Size = new System.Drawing.Size(100, 20);
            this.TextBoxXRead.TabIndex = 10;
            this.TextBoxXRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelZ
            // 
            this.LabelZ.AutoSize = true;
            this.LabelZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelZ.Location = new System.Drawing.Point(10, 83);
            this.LabelZ.Name = "LabelZ";
            this.LabelZ.Size = new System.Drawing.Size(15, 13);
            this.LabelZ.TabIndex = 9;
            this.LabelZ.Text = "Z";
            // 
            // LabelY
            // 
            this.LabelY.AutoSize = true;
            this.LabelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelY.Location = new System.Drawing.Point(10, 53);
            this.LabelY.Name = "LabelY";
            this.LabelY.Size = new System.Drawing.Size(15, 13);
            this.LabelY.TabIndex = 8;
            this.LabelY.Text = "Y";
            // 
            // NumericUpDownZ
            // 
            this.NumericUpDownZ.Increment = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.NumericUpDownZ.Location = new System.Drawing.Point(163, 81);
            this.NumericUpDownZ.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericUpDownZ.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.NumericUpDownZ.Name = "NumericUpDownZ";
            this.NumericUpDownZ.Size = new System.Drawing.Size(100, 20);
            this.NumericUpDownZ.TabIndex = 7;
            this.NumericUpDownZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDownZ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumericUpDownZ_KeyDown);
            // 
            // NumericUpDownY
            // 
            this.NumericUpDownY.Increment = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.NumericUpDownY.Location = new System.Drawing.Point(163, 51);
            this.NumericUpDownY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumericUpDownY.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.NumericUpDownY.Name = "NumericUpDownY";
            this.NumericUpDownY.Size = new System.Drawing.Size(100, 20);
            this.NumericUpDownY.TabIndex = 6;
            this.NumericUpDownY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDownY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumericUpDownY_KeyDown);
            // 
            // ButtonSetZ
            // 
            this.ButtonSetZ.Location = new System.Drawing.Point(269, 81);
            this.ButtonSetZ.Name = "ButtonSetZ";
            this.ButtonSetZ.Size = new System.Drawing.Size(40, 20);
            this.ButtonSetZ.TabIndex = 5;
            this.ButtonSetZ.Text = "Set";
            this.ButtonSetZ.UseVisualStyleBackColor = true;
            this.ButtonSetZ.Click += new System.EventHandler(this.ButtonSetZ_Click);
            // 
            // ButtonSetY
            // 
            this.ButtonSetY.Location = new System.Drawing.Point(269, 51);
            this.ButtonSetY.Name = "ButtonSetY";
            this.ButtonSetY.Size = new System.Drawing.Size(40, 20);
            this.ButtonSetY.TabIndex = 4;
            this.ButtonSetY.Text = "Set";
            this.ButtonSetY.UseVisualStyleBackColor = true;
            this.ButtonSetY.Click += new System.EventHandler(this.ButtonSetY_Click);
            // 
            // ButtonSetX
            // 
            this.ButtonSetX.Location = new System.Drawing.Point(269, 21);
            this.ButtonSetX.Name = "ButtonSetX";
            this.ButtonSetX.Size = new System.Drawing.Size(40, 20);
            this.ButtonSetX.TabIndex = 3;
            this.ButtonSetX.Text = "Set";
            this.ButtonSetX.UseVisualStyleBackColor = true;
            this.ButtonSetX.Click += new System.EventHandler(this.ButtonSetX_Click);
            // 
            // LabelX
            // 
            this.LabelX.AutoSize = true;
            this.LabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelX.Location = new System.Drawing.Point(10, 23);
            this.LabelX.Name = "LabelX";
            this.LabelX.Size = new System.Drawing.Size(15, 13);
            this.LabelX.TabIndex = 2;
            this.LabelX.Text = "X";
            // 
            // NumericUpDownX
            // 
            this.NumericUpDownX.Increment = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.NumericUpDownX.Location = new System.Drawing.Point(163, 21);
            this.NumericUpDownX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumericUpDownX.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.NumericUpDownX.Name = "NumericUpDownX";
            this.NumericUpDownX.Size = new System.Drawing.Size(100, 20);
            this.NumericUpDownX.TabIndex = 1;
            this.NumericUpDownX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDownX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumericUpDownX_KeyDown);
            // 
            // TimerUpdate
            // 
            this.TimerUpdate.Enabled = true;
            this.TimerUpdate.Interval = 50;
            this.TimerUpdate.Tick += new System.EventHandler(this.TimerUpdate_Tick);
            // 
            // GroupBoxEmulator
            // 
            this.GroupBoxEmulator.Controls.Add(this.LabelEpsxe);
            this.GroupBoxEmulator.Controls.Add(this.LabelPsxfin);
            this.GroupBoxEmulator.Location = new System.Drawing.Point(340, 5);
            this.GroupBoxEmulator.Name = "GroupBoxEmulator";
            this.GroupBoxEmulator.Size = new System.Drawing.Size(93, 66);
            this.GroupBoxEmulator.TabIndex = 10;
            this.GroupBoxEmulator.TabStop = false;
            this.GroupBoxEmulator.Text = "Emulator app";
            // 
            // LabelEpsxe
            // 
            this.LabelEpsxe.AutoSize = true;
            this.LabelEpsxe.Enabled = false;
            this.LabelEpsxe.Location = new System.Drawing.Point(7, 36);
            this.LabelEpsxe.Name = "LabelEpsxe";
            this.LabelEpsxe.Size = new System.Drawing.Size(76, 13);
            this.LabelEpsxe.TabIndex = 1;
            this.LabelEpsxe.Text = "ePSXe v.2.0.5";
            // 
            // LabelPsxfin
            // 
            this.LabelPsxfin.AutoSize = true;
            this.LabelPsxfin.Enabled = false;
            this.LabelPsxfin.Location = new System.Drawing.Point(7, 18);
            this.LabelPsxfin.Name = "LabelPsxfin";
            this.LabelPsxfin.Size = new System.Drawing.Size(67, 13);
            this.LabelPsxfin.TabIndex = 0;
            this.LabelPsxfin.Text = "psxfin v.1.13";
            // 
            // GroupBoxChart
            // 
            this.GroupBoxChart.Controls.Add(this.LabelChartY);
            this.GroupBoxChart.Controls.Add(this.LabelChartX);
            this.GroupBoxChart.Location = new System.Drawing.Point(340, 78);
            this.GroupBoxChart.Name = "GroupBoxChart";
            this.GroupBoxChart.Size = new System.Drawing.Size(93, 66);
            this.GroupBoxChart.TabIndex = 11;
            this.GroupBoxChart.TabStop = false;
            this.GroupBoxChart.Text = "Chart";
            // 
            // LabelChartY
            // 
            this.LabelChartY.AutoSize = true;
            this.LabelChartY.Location = new System.Drawing.Point(10, 33);
            this.LabelChartY.Name = "LabelChartY";
            this.LabelChartY.Size = new System.Drawing.Size(51, 13);
            this.LabelChartY.TabIndex = 1;
            this.LabelChartY.Text = "Upper =  ";
            // 
            // LabelChartX
            // 
            this.LabelChartX.AutoSize = true;
            this.LabelChartX.Location = new System.Drawing.Point(10, 20);
            this.LabelChartX.Name = "LabelChartX";
            this.LabelChartX.Size = new System.Drawing.Size(63, 13);
            this.LabelChartX.TabIndex = 0;
            this.LabelChartX.Text = "Dynamic =  ";
            // 
            // GroupBoxMap
            // 
            this.GroupBoxMap.Controls.Add(this.LabelMapPos);
            this.GroupBoxMap.Controls.Add(this.LabelMap);
            this.GroupBoxMap.Location = new System.Drawing.Point(340, 151);
            this.GroupBoxMap.Name = "GroupBoxMap";
            this.GroupBoxMap.Size = new System.Drawing.Size(93, 63);
            this.GroupBoxMap.TabIndex = 12;
            this.GroupBoxMap.TabStop = false;
            this.GroupBoxMap.Text = "Map";
            // 
            // LabelMapPos
            // 
            this.LabelMapPos.AutoSize = true;
            this.LabelMapPos.Location = new System.Drawing.Point(7, 33);
            this.LabelMapPos.Name = "LabelMapPos";
            this.LabelMapPos.Size = new System.Drawing.Size(37, 13);
            this.LabelMapPos.TabIndex = 1;
            this.LabelMapPos.Text = "Pos = ";
            // 
            // LabelMap
            // 
            this.LabelMap.AutoSize = true;
            this.LabelMap.Location = new System.Drawing.Point(7, 20);
            this.LabelMap.Name = "LabelMap";
            this.LabelMap.Size = new System.Drawing.Size(40, 13);
            this.LabelMap.TabIndex = 0;
            this.LabelMap.Text = "Map = ";
            // 
            // GroupBoxTex
            // 
            this.GroupBoxTex.Controls.Add(this.labelGrayman);
            this.GroupBoxTex.Location = new System.Drawing.Point(340, 221);
            this.GroupBoxTex.Name = "GroupBoxGrayman";
            this.GroupBoxTex.Size = new System.Drawing.Size(93, 63);
            this.GroupBoxTex.TabIndex = 13;
            this.GroupBoxTex.TabStop = false;
            this.GroupBoxTex.Text = "Grayman";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelEvents);
            this.groupBox1.Controls.Add(this.LabelEventY);
            this.groupBox1.Controls.Add(this.LabelEventX);
            this.groupBox1.Location = new System.Drawing.Point(340, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 75);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Events";
            // 
            // LabelEvents
            // 
            this.LabelEvents.AutoSize = true;
            this.LabelEvents.Location = new System.Drawing.Point(13, 46);
            this.LabelEvents.Name = "LabelEvents";
            this.LabelEvents.Size = new System.Drawing.Size(25, 13);
            this.LabelEvents.TabIndex = 2;
            this.LabelEvents.Text = "n = ";
            // 
            // LabelEventY
            // 
            this.LabelEventY.AutoSize = true;
            this.LabelEventY.Location = new System.Drawing.Point(13, 33);
            this.LabelEventY.Name = "LabelEventY";
            this.LabelEventY.Size = new System.Drawing.Size(24, 13);
            this.LabelEventY.TabIndex = 1;
            this.LabelEventY.Text = "y = ";
            // 
            // LabelEventX
            // 
            this.LabelEventX.AutoSize = true;
            this.LabelEventX.Location = new System.Drawing.Point(13, 20);
            this.LabelEventX.Name = "LabelEventX";
            this.LabelEventX.Size = new System.Drawing.Size(24, 13);
            this.LabelEventX.TabIndex = 0;
            this.LabelEventX.Text = "x = ";
            // 
            // labelGrayman
            // 
            this.labelGrayman.AutoSize = true;
            this.labelGrayman.Location = new System.Drawing.Point(7, 16);
            this.labelGrayman.Name = "labelGrayman";
            this.labelGrayman.Size = new System.Drawing.Size(0, 13);
            this.labelGrayman.TabIndex = 2;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 401);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBoxTex);
            this.Controls.Add(this.GroupBoxMap);
            this.Controls.Add(this.GroupBoxChart);
            this.Controls.Add(this.GroupBoxEmulator);
            this.Controls.Add(this.GroupBoxDream);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Window";
            this.Text = "MuscleTrainer 1.1 RC5 by Confuseme";
            this.GroupBoxDream.ResumeLayout(false);
            this.GroupBoxDream.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownX)).EndInit();
            this.GroupBoxEmulator.ResumeLayout(false);
            this.GroupBoxEmulator.PerformLayout();
            this.GroupBoxChart.ResumeLayout(false);
            this.GroupBoxChart.PerformLayout();
            this.GroupBoxMap.ResumeLayout(false);
            this.GroupBoxMap.PerformLayout();
            this.GroupBoxTex.ResumeLayout(false);
            this.GroupBoxTex.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxDream;
        private System.Windows.Forms.Button ButtonSetX;
        private System.Windows.Forms.Button ButtonSetY;
        private System.Windows.Forms.Button ButtonSetZ;
        private System.Windows.Forms.Label LabelX;
        private System.Windows.Forms.Label LabelY;
        private System.Windows.Forms.Label LabelZ;
        private System.Windows.Forms.NumericUpDown NumericUpDownX;
        private System.Windows.Forms.NumericUpDown NumericUpDownY;
        private System.Windows.Forms.NumericUpDown NumericUpDownZ;
        private System.Windows.Forms.Timer TimerUpdate;
        private System.Windows.Forms.TextBox TextBoxXRead;
        private System.Windows.Forms.TextBox TextBoxYRead;
        private System.Windows.Forms.TextBox TextBoxZRead;
        private System.Windows.Forms.PictureBox PictureBoxMap;
        private System.Windows.Forms.GroupBox GroupBoxEmulator;
        private System.Windows.Forms.Label LabelEpsxe;
        private System.Windows.Forms.Label LabelPsxfin;
        private System.Windows.Forms.Button ButtonCopyZ;
        private System.Windows.Forms.Button ButtonCopyY;
        private System.Windows.Forms.Button ButtonCopyX;
        private System.Windows.Forms.GroupBox GroupBoxChart;
        private System.Windows.Forms.Label LabelChartY;
        private System.Windows.Forms.Label LabelChartX;
        private System.Windows.Forms.GroupBox GroupBoxMap;
        private System.Windows.Forms.Label LabelMap;
        private System.Windows.Forms.GroupBox GroupBoxTex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelEventX;
        private System.Windows.Forms.Label LabelEventY;
        private System.Windows.Forms.Label LabelEvents;
        private System.Windows.Forms.Label LabelMapPos;
        private System.Windows.Forms.Label labelGrayman;
    }
}


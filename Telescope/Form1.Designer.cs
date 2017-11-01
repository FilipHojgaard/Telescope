namespace Telescope
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.apertureUpDown = new System.Windows.Forms.NumericUpDown();
            this.focalLengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.eyePieceSelector = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.fRatio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.magnification = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.barlowSelector = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.resolution = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mUG = new System.Windows.Forms.Label();
            this.lUE = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.reportBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.degreeBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.fOV = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.apertureUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.focalLengthUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aperture:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Focal Length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Eyepiece:";
            // 
            // apertureUpDown
            // 
            this.apertureUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.apertureUpDown.Location = new System.Drawing.Point(6, 43);
            this.apertureUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.apertureUpDown.Name = "apertureUpDown";
            this.apertureUpDown.Size = new System.Drawing.Size(47, 20);
            this.apertureUpDown.TabIndex = 3;
            // 
            // focalLengthUpDown
            // 
            this.focalLengthUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.focalLengthUpDown.Location = new System.Drawing.Point(68, 43);
            this.focalLengthUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.focalLengthUpDown.Name = "focalLengthUpDown";
            this.focalLengthUpDown.Size = new System.Drawing.Size(59, 20);
            this.focalLengthUpDown.TabIndex = 4;
            // 
            // eyePieceSelector
            // 
            this.eyePieceSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eyePieceSelector.FormattingEnabled = true;
            this.eyePieceSelector.Items.AddRange(new object[] {
            "-None-",
            "7,5 mm",
            "10 mm",
            "12,5 mm",
            "17 mm",
            "20 mm",
            "26 mm",
            "32 mm",
            "40 mm"});
            this.eyePieceSelector.Location = new System.Drawing.Point(142, 43);
            this.eyePieceSelector.Name = "eyePieceSelector";
            this.eyePieceSelector.Size = new System.Drawing.Size(66, 21);
            this.eyePieceSelector.TabIndex = 5;
            this.eyePieceSelector.SelectedIndexChanged += new System.EventHandler(this.eyePieceSelector_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "F Ratio:";
            // 
            // fRatio
            // 
            this.fRatio.AutoSize = true;
            this.fRatio.Location = new System.Drawing.Point(102, 24);
            this.fRatio.Name = "fRatio";
            this.fRatio.Size = new System.Drawing.Size(15, 13);
            this.fRatio.TabIndex = 8;
            this.fRatio.Text = "f/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Magnification:";
            // 
            // magnification
            // 
            this.magnification.AutoSize = true;
            this.magnification.Location = new System.Drawing.Point(102, 48);
            this.magnification.Name = "magnification";
            this.magnification.Size = new System.Drawing.Size(14, 13);
            this.magnification.TabIndex = 10;
            this.magnification.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Barlow:";
            // 
            // barlowSelector
            // 
            this.barlowSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.barlowSelector.FormattingEnabled = true;
            this.barlowSelector.Items.AddRange(new object[] {
            "-None-",
            "2x",
            "2,3x",
            "3x"});
            this.barlowSelector.Location = new System.Drawing.Point(324, 43);
            this.barlowSelector.Name = "barlowSelector";
            this.barlowSelector.Size = new System.Drawing.Size(56, 21);
            this.barlowSelector.TabIndex = 12;
            this.barlowSelector.SelectedIndexChanged += new System.EventHandler(this.barlowSelector_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Resolution:";
            // 
            // resolution
            // 
            this.resolution.AutoSize = true;
            this.resolution.Location = new System.Drawing.Point(102, 74);
            this.resolution.Name = "resolution";
            this.resolution.Size = new System.Drawing.Size(68, 13);
            this.resolution.TabIndex = 14;
            this.resolution.Text = "Arc Seconds";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 21);
            this.button2.TabIndex = 15;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Maximum useful magnification:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(215, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Longest useful eyepiece:";
            // 
            // mUG
            // 
            this.mUG.AutoSize = true;
            this.mUG.Location = new System.Drawing.Point(372, 24);
            this.mUG.Name = "mUG";
            this.mUG.Size = new System.Drawing.Size(13, 13);
            this.mUG.TabIndex = 18;
            this.mUG.Text = "0";
            // 
            // lUE
            // 
            this.lUE.AutoSize = true;
            this.lUE.Location = new System.Drawing.Point(372, 48);
            this.lUE.Name = "lUE";
            this.lUE.Size = new System.Drawing.Size(23, 13);
            this.lUE.TabIndex = 19;
            this.lUE.Text = "mm";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(463, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // reportBox
            // 
            this.reportBox.Location = new System.Drawing.Point(13, 19);
            this.reportBox.Multiline = true;
            this.reportBox.Name = "reportBox";
            this.reportBox.ReadOnly = true;
            this.reportBox.Size = new System.Drawing.Size(339, 150);
            this.reportBox.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Report:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.degreeBox);
            this.groupBox1.Controls.Add(this.apertureUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.focalLengthUpDown);
            this.groupBox1.Controls.Add(this.eyePieceSelector);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.barlowSelector);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 78);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.fOV);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.fRatio);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.magnification);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lUE);
            this.groupBox2.Controls.Add(this.resolution);
            this.groupBox2.Controls.Add(this.mUG);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 107);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Specifications";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.reportBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 182);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Report";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Filip Højgaard Jensen, 2017";
            // 
            // degreeBox
            // 
            this.degreeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.degreeBox.FormattingEnabled = true;
            this.degreeBox.Items.AddRange(new object[] {
            "-Don\'t Know-",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.degreeBox.Location = new System.Drawing.Point(216, 43);
            this.degreeBox.Name = "degreeBox";
            this.degreeBox.Size = new System.Drawing.Size(92, 21);
            this.degreeBox.TabIndex = 13;
            this.degreeBox.SelectedIndexChanged += new System.EventHandler(this.degreeBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(215, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Degree:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(217, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Field of View:";
            // 
            // fOV
            // 
            this.fOV.AutoSize = true;
            this.fOV.Location = new System.Drawing.Point(372, 74);
            this.fOV.Name = "fOV";
            this.fOV.Size = new System.Drawing.Size(63, 13);
            this.fOV.TabIndex = 22;
            this.fOV.Text = "Arc Minutes";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(463, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(463, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(20, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(189, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(20, 21);
            this.button6.TabIndex = 25;
            this.button6.Text = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(188, 20);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(20, 21);
            this.button7.TabIndex = 26;
            this.button7.Text = "?";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(523, 420);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Telescope Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.apertureUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.focalLengthUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown apertureUpDown;
        private System.Windows.Forms.NumericUpDown focalLengthUpDown;
        private System.Windows.Forms.ComboBox eyePieceSelector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fRatio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label magnification;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox barlowSelector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label resolution;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label mUG;
        private System.Windows.Forms.Label lUE;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox reportBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox degreeBox;
        private System.Windows.Forms.Label fOV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}


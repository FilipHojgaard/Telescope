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
            ((System.ComponentModel.ISupportInitialize)(this.apertureUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.focalLengthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aperture:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Focal Length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 18);
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
            this.apertureUpDown.Location = new System.Drawing.Point(12, 34);
            this.apertureUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.apertureUpDown.Name = "apertureUpDown";
            this.apertureUpDown.Size = new System.Drawing.Size(77, 20);
            this.apertureUpDown.TabIndex = 3;
            // 
            // focalLengthUpDown
            // 
            this.focalLengthUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.focalLengthUpDown.Location = new System.Drawing.Point(95, 34);
            this.focalLengthUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.focalLengthUpDown.Name = "focalLengthUpDown";
            this.focalLengthUpDown.Size = new System.Drawing.Size(70, 20);
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
            this.eyePieceSelector.Location = new System.Drawing.Point(183, 32);
            this.eyePieceSelector.Name = "eyePieceSelector";
            this.eyePieceSelector.Size = new System.Drawing.Size(96, 21);
            this.eyePieceSelector.TabIndex = 5;
            this.eyePieceSelector.SelectedIndexChanged += new System.EventHandler(this.eyePieceSelector_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "F Ratio:";
            // 
            // fRatio
            // 
            this.fRatio.AutoSize = true;
            this.fRatio.Location = new System.Drawing.Point(108, 95);
            this.fRatio.Name = "fRatio";
            this.fRatio.Size = new System.Drawing.Size(15, 13);
            this.fRatio.TabIndex = 8;
            this.fRatio.Text = "f/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Magnification:";
            // 
            // magnification
            // 
            this.magnification.AutoSize = true;
            this.magnification.Location = new System.Drawing.Point(108, 119);
            this.magnification.Name = "magnification";
            this.magnification.Size = new System.Drawing.Size(14, 13);
            this.magnification.TabIndex = 10;
            this.magnification.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 17);
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
            this.barlowSelector.Location = new System.Drawing.Point(296, 32);
            this.barlowSelector.Name = "barlowSelector";
            this.barlowSelector.Size = new System.Drawing.Size(56, 21);
            this.barlowSelector.TabIndex = 12;
            this.barlowSelector.SelectedIndexChanged += new System.EventHandler(this.barlowSelector_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Resolution:";
            // 
            // resolution
            // 
            this.resolution.AutoSize = true;
            this.resolution.Location = new System.Drawing.Point(108, 145);
            this.resolution.Name = "resolution";
            this.resolution.Size = new System.Drawing.Size(68, 13);
            this.resolution.TabIndex = 14;
            this.resolution.Text = "Arc Seconds";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 141);
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
            this.label8.Location = new System.Drawing.Point(219, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Maximum useful magnification:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Longest useful eyepiece:";
            // 
            // mUG
            // 
            this.mUG.AutoSize = true;
            this.mUG.Location = new System.Drawing.Point(376, 95);
            this.mUG.Name = "mUG";
            this.mUG.Size = new System.Drawing.Size(13, 13);
            this.mUG.TabIndex = 18;
            this.mUG.Text = "0";
            // 
            // lUE
            // 
            this.lUE.AutoSize = true;
            this.lUE.Location = new System.Drawing.Point(376, 119);
            this.lUE.Name = "lUE";
            this.lUE.Size = new System.Drawing.Size(13, 13);
            this.lUE.TabIndex = 19;
            this.lUE.Text = "0";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(404, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(471, 352);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lUE);
            this.Controls.Add(this.mUG);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resolution);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.barlowSelector);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.magnification);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fRatio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eyePieceSelector);
            this.Controls.Add(this.focalLengthUpDown);
            this.Controls.Add(this.apertureUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Telescope Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.apertureUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.focalLengthUpDown)).EndInit();
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
    }
}


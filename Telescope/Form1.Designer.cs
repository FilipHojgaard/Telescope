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
            ((System.ComponentModel.ISupportInitialize)(this.apertureUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.focalLengthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aperture:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Focal Length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 30);
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
            this.apertureUpDown.Location = new System.Drawing.Point(33, 46);
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
            this.focalLengthUpDown.Location = new System.Drawing.Point(116, 46);
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
            this.eyePieceSelector.Location = new System.Drawing.Point(204, 44);
            this.eyePieceSelector.Name = "eyePieceSelector";
            this.eyePieceSelector.Size = new System.Drawing.Size(96, 21);
            this.eyePieceSelector.TabIndex = 5;
            this.eyePieceSelector.SelectedIndexChanged += new System.EventHandler(this.eyePieceSelector_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 34);
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
            this.label4.Location = new System.Drawing.Point(33, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "F Ratio:";
            // 
            // fRatio
            // 
            this.fRatio.AutoSize = true;
            this.fRatio.Location = new System.Drawing.Point(129, 107);
            this.fRatio.Name = "fRatio";
            this.fRatio.Size = new System.Drawing.Size(15, 13);
            this.fRatio.TabIndex = 8;
            this.fRatio.Text = "f/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Magnification:";
            // 
            // magnification
            // 
            this.magnification.AutoSize = true;
            this.magnification.Location = new System.Drawing.Point(129, 131);
            this.magnification.Name = "magnification";
            this.magnification.Size = new System.Drawing.Size(14, 13);
            this.magnification.TabIndex = 10;
            this.magnification.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(406, 352);
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
    }
}


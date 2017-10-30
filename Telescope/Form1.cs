using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telescope
{
    public partial class Form1 : Form
    {
        public double eyePiece;
        public double mag;

        public Form1()
        {
            InitializeComponent();
            eyePieceSelector.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (focalLengthUpDown.Value == 0 || apertureUpDown.Value == 0)
                MessageBox.Show("You can not Divide by 0","Error");
            else
            {
                fRatio.Text = "f/" + Math.Round(focalLengthUpDown.Value / apertureUpDown.Value, 1);
                mag = (Convert.ToDouble(focalLengthUpDown.Value) / eyePiece);
                Console.WriteLine("eyepiece: " + eyePiece);
                Console.WriteLine("index: " + eyePieceSelector.SelectedIndex);
                if (eyePieceSelector.SelectedIndex == 0)
                    magnification.Text = "Select Eyepiece";
                else
                    magnification.Text = Math.Round(mag,1) + "X";
            }
        }

        private void eyePieceSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eyePieceSelector.SelectedIndex == 1)
                eyePiece = 7.5;
            if (eyePieceSelector.SelectedIndex == 2)
                eyePiece = 10;
            if (eyePieceSelector.SelectedIndex == 3)
                eyePiece = 12.5;
            if (eyePieceSelector.SelectedIndex == 4)
                eyePiece = 17;
            if (eyePieceSelector.SelectedIndex == 5)
                eyePiece = 20;
            if (eyePieceSelector.SelectedIndex == 6)
                eyePiece = 26;
            if (eyePieceSelector.SelectedIndex == 7)
                eyePiece = 32;
            if (eyePieceSelector.SelectedIndex == 8)
                eyePiece = 40;
            
        }
    }
}
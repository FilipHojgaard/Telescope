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
        public double barlow = 1;

        public Form1()
        {
            InitializeComponent();
            eyePieceSelector.SelectedIndex = 0;
            barlowSelector.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Focal Ratio Calculation
            if (focalLengthUpDown.Value == 0 || apertureUpDown.Value == 0)
                MessageBox.Show("You can not Divide by 0","Error");
            else
            {
                fRatio.Text = "f/" + Math.Round(focalLengthUpDown.Value / apertureUpDown.Value, 1);

                // Magnification calculation
                mag = (Convert.ToDouble(focalLengthUpDown.Value) / eyePiece * barlow);  // mag bliver magnification efter focallength, eyepiece og barlow værdier
                Console.WriteLine("eyepiece: " + eyePiece);
                Console.WriteLine("index: " + eyePieceSelector.SelectedIndex);
                if (eyePieceSelector.SelectedIndex == 0)
                    magnification.Text = "Select Eyepiece";
                else
                    magnification.Text = Math.Round(mag,1) + "X";
                // Resolution  calculation
                resolution.Text = "" + Math.Round((120/apertureUpDown.Value), 1) + " Arc Seconds";
                // Maximum useful magnification calculation
                mUG.Text = "" + 2.5 * Convert.ToDouble(apertureUpDown.Value) + "X";
                // Longest useful eyepiece calculation
                lUE.Text = "" + 7 * Math.Round(focalLengthUpDown.Value / apertureUpDown.Value, 1) + " mm";
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

        private void barlowSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (barlowSelector.SelectedIndex == 1)
                barlow = 2;
            if (barlowSelector.SelectedIndex == 2)
                barlow = 2.3;
            if (barlowSelector.SelectedIndex == 3)
                barlow = 3;
            if (barlowSelector.SelectedIndex == 0)
                barlow = 1;
            Console.WriteLine("barlow: " + barlow);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resolution is measured in Arc Seconds. It is the smalles angular" +
                " distance between 2 points that you can seperate with your telescope, for instance a double star." +
                " Smaller is better." +
                "\n\n Unsteadiness in skyes, makes 1 arc second the practical limit for amateurs.", "Help");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Light that comes through your eyepiece but doesn't make it to your eye is wasted. " +
                "Your eyes pupil is about 7 mm, so your eyepiece should have a focal length no larger " +
                "than the width of your pupil, which gets smaller as you age.", "Help");
        }
    }
}
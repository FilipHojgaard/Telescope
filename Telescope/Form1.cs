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
        public int apertureClass;
        public int fClass;
        public double f;
        public bool reflector;
        public bool both = false;

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
                f = Convert.ToDouble(Math.Round(focalLengthUpDown.Value / apertureUpDown.Value, 1));
                fRatio.Text = "f/" + f;

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
                // Udregn og print report
                reportBox.Text = "";
                both = false;
                scopeClass();
                report();
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

        private void scopeClass()
        {
            // apertureClass
            if (apertureUpDown.Value < 80)
                apertureClass = 1;
            else if (apertureUpDown.Value < 130)
                apertureClass = 2;
            else if (apertureUpDown.Value < 170)
                apertureClass = 3;
            else if (apertureUpDown.Value < 250)
                apertureClass = 4;
            else if (apertureUpDown.Value >= 250)
                apertureClass = 5;
            // fClass
            if (f <= 6.5)
                fClass = 1;
            else if (f <= 9.5)
                fClass = 2;
            else if (f > 9.5)
                fClass = 3;
        }

        private void report()
        {
            // Størrelse
            if (apertureClass == 1)
                reportBox.Text += "This is a small telescope\r\n";
            else if (apertureClass == 2)
                reportBox.Text += "This is a medium/small telescope\r\n";
            else if (apertureClass == 3)
                reportBox.Text += "This is a medium telescope\r\n";
            else if (apertureClass == 4)
                reportBox.Text += "This is a large telescope\r\n";
            else if (apertureClass == 5)
                reportBox.Text += "This is a very large telescope\r\n";
            // Type
            if (apertureClass == 1)
            {
                reportBox.Text += "It is probably a refractor\r\n";
                reflector = false;
            }
                
            else if (apertureClass == 2)
            {
                if (fClass == 3)
                {
                    reportBox.Text += "It is a refractor\r\n";
                    reflector = false;
                }
                else if (fClass == 1 || fClass == 2)
                {
                    reportBox.Text += "It is probably a reflector\r\n";
                    reflector = true;
                }
            }
            else if (apertureClass == 3)
            {
                if (fClass == 3)
                {
                    reportBox.Text += "It could be both a refractor and reflector\r\n";
                    both = true;
                }
                else if (fClass == 1 || fClass == 2)
                {
                    reportBox.Text += "It is a reflector\r\n";
                    reflector = true;
                }
            }
            if (apertureClass == 4)
            {
                reportBox.Text += "It is a reflector\r\n";
                reflector = true;
            }
            if (apertureClass == 5)
            {
                reportBox.Text += "It is a reflector\r\n";
                reflector = true;
            }

            // Styrker
            if (both == true)
            {
                if (fClass == 2)
                    reportBox.Text += "A telescope with a medium f ratio is good at both deep sky observing along with moon and planets. Use a low power eyepiece for the moon and a high power for nebuaes and star clusters\r\n";
                else if (fClass == 1)
                    reportBox.Text += "A telescope with a low f ratio is good at deep sky observing. Use a high power eyepiece and look for nebuales, galaxies and star clusters\r\n";
                else if (fClass == 3)
                    reportBox.Text += "A telescope with a high f ratio is good at moon/planets observing. Use a low eyepiece and look for moon craters, Saturns rings or Jupiters moons";
            }
            else if (reflector && fClass != 3)
            {
                reportBox.Text += "A low f ratio reflector is good at observing deep sky objects with a high power eyepiece. look for nebulaes, galaxies or star clusters\r\n";
            }
            else if (reflector && fClass == 3)
            {
                reportBox.Text += "A high f ratio reflector is not so common. If your aparture is great you can use this for both deep sky observing and moon/planets observing. If not use this telescope for moon/planet observing\r\n";
            }
            else
            {
                reportBox.Text += "A high f ratio refractor is good at observing the moon and planets. Use a low power eyepiece to gain magnifications and view moon craters, Saturns rings or Jupiters moons\r\n";
            }

            }
    }
}
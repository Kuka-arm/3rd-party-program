using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_7_KUKA_arm
{
    public partial class frmMain : Form
    {
        color_picker color = new color_picker();
        int[] colors = { -1, 0, 1, 2 }; // Index of output colors

        Sorting sorting = new Sorting();

        public frmMain()
        {
            InitializeComponent();
        }

        private void c1_output_Click(object sender, EventArgs e)
        {
            if (colors[0] < 3) // Cycling through colors
            {
                colors[0]++;
            }
            else // Resetting colors if last one is displayed
            {
                colors[0] = 0;
            }

            c1_output.BackColor =  color.PickColor(colors[0]); // Assign new color
        }

        private void c2_output_Click(object sender, EventArgs e)
        {
            if (colors[1] < 3) // Cycling through colors
            {
                colors[1]++;
            }
            else // Resetting colors if last one is displayed
            {
                colors[1] = 0;
            }

            c2_output.BackColor = color.PickColor(colors[1]);
        }

        private void c3_output_Click(object sender, EventArgs e)
        {
            if (colors[2] < 3) // Cycling through colors
            {
                colors[2]++;
            }
            else // Resetting colors if last one is displayed
            {
                colors[2] = 0;
            }

            c3_output.BackColor = color.PickColor(colors[2]);
        }

        private void c4_output_Click(object sender, EventArgs e)
        {
            if (colors[3] < 3) // Cycling through colors
            {
                colors[3]++;
            }
            else // Resetting colors if last one is displayed
            {
                colors[3] = 0;
            }

            c4_output.BackColor = color.PickColor(colors[3]);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Bitmap picture = new Bitmap(pictureBox1.Image);

            Color newColor1 = picture.GetPixel(200,200);
            Color newColor2 = picture.GetPixel(400, 200);
            Color newColor3 = picture.GetPixel(200, 400);
            Color newColor4 = picture.GetPixel(400, 400);

            c1_input.BackColor = color.Colors[color.FindNearestColor(color.Colors, newColor1)];
            c2_input.BackColor = color.Colors[color.FindNearestColor(color.Colors, newColor2)];
            c3_input.BackColor = color.Colors[color.FindNearestColor(color.Colors, newColor3)];
            c4_input.BackColor = color.Colors[color.FindNearestColor(color.Colors, newColor4)];
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click_1(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.bmp)|*.png; *.jpg; *.jpeg; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void btnSort_Click_1(object sender, EventArgs e)
        {
            Color[] inputColors = { c1_input.BackColor, c2_input.BackColor, c3_input.BackColor, c4_input.BackColor };
            Color[] outputColors = { c1_output.BackColor, c2_output.BackColor, c3_output.BackColor, c4_output.BackColor };

            string[] scripts = new string[4];

            for (int i = 0; i < 4; i++) // For each one of the inputs
            {
                for (int j = 0; j < 4; j++) // For testing each output
                {
                    if (inputColors[i] == outputColors[j])
                    {
                        scripts[i] = sorting.Inputs[i] + " to " + sorting.Outputs[j];
                    }
                }
            }

            MessageBox.Show(scripts[0] + ", " + scripts[1] + ", " + scripts[2] + ", " + scripts[3]);
        }
    }
}

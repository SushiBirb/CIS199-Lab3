// Name: Josh Mattingly
// Lab: Lab 3
// Due Date: Sunday, Sep 20 (by 11:59 PM)
// Course Section: CIS 199-01
// Description: This Windows Forms application calculates and displays several
//              geometric values (diameter, surface area, and volume) of a sphere
//              given its radius entered by the user.

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler that loads the sphere image into the picture boxes when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            string imagePath; // Path to the sphere image file

            imagePath = Path.Combine(Application.StartupPath, "Sphere_and_Ball.png");
            if (File.Exists(imagePath))
            {
                topLeftPictureBox.Image = Image.FromFile(imagePath);
                bottomRightPictureBox.Image = Image.FromFile(imagePath);
            }
        }

        // Event handler that calculates sphere diameter, surface area, and volume when the user clicks Calculate or presses Enter
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double radius; // Stores the user-entered sphere radius
            double diameter; // Stores the calculated sphere diameter
            double surfaceArea; // Stores the calculated sphere surface area
            double volume; // Stores the calculated sphere volume

            // Gather the radius from the user input
            radius = double.Parse(radiusTextBox.Text);

            // Calculate the geometric properties using the Math library
            diameter = 2 * radius;
            surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);
            volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

            // Display the results formatted to 2 decimal places
            diameterOutputLabel.Text = diameter.ToString("F2");
            surfaceAreaOutputLabel.Text = surfaceArea.ToString("F2");
            volumeOutputLabel.Text = volume.ToString("F2");
        }
    }
}

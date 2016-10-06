using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Result
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            double physics = Convert.ToDouble(physicsTextBox.Text);
            double chemistry = Convert.ToDouble(chemistryTextBox.Text);
            double math = Convert.ToDouble(mathTextBox.Text);

            Result aResult = new Result();
            aResult.Chemistry = physics;
            aResult.Physics = physics;
            aResult.Math = math;

            avarageTextBox.Text = aResult.GetAvarage().ToString();
            gradeLetterTextBox.Text = aResult.GradeLetter();
        }
    }
}

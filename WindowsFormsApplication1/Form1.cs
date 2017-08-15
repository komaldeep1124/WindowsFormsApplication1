using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// this changes the metric units
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            HeightUnits.Text = "m";
            WeightUnits.Text = "kgs";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void weight_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// this changes imperical units
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ImperialButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnits.Text = "inches";
            WeightUnits.Text = "pounds";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// calculates bmi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculate_Click(object sender, EventArgs e)
        {
            if (Imperial.Checked == true)
            {
                double height = double.Parse(HeightText.Text);
                double Weight = double.Parse(WeightText.Text);
                double BMI;
                BMI = (Weight * 703) / (height * height);
                BMIResults.Text = BMI.ToString();
                if (BMI <= 18.5)
                {
                    result.Text = "Underweight";
                }
                else if (BMI > 18.5 && BMI <= 24.9)
                {
                    result.Text = "Normal";
                }
                else if (BMI > 25 && BMI <= 29.9)
                {
                    result.Text = "Overweight";
                }
                else if (BMI >= 30)
                {
                    result.Text = "Obese";
                }
            }
            if (Metric.Checked == true)
            {
                double height = double.Parse(HeightText.Text);
                double Weight = double.Parse(WeightText.Text);
                double BMI;
                BMI = (Weight) / (height * height);
                BMIResults.Text = BMI.ToString();
                if (BMI <= 18.5)
                {
                    result.Text = "Underweight";
                }
                else if (BMI > 18.5 && BMI <= 24.9)
                {
                    result.Text = "Normal";
                }
                else if (BMI > 25 && BMI <= 29.9)
                {
                    result.Text = "Overweight";
                }
                else if (BMI >= 30)
                {
                    result.Text = "Obese";
                }
            }
        }

    }


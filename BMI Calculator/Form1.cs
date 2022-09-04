using System;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        int age;
        double height;
        double weight;
        double bmi;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            height = Double.Parse(HeightTextBox.Text);
            weight = Double.Parse(WeightTextBox.Text);
            bmi = weight / (height * height / 10000);
            BMITextBox.Text = String.Format("{0:f}", bmi);

            if(bmi < 18.5) { ShowBMI.Text = String.Format("Underweight"); }
            else if (bmi >= 18.5 & bmi < 25) { ShowBMI.Text = String.Format("Normal"); }
            else if (bmi >= 25 & bmi < 30) { ShowBMI.Text = String.Format("Overweight"); }
            else if (bmi >= 30 & bmi < 35) { ShowBMI.Text = String.Format("Obese Class 1"); }
            else if (bmi >= 35 & bmi < 40) { ShowBMI.Text = String.Format("Obese Class 2"); }
            else if (bmi >= 40) { ShowBMI.Text = String.Format("Obese Class 3"); }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            HeightTextBox.Clear();
            WeightTextBox.Clear();
            BMITextBox.Clear();
            ShowBMI.Text = String.Format("");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
        
        }

        private void BMITextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void instuctionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset_Click(sender,e);
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
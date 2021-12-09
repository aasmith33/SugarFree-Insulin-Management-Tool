// Abigail Smith
// 2021

using System;
using System.Windows.Forms;

namespace Abigail_Smith_CPT_185_Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TotalDailyInsulin dailyInsulin = new TotalDailyInsulin();
            dailyInsulin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MealCoverageInsulin mealcoverage = new MealCoverageInsulin();
            mealcoverage.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GlucoseCorrection glucose = new GlucoseCorrection();
            glucose.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }
    }
}

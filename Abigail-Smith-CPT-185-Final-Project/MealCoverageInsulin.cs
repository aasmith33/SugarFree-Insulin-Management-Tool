// Abigail Smith
// 2021

using System;
using System.Windows.Forms;

namespace Abigail_Smith_CPT_185_Final_Project
{
    public partial class MealCoverageInsulin : Form
    {
        public MealCoverageInsulin()
        {
            InitializeComponent();
        }

        private void btnCalc2_Click(object sender, EventArgs e)
        {
            try
            {
                double ratio = double.Parse(txtCarbToInsulin.Text);
                double currentGlucose = double.Parse(txtGlucoseLevel.Text);
                double grams = double.Parse(txtGrams.Text);
                double totalDaily = double.Parse(txtDailyInsulin.Text);
                double targetGlucose = 100;
                double mealInsulin;
                double additionalIns;
                double totalNeeded;
                double correctionFactor;


                if (cmbInsulinType.SelectedIndex == 0)
                {
                    correctionFactor = 1500 / totalDaily;
                    additionalIns = (currentGlucose - targetGlucose) / correctionFactor;
                    mealInsulin = grams / ratio;
                    totalNeeded = mealInsulin + additionalIns;
                    lblInsulinNeeded.Text = totalNeeded.ToString("0.00");
                }
                if (cmbInsulinType.SelectedIndex == 1)
                {
                    correctionFactor = 1800 / totalDaily;
                    additionalIns = (currentGlucose - targetGlucose) / correctionFactor;
                    mealInsulin = grams / ratio;
                    totalNeeded = mealInsulin + additionalIns;
                    lblInsulinNeeded.Text = totalNeeded.ToString("0.00");
                }
            }
            catch
            {
                MessageBox.Show("Make sure all fields are filled in then try again.");
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            cmbInsulinType.SelectedIndex = -1;
            txtCarbToInsulin.Clear();
            txtDailyInsulin.Clear();
            txtGlucoseLevel.Clear();
            txtGrams.Clear();
            lblInsulinNeeded.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TotalDailyInsulin form = new TotalDailyInsulin();
            form.ShowDialog();
        }
    }
}

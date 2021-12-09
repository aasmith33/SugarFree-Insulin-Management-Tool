// Abigail Smith
// 2021

using System;
using System.Windows.Forms;

namespace Abigail_Smith_CPT_185_Final_Project
{
    public partial class GlucoseCorrection : Form
    {
        public GlucoseCorrection()
        {
            InitializeComponent();
            cmbInsulinType.Focus();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double gLevel = double.Parse(txtGlucoseLevel.Text);
                double dailyNeeded = double.Parse(txtDailyInsulin.Text);
                double targetGlucose = double.Parse(txtTargetGlucose.Text);
                double insulinNeeded;
                double correctionFactor;

                if (cmbInsulinType.SelectedIndex == 0)
                {
                    correctionFactor = 1500 / dailyNeeded;
                    insulinNeeded = (gLevel - targetGlucose) / correctionFactor;
                    lblInsulinNeeded.Text = insulinNeeded.ToString("0.00");
                }
                if (cmbInsulinType.SelectedIndex == 1)
                {
                    correctionFactor = 1800 / dailyNeeded;
                    insulinNeeded = (gLevel - targetGlucose) / correctionFactor;
                    lblInsulinNeeded.Text = insulinNeeded.ToString("0.00");
                }
            }
            catch
            {
                MessageBox.Show("Make sure all fields are filled in then try again.");
            }

        }

        private void linkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TotalDailyInsulin dailyInsulin = new TotalDailyInsulin();
            dailyInsulin.ShowDialog();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            cmbInsulinType.SelectedIndex = -1;
            txtGlucoseLevel.Clear();
            txtDailyInsulin.Clear();
            txtTargetGlucose.Clear();
            lblInsulinNeeded.Text = "";
            cmbInsulinType.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

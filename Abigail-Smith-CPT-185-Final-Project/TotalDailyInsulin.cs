// Abigail Smith
// 2021
using System;
using System.Windows.Forms;

namespace Abigail_Smith_CPT_185_Final_Project
{
    public partial class TotalDailyInsulin : Form
    {
        public TotalDailyInsulin()
        {
            InitializeComponent();
            txtWeight.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double weight = double.Parse(txtWeight.Text);
                double totalDaily;
                double basalRate;
                double bolusRate;
                double carbToInsulin;

                totalDaily = weight / 4;
                basalRate = totalDaily * .40;
                bolusRate = (totalDaily * .60) / 3;
                carbToInsulin = 500 / totalDaily;

                lblDailyInsulin.Text = totalDaily.ToString();
                lblBasal.Text = basalRate.ToString();
                lblBolus.Text = bolusRate.ToString();
                lblCarbToInsulin.Text = ("1:" + carbToInsulin.ToString("n1") + "\n" + " For every " + carbToInsulin.ToString("0.0") + " grams of carbohydrates you eat, take one unit of insulin.");

            }
            catch
            {
                MessageBox.Show("Make sure all fields are filled in then try again.");
            }

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            txtWeight.Clear();
            lblBasal.Text = "";
            lblBolus.Text = "";
            lblCarbToInsulin.Text = "";
            lblDailyInsulin.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

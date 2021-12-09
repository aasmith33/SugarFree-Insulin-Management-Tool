
namespace Abigail_Smith_CPT_185_Final_Project
{
    partial class TotalDailyInsulin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TotalDailyInsulin));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCarbToInsulin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBolus = new System.Windows.Forms.Label();
            this.lblBasal = new System.Windows.Forms.Label();
            this.lblDailyInsulin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(330, 496);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 33);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.AutoSize = true;
            this.btnMainMenu.Location = new System.Drawing.Point(80, 496);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(110, 33);
            this.btnMainMenu.TabIndex = 6;
            this.btnMainMenu.Text = "Clear";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCarbToInsulin);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblBolus);
            this.groupBox1.Controls.Add(this.lblBasal);
            this.groupBox1.Controls.Add(this.lblDailyInsulin);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtWeight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(38, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 453);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Daily Insulin Requirement";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(340, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 28);
            this.label9.TabIndex = 14;
            this.label9.Text = "units per meal";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(340, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 28);
            this.label8.TabIndex = 13;
            this.label8.Text = "units";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(340, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "units";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(408, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "lbs.";
            // 
            // lblCarbToInsulin
            // 
            this.lblCarbToInsulin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarbToInsulin.Location = new System.Drawing.Point(203, 336);
            this.lblCarbToInsulin.Name = "lblCarbToInsulin";
            this.lblCarbToInsulin.Size = new System.Drawing.Size(236, 100);
            this.lblCarbToInsulin.TabIndex = 10;
            this.lblCarbToInsulin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(38, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 28);
            this.label7.TabIndex = 9;
            this.label7.Text = "Carb To Insulin Ratio:";
            // 
            // lblBolus
            // 
            this.lblBolus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBolus.Location = new System.Drawing.Point(203, 284);
            this.lblBolus.Name = "lblBolus";
            this.lblBolus.Size = new System.Drawing.Size(131, 28);
            this.lblBolus.TabIndex = 8;
            // 
            // lblBasal
            // 
            this.lblBasal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBasal.Location = new System.Drawing.Point(203, 231);
            this.lblBasal.Name = "lblBasal";
            this.lblBasal.Size = new System.Drawing.Size(131, 28);
            this.lblBasal.TabIndex = 7;
            // 
            // lblDailyInsulin
            // 
            this.lblDailyInsulin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDailyInsulin.Location = new System.Drawing.Point(203, 173);
            this.lblDailyInsulin.Name = "lblDailyInsulin";
            this.lblDailyInsulin.Size = new System.Drawing.Size(131, 28);
            this.lblDailyInsulin.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(38, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bolus:  ";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(38, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Basal: ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(38, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Daily Insulin: ";
            // 
            // txtWeight
            // 
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeight.Location = new System.Drawing.Point(256, 47);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(146, 30);
            this.txtWeight.TabIndex = 0;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please Input Your Weight:";
            // 
            // TotalDailyInsulin
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(545, 552);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TotalDailyInsulin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total Daily Insulin Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCarbToInsulin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBolus;
        private System.Windows.Forms.Label lblBasal;
        public System.Windows.Forms.Label lblDailyInsulin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label2;
    }
}
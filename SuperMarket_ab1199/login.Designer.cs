
namespace SuperMarket_ab1199
{
    partial class frmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDairy = new System.Windows.Forms.Button();
            this.btnCleaning = new System.Windows.Forms.Button();
            this.btnCooking = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblWel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(129, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 75);
            this.panel1.TabIndex = 3;
            // 
            // lblWel
            // 
            this.lblWel.AutoSize = true;
            this.lblWel.Location = new System.Drawing.Point(10, 28);
            this.lblWel.Name = "lblWel";
            this.lblWel.Size = new System.Drawing.Size(35, 13);
            this.lblWel.TabIndex = 0;
            this.lblWel.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.btnDairy);
            this.panel2.Controls.Add(this.btnCleaning);
            this.panel2.Controls.Add(this.btnCooking);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(129, 266);
            this.panel2.TabIndex = 4;
            // 
            // btnDairy
            // 
            this.btnDairy.Location = new System.Drawing.Point(33, 128);
            this.btnDairy.Name = "btnDairy";
            this.btnDairy.Size = new System.Drawing.Size(79, 34);
            this.btnDairy.TabIndex = 2;
            this.btnDairy.Text = "Dairy Products";
            this.btnDairy.UseVisualStyleBackColor = true;
            this.btnDairy.Click += new System.EventHandler(this.btnDairy_Click);
            // 
            // btnCleaning
            // 
            this.btnCleaning.Location = new System.Drawing.Point(33, 76);
            this.btnCleaning.Name = "btnCleaning";
            this.btnCleaning.Size = new System.Drawing.Size(79, 34);
            this.btnCleaning.TabIndex = 1;
            this.btnCleaning.Text = " Cleaning Materials";
            this.btnCleaning.UseVisualStyleBackColor = true;
            this.btnCleaning.Click += new System.EventHandler(this.btnCleaning_Click);
            // 
            // btnCooking
            // 
            this.btnCooking.Location = new System.Drawing.Point(33, 23);
            this.btnCooking.Name = "btnCooking";
            this.btnCooking.Size = new System.Drawing.Size(79, 34);
            this.btnCooking.TabIndex = 0;
            this.btnCooking.Text = "Cooking and Baking";
            this.btnCooking.UseVisualStyleBackColor = true;
            this.btnCooking.Click += new System.EventHandler(this.btnCooking_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(157)))), ((int)(((byte)(124)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 266);
            this.panel3.TabIndex = 5;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 266);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "frmLogin";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDairy;
        private System.Windows.Forms.Button btnCleaning;
        private System.Windows.Forms.Button btnCooking;
        private System.Windows.Forms.Panel panel3;
    }
}

namespace SuperMarket_ab1199
{
    partial class addform1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Red;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAdd.Location = new System.Drawing.Point(112, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 38);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtName.Location = new System.Drawing.Point(82, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 20);
            this.txtName.TabIndex = 44;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtID.Location = new System.Drawing.Point(82, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(193, 20);
            this.txtID.TabIndex = 43;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblName.Location = new System.Drawing.Point(32, 72);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(27, 13);
            this.lblName.TabIndex = 42;
            this.lblName.Text = "Item";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblID.Location = new System.Drawing.Point(41, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 41;
            this.lblID.Text = "ID";
            // 
            // addform1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 269);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Name = "addform1";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
    }
}
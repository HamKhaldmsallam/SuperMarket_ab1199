
namespace SuperMarket_ab1199
{
    partial class frmCooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCooking));
            this.btnclear = new System.Windows.Forms.Button();
            this.lbxSelection4 = new System.Windows.Forms.CheckedListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbQuantity = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(101, 202);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(93, 42);
            this.btnclear.TabIndex = 18;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lbxSelection4
            // 
            this.lbxSelection4.FormattingEnabled = true;
            this.lbxSelection4.Location = new System.Drawing.Point(0, 28);
            this.lbxSelection4.Name = "lbxSelection4";
            this.lbxSelection4.Size = new System.Drawing.Size(124, 94);
            this.lbxSelection4.TabIndex = 17;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(313, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disableToolStripMenuItem,
            this.aDDToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.toolStripSplitButton1.ForeColor = System.Drawing.Color.Black;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripSplitButton1.Text = "Process";
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.disableToolStripMenuItem.Text = "Display Order";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // aDDToolStripMenuItem
            // 
            this.aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            this.aDDToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.aDDToolStripMenuItem.Text = "ADD";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(184, 33);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 15;
            this.lblQuantity.Text = "Quantity";
            // 
            // cmbQuantity
            // 
            this.cmbQuantity.FormattingEnabled = true;
            this.cmbQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbQuantity.Location = new System.Drawing.Point(193, 51);
            this.cmbQuantity.Name = "cmbQuantity";
            this.cmbQuantity.Size = new System.Drawing.Size(37, 21);
            this.cmbQuantity.TabIndex = 14;
            // 
            // frmCooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(313, 287);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lbxSelection4);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.cmbQuantity);
            this.Name = "frmCooking";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.CheckedListBox lbxSelection4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cmbQuantity;
    }
}

namespace SuperMarket_ad0068
{
    partial class frmCleaning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCleaning));
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbQuantity = new System.Windows.Forms.ComboBox();
            this.grbthelist = new System.Windows.Forms.GroupBox();
            this.chbperfumed = new System.Windows.Forms.CheckBox();
            this.chbsoap = new System.Windows.Forms.CheckBox();
            this.chbshampoo = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnclear = new System.Windows.Forms.Button();
            this.grbthelist.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(244, 80);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(53, 15);
            this.lblQuantity.TabIndex = 7;
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
            this.cmbQuantity.Location = new System.Drawing.Point(254, 101);
            this.cmbQuantity.Name = "cmbQuantity";
            this.cmbQuantity.Size = new System.Drawing.Size(43, 23);
            this.cmbQuantity.TabIndex = 6;
            // 
            // grbthelist
            // 
            this.grbthelist.Controls.Add(this.chbperfumed);
            this.grbthelist.Controls.Add(this.chbsoap);
            this.grbthelist.Controls.Add(this.chbshampoo);
            this.grbthelist.Location = new System.Drawing.Point(41, 54);
            this.grbthelist.Name = "grbthelist";
            this.grbthelist.Size = new System.Drawing.Size(126, 137);
            this.grbthelist.TabIndex = 5;
            this.grbthelist.TabStop = false;
            this.grbthelist.Text = "The List";
            // 
            // chbperfumed
            // 
            this.chbperfumed.AutoSize = true;
            this.chbperfumed.Location = new System.Drawing.Point(17, 76);
            this.chbperfumed.Name = "chbperfumed";
            this.chbperfumed.Size = new System.Drawing.Size(78, 19);
            this.chbperfumed.TabIndex = 2;
            this.chbperfumed.Text = "Perfumed";
            this.chbperfumed.UseVisualStyleBackColor = true;
            // 
            // chbsoap
            // 
            this.chbsoap.AutoSize = true;
            this.chbsoap.Location = new System.Drawing.Point(17, 51);
            this.chbsoap.Name = "chbsoap";
            this.chbsoap.Size = new System.Drawing.Size(52, 19);
            this.chbsoap.TabIndex = 1;
            this.chbsoap.Text = "Soap";
            this.chbsoap.UseVisualStyleBackColor = true;
            // 
            // chbshampoo
            // 
            this.chbshampoo.AutoSize = true;
            this.chbshampoo.Location = new System.Drawing.Point(17, 26);
            this.chbshampoo.Name = "chbshampoo";
            this.chbshampoo.Size = new System.Drawing.Size(77, 19);
            this.chbshampoo.TabIndex = 0;
            this.chbshampoo.Text = "Shampoo";
            this.chbshampoo.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(369, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disableToolStripMenuItem,
            this.clearOrderToolStripMenuItem});
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
            // clearOrderToolStripMenuItem
            // 
            this.clearOrderToolStripMenuItem.Name = "clearOrderToolStripMenuItem";
            this.clearOrderToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.clearOrderToolStripMenuItem.Text = "Exit";
            this.clearOrderToolStripMenuItem.Click += new System.EventHandler(this.clearOrderToolStripMenuItem_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(126, 230);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(108, 49);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // frmCleaning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(369, 340);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.cmbQuantity);
            this.Controls.Add(this.grbthelist);
            this.Name = "frmCleaning";
            this.Text = " Cleaning Materials";
            this.grbthelist.ResumeLayout(false);
            this.grbthelist.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cmbQuantity;
        private System.Windows.Forms.GroupBox grbthelist;
        private System.Windows.Forms.CheckBox chbperfumed;
        private System.Windows.Forms.CheckBox chbsoap;
        private System.Windows.Forms.CheckBox chbshampoo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearOrderToolStripMenuItem;
        private System.Windows.Forms.Button btnclear;
    }
}
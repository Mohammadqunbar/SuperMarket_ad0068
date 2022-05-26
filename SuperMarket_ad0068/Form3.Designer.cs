
namespace SuperMarket_ad0068
{
    partial class frmDairy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDairy));
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbQuantity = new System.Windows.Forms.ComboBox();
            this.grbthelist = new System.Windows.Forms.GroupBox();
            this.chbcheese = new System.Windows.Forms.CheckBox();
            this.chbyogurt = new System.Windows.Forms.CheckBox();
            this.chbmilk = new System.Windows.Forms.CheckBox();
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
            this.lblQuantity.Location = new System.Drawing.Point(223, 66);
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
            this.cmbQuantity.Location = new System.Drawing.Point(233, 87);
            this.cmbQuantity.Name = "cmbQuantity";
            this.cmbQuantity.Size = new System.Drawing.Size(43, 23);
            this.cmbQuantity.TabIndex = 6;
            // 
            // grbthelist
            // 
            this.grbthelist.Controls.Add(this.chbcheese);
            this.grbthelist.Controls.Add(this.chbyogurt);
            this.grbthelist.Controls.Add(this.chbmilk);
            this.grbthelist.Location = new System.Drawing.Point(20, 40);
            this.grbthelist.Name = "grbthelist";
            this.grbthelist.Size = new System.Drawing.Size(126, 137);
            this.grbthelist.TabIndex = 5;
            this.grbthelist.TabStop = false;
            this.grbthelist.Text = "The List";
            // 
            // chbcheese
            // 
            this.chbcheese.AutoSize = true;
            this.chbcheese.Location = new System.Drawing.Point(17, 76);
            this.chbcheese.Name = "chbcheese";
            this.chbcheese.Size = new System.Drawing.Size(64, 19);
            this.chbcheese.TabIndex = 2;
            this.chbcheese.Text = "Cheese";
            this.chbcheese.UseVisualStyleBackColor = true;
            // 
            // chbyogurt
            // 
            this.chbyogurt.AutoSize = true;
            this.chbyogurt.Location = new System.Drawing.Point(17, 51);
            this.chbyogurt.Name = "chbyogurt";
            this.chbyogurt.Size = new System.Drawing.Size(61, 19);
            this.chbyogurt.TabIndex = 1;
            this.chbyogurt.Text = "Yogurt";
            this.chbyogurt.UseVisualStyleBackColor = true;
            // 
            // chbmilk
            // 
            this.chbmilk.AutoSize = true;
            this.chbmilk.Location = new System.Drawing.Point(17, 26);
            this.chbmilk.Name = "chbmilk";
            this.chbmilk.Size = new System.Drawing.Size(49, 19);
            this.chbmilk.TabIndex = 0;
            this.chbmilk.Text = "Milk";
            this.chbmilk.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(326, 25);
            this.toolStrip1.TabIndex = 11;
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
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disableToolStripMenuItem.Text = "Display Order";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // clearOrderToolStripMenuItem
            // 
            this.clearOrderToolStripMenuItem.Name = "clearOrderToolStripMenuItem";
            this.clearOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearOrderToolStripMenuItem.Text = "Exit";
            this.clearOrderToolStripMenuItem.Click += new System.EventHandler(this.clearOrderToolStripMenuItem_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(110, 215);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(108, 49);
            this.btnclear.TabIndex = 12;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // frmDairy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(326, 313);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.cmbQuantity);
            this.Controls.Add(this.grbthelist);
            this.Name = "frmDairy";
            this.Text = "Dairy Products";
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
        private System.Windows.Forms.CheckBox chbcheese;
        private System.Windows.Forms.CheckBox chbyogurt;
        private System.Windows.Forms.CheckBox chbmilk;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearOrderToolStripMenuItem;
        private System.Windows.Forms.Button btnclear;
    }
}
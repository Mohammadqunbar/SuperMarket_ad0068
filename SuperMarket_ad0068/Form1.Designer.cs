
namespace SuperMarket_ad0068
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
            this.grbthelist = new System.Windows.Forms.GroupBox();
            this.chbcannedfood = new System.Windows.Forms.CheckBox();
            this.chbSpices = new System.Windows.Forms.CheckBox();
            this.chbnoodles = new System.Windows.Forms.CheckBox();
            this.chbrice = new System.Windows.Forms.CheckBox();
            this.cmbQuantity = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbthelist.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbthelist
            // 
            this.grbthelist.Controls.Add(this.chbcannedfood);
            this.grbthelist.Controls.Add(this.chbSpices);
            this.grbthelist.Controls.Add(this.chbnoodles);
            this.grbthelist.Controls.Add(this.chbrice);
            this.grbthelist.Location = new System.Drawing.Point(12, 38);
            this.grbthelist.Name = "grbthelist";
            this.grbthelist.Size = new System.Drawing.Size(126, 137);
            this.grbthelist.TabIndex = 0;
            this.grbthelist.TabStop = false;
            this.grbthelist.Text = "The List";
            // 
            // chbcannedfood
            // 
            this.chbcannedfood.AutoSize = true;
            this.chbcannedfood.Location = new System.Drawing.Point(17, 101);
            this.chbcannedfood.Name = "chbcannedfood";
            this.chbcannedfood.Size = new System.Drawing.Size(97, 19);
            this.chbcannedfood.TabIndex = 3;
            this.chbcannedfood.Text = "Canned Food";
            this.chbcannedfood.UseVisualStyleBackColor = true;
            // 
            // chbSpices
            // 
            this.chbSpices.AutoSize = true;
            this.chbSpices.Location = new System.Drawing.Point(17, 76);
            this.chbSpices.Name = "chbSpices";
            this.chbSpices.Size = new System.Drawing.Size(59, 19);
            this.chbSpices.TabIndex = 2;
            this.chbSpices.Text = "Spices";
            this.chbSpices.UseVisualStyleBackColor = true;
            // 
            // chbnoodles
            // 
            this.chbnoodles.AutoSize = true;
            this.chbnoodles.Location = new System.Drawing.Point(17, 51);
            this.chbnoodles.Name = "chbnoodles";
            this.chbnoodles.Size = new System.Drawing.Size(70, 19);
            this.chbnoodles.TabIndex = 1;
            this.chbnoodles.Text = "Noodles";
            this.chbnoodles.UseVisualStyleBackColor = true;
            // 
            // chbrice
            // 
            this.chbrice.AutoSize = true;
            this.chbrice.Location = new System.Drawing.Point(17, 26);
            this.chbrice.Name = "chbrice";
            this.chbrice.Size = new System.Drawing.Size(48, 19);
            this.chbrice.TabIndex = 0;
            this.chbrice.Text = "Rice";
            this.chbrice.UseVisualStyleBackColor = true;
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
            this.cmbQuantity.Location = new System.Drawing.Point(225, 59);
            this.cmbQuantity.Name = "cmbQuantity";
            this.cmbQuantity.Size = new System.Drawing.Size(43, 23);
            this.cmbQuantity.TabIndex = 1;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(215, 38);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(53, 15);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(182, 189);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(117, 54);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(332, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disableToolStripMenuItem,
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
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disableToolStripMenuItem.Text = "Display Order";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.clearOrderToolStripMenuItem_Click);
            // 
            // frmCooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(332, 321);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.cmbQuantity);
            this.Controls.Add(this.grbthelist);
            this.Name = "frmCooking";
            this.Text = "Cooking and Baking";
            this.grbthelist.ResumeLayout(false);
            this.grbthelist.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbthelist;
        private System.Windows.Forms.CheckBox chbcannedfood;
        private System.Windows.Forms.CheckBox chbSpices;
        private System.Windows.Forms.CheckBox chbnoodles;
        private System.Windows.Forms.CheckBox chbrice;
        private System.Windows.Forms.ComboBox cmbQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}
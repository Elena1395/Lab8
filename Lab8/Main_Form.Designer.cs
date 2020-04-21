namespace Lab8
{
    partial class Form_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.byFlightNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byDestinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byTotalWeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLuggageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteByNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllToolStripMenuItem,
            this.filterToolStripMenuItem1});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.filterToolStripMenuItem.Text = "Show";
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showAllToolStripMenuItem.Text = "Show all";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem1
            // 
            this.filterToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byFlightNumberToolStripMenuItem,
            this.byDateToolStripMenuItem,
            this.byDestinationToolStripMenuItem,
            this.byTotalWeightToolStripMenuItem});
            this.filterToolStripMenuItem1.Name = "filterToolStripMenuItem1";
            this.filterToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.filterToolStripMenuItem1.Text = "Filter";
            // 
            // byFlightNumberToolStripMenuItem
            // 
            this.byFlightNumberToolStripMenuItem.Name = "byFlightNumberToolStripMenuItem";
            this.byFlightNumberToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.byFlightNumberToolStripMenuItem.Text = "by flight number";
            this.byFlightNumberToolStripMenuItem.Click += new System.EventHandler(this.byFlightNumberToolStripMenuItem_Click);
            // 
            // byDateToolStripMenuItem
            // 
            this.byDateToolStripMenuItem.Name = "byDateToolStripMenuItem";
            this.byDateToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.byDateToolStripMenuItem.Text = "by date";
            this.byDateToolStripMenuItem.Click += new System.EventHandler(this.byDateToolStripMenuItem_Click);
            // 
            // byDestinationToolStripMenuItem
            // 
            this.byDestinationToolStripMenuItem.Name = "byDestinationToolStripMenuItem";
            this.byDestinationToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.byDestinationToolStripMenuItem.Text = "by destination";
            this.byDestinationToolStripMenuItem.Click += new System.EventHandler(this.byDestinationToolStripMenuItem_Click);
            // 
            // byTotalWeightToolStripMenuItem
            // 
            this.byTotalWeightToolStripMenuItem.Name = "byTotalWeightToolStripMenuItem";
            this.byTotalWeightToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.byTotalWeightToolStripMenuItem.Text = "by total weight";
            this.byTotalWeightToolStripMenuItem.Click += new System.EventHandler(this.byTotalWeightToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLuggageToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // addLuggageToolStripMenuItem
            // 
            this.addLuggageToolStripMenuItem.Name = "addLuggageToolStripMenuItem";
            this.addLuggageToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.addLuggageToolStripMenuItem.Text = "Add luggage";
            this.addLuggageToolStripMenuItem.Click += new System.EventHandler(this.addLuggageToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteByNumberToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // deleteByNumberToolStripMenuItem
            // 
            this.deleteByNumberToolStripMenuItem.Name = "deleteByNumberToolStripMenuItem";
            this.deleteByNumberToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.deleteByNumberToolStripMenuItem.Text = "Delete by number";
            this.deleteByNumberToolStripMenuItem.Click += new System.EventHandler(this.deleteByNumberToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(684, 350);
            this.textBox1.TabIndex = 1;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 374);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 365);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luggage information";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem byFlightNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLuggageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteByNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byDestinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byTotalWeightToolStripMenuItem;
        public System.Windows.Forms.TextBox textBox1;
    }
}


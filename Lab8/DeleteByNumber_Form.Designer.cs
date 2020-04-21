namespace Lab8
{
    partial class DeleteByNumber_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_LuggageNumber = new System.Windows.Forms.TextBox();
            this.DeleteByNumber_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the luggage number";
            // 
            // textBox_LuggageNumber
            // 
            this.textBox_LuggageNumber.Location = new System.Drawing.Point(16, 43);
            this.textBox_LuggageNumber.Name = "textBox_LuggageNumber";
            this.textBox_LuggageNumber.Size = new System.Drawing.Size(185, 20);
            this.textBox_LuggageNumber.TabIndex = 1;
            // 
            // DeleteByNumber_button
            // 
            this.DeleteByNumber_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DeleteByNumber_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteByNumber_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteByNumber_button.Location = new System.Drawing.Point(126, 71);
            this.DeleteByNumber_button.Name = "DeleteByNumber_button";
            this.DeleteByNumber_button.Size = new System.Drawing.Size(75, 23);
            this.DeleteByNumber_button.TabIndex = 2;
            this.DeleteByNumber_button.Text = "Delete";
            this.DeleteByNumber_button.UseVisualStyleBackColor = false;
            this.DeleteByNumber_button.Click += new System.EventHandler(this.DeleteByNumber_button_Click);
            // 
            // DeleteByNumber_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 106);
            this.Controls.Add(this.DeleteByNumber_button);
            this.Controls.Add(this.textBox_LuggageNumber);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteByNumber_Form";
            this.Text = "Delete by number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_LuggageNumber;
        private System.Windows.Forms.Button DeleteByNumber_button;
    }
}
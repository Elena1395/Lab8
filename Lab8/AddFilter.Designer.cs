namespace Lab8
{
    partial class AddFilter_Form
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
            this.AddFiler_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Filter = new System.Windows.Forms.TextBox();
            this.textBox_FilterComment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddFiler_button
            // 
            this.AddFiler_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFiler_button.Location = new System.Drawing.Point(130, 95);
            this.AddFiler_button.Name = "AddFiler_button";
            this.AddFiler_button.Size = new System.Drawing.Size(75, 23);
            this.AddFiler_button.TabIndex = 0;
            this.AddFiler_button.Text = "Set filter";
            this.AddFiler_button.UseVisualStyleBackColor = true;
            this.AddFiler_button.Click += new System.EventHandler(this.AddFiler_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // textBox_Filter
            // 
            this.textBox_Filter.Location = new System.Drawing.Point(16, 69);
            this.textBox_Filter.Name = "textBox_Filter";
            this.textBox_Filter.Size = new System.Drawing.Size(189, 20);
            this.textBox_Filter.TabIndex = 1;
            // 
            // textBox_FilterComment
            // 
            this.textBox_FilterComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_FilterComment.Location = new System.Drawing.Point(16, 12);
            this.textBox_FilterComment.Multiline = true;
            this.textBox_FilterComment.Name = "textBox_FilterComment";
            this.textBox_FilterComment.ReadOnly = true;
            this.textBox_FilterComment.Size = new System.Drawing.Size(185, 51);
            this.textBox_FilterComment.TabIndex = 2;
            // 
            // AddFilter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 121);
            this.Controls.Add(this.textBox_FilterComment);
            this.Controls.Add(this.textBox_Filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddFiler_button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFilter_Form";
            this.Text = "AddFilter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddFiler_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Filter;
        public System.Windows.Forms.TextBox textBox_FilterComment;
    }
}
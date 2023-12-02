namespace Charity_System
{
    partial class DonatorForm
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
            this.amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.donate = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(358, 218);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(211, 27);
            this.amount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount";
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(358, 159);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(211, 27);
            this.list.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // donate
            // 
            this.donate.Location = new System.Drawing.Point(191, 343);
            this.donate.Name = "donate";
            this.donate.Size = new System.Drawing.Size(147, 36);
            this.donate.TabIndex = 4;
            this.donate.Text = "Donate";
            this.donate.UseVisualStyleBackColor = true;
            this.donate.Click += new System.EventHandler(this.donate_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(416, 343);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(207, 36);
            this.report.TabIndex = 5;
            this.report.Text = "show donation detais";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // DonatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.report);
            this.Controls.Add(this.donate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amount);
            this.Name = "DonatorForm";
            this.Text = "DonatorForm";
            this.Load += new System.EventHandler(this.DonatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button donate;
        private System.Windows.Forms.Button report;
    }
}
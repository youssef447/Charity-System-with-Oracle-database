namespace Charity_System
{
    partial class emp
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
            this.ssn = new System.Windows.Forms.ComboBox();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.empname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.empsal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.empage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ssn
            // 
            this.ssn.FormattingEnabled = true;
            this.ssn.Location = new System.Drawing.Point(295, 46);
            this.ssn.Name = "ssn";
            this.ssn.Size = new System.Drawing.Size(157, 27);
            this.ssn.TabIndex = 0;
            this.ssn.SelectedIndexChanged += new System.EventHandler(this.ssn_SelectedIndexChanged);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(295, 274);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(157, 29);
            this.insert.TabIndex = 1;
            this.insert.Text = "Add emp";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(295, 342);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(157, 29);
            this.update.TabIndex = 2;
            this.update.Text = "Update emp";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(295, 410);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(157, 29);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete emp";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select SSN";
            // 
            // empname
            // 
            this.empname.Location = new System.Drawing.Point(295, 107);
            this.empname.Name = "empname";
            this.empname.Size = new System.Drawing.Size(157, 27);
            this.empname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Emp name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Emp salary";
            // 
            // empsal
            // 
            this.empsal.Location = new System.Drawing.Point(295, 160);
            this.empsal.Name = "empsal";
            this.empsal.Size = new System.Drawing.Size(157, 27);
            this.empsal.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Emp age";
            // 
            // empage
            // 
            this.empage.Location = new System.Drawing.Point(295, 217);
            this.empage.Name = "empage";
            this.empage.Size = new System.Drawing.Size(157, 27);
            this.empage.TabIndex = 9;
            // 
            // emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.empage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.empsal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.empname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.ssn);
            this.Name = "emp";
            this.Text = "emp";
            this.Load += new System.EventHandler(this.emp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ssn;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox empname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox empsal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox empage;
    }
}
namespace Charity_System
{
    partial class managingemp
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.manageEMP = new System.Windows.Forms.Button();
            this.poorfamily = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dcomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // manageEMP
            // 
            this.manageEMP.Location = new System.Drawing.Point(305, 21);
            this.manageEMP.Name = "manageEMP";
            this.manageEMP.Size = new System.Drawing.Size(188, 43);
            this.manageEMP.TabIndex = 0;
            this.manageEMP.Text = "Manage EMP data";
            this.manageEMP.UseVisualStyleBackColor = true;
            this.manageEMP.Click += new System.EventHandler(this.manageEMP_Click);
            // 
            // poorfamily
            // 
            this.poorfamily.Location = new System.Drawing.Point(305, 202);
            this.poorfamily.Name = "poorfamily";
            this.poorfamily.Size = new System.Drawing.Size(188, 43);
            this.poorfamily.TabIndex = 3;
            this.poorfamily.Text = " poor family report";
            this.poorfamily.UseVisualStyleBackColor = true;
            this.poorfamily.Click += new System.EventHandler(this.poorfamily_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Manage family data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "show Donators";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dcomboBox
            // 
            this.dcomboBox.FormattingEnabled = true;
            this.dcomboBox.Location = new System.Drawing.Point(425, 366);
            this.dcomboBox.Name = "dcomboBox";
            this.dcomboBox.Size = new System.Drawing.Size(152, 27);
            this.dcomboBox.TabIndex = 7;
            // 
            // managingemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dcomboBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.poorfamily);
            this.Controls.Add(this.manageEMP);
            this.Name = "managingemp";
            this.Text = "managingemp";
            this.Load += new System.EventHandler(this.managingemp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button manageEMP;
        private System.Windows.Forms.Button poorfamily;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox dcomboBox;
    }
}
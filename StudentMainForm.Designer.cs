namespace Student_Management_System
{
    partial class StudentMainForm
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
            this.ManageStudent_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logout_Button = new System.Windows.Forms.Button();
            this.ID_Card = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main Form";
            // 
            // ManageStudent_Button
            // 
            this.ManageStudent_Button.BackColor = System.Drawing.Color.SteelBlue;
            this.ManageStudent_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageStudent_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageStudent_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageStudent_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManageStudent_Button.Location = new System.Drawing.Point(5, 128);
            this.ManageStudent_Button.Name = "ManageStudent_Button";
            this.ManageStudent_Button.Size = new System.Drawing.Size(211, 40);
            this.ManageStudent_Button.TabIndex = 1;
            this.ManageStudent_Button.Text = "Attendence";
            this.ManageStudent_Button.UseVisualStyleBackColor = false;
            this.ManageStudent_Button.Click += new System.EventHandler(this.ManageStudent_Button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(3, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Test Result";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(3, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Personal Information";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.Logout_Button);
            this.panel1.Controls.Add(this.ManageStudent_Button);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 434);
            this.panel1.TabIndex = 4;
            // 
            // Logout_Button
            // 
            this.Logout_Button.BackColor = System.Drawing.Color.SteelBlue;
            this.Logout_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Logout_Button.Location = new System.Drawing.Point(3, 3);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Size = new System.Drawing.Size(99, 40);
            this.Logout_Button.TabIndex = 4;
            this.Logout_Button.Text = "Logout";
            this.Logout_Button.UseVisualStyleBackColor = false;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Button_Click);
            // 
            // ID_Card
            // 
            this.ID_Card.BackColor = System.Drawing.Color.SteelBlue;
            this.ID_Card.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ID_Card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ID_Card.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Card.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ID_Card.Location = new System.Drawing.Point(689, 100);
            this.ID_Card.Name = "ID_Card";
            this.ID_Card.Size = new System.Drawing.Size(99, 40);
            this.ID_Card.TabIndex = 5;
            this.ID_Card.Text = "ID Card";
            this.ID_Card.UseVisualStyleBackColor = false;
            this.ID_Card.Click += new System.EventHandler(this.ID_Card_Click);
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ID_Card);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentMainForm";
            this.Text = "StudentMainForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ManageStudent_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Logout_Button;
        private System.Windows.Forms.Button ID_Card;
    }
}
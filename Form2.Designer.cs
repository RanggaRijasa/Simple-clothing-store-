﻿namespace ALP_AD
{
    partial class Login
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_guestmode = new System.Windows.Forms.Label();
            this.lbl_signup = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.lbl_guestmode);
            this.panel2.Controls.Add(this.lbl_signup);
            this.panel2.Controls.Add(this.btn_login);
            this.panel2.Controls.Add(this.tb_pass);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tb_username);
            this.panel2.Location = new System.Drawing.Point(217, 97);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 387);
            this.panel2.TabIndex = 2;
            // 
            // lbl_guestmode
            // 
            this.lbl_guestmode.AutoSize = true;
            this.lbl_guestmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guestmode.Location = new System.Drawing.Point(132, 324);
            this.lbl_guestmode.Name = "lbl_guestmode";
            this.lbl_guestmode.Size = new System.Drawing.Size(90, 18);
            this.lbl_guestmode.TabIndex = 7;
            this.lbl_guestmode.Text = "Guest mode";
            this.lbl_guestmode.Click += new System.EventHandler(this.lbl_guestmode_Click);
            // 
            // lbl_signup
            // 
            this.lbl_signup.AutoSize = true;
            this.lbl_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signup.ForeColor = System.Drawing.Color.Black;
            this.lbl_signup.Location = new System.Drawing.Point(148, 298);
            this.lbl_signup.Name = "lbl_signup";
            this.lbl_signup.Size = new System.Drawing.Size(57, 18);
            this.lbl_signup.TabIndex = 6;
            this.lbl_signup.Text = "Sign up";
            this.lbl_signup.Click += new System.EventHandler(this.lbl_signup_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.Location = new System.Drawing.Point(102, 227);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(151, 46);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(20, 151);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_pass.Multiline = true;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(312, 29);
            this.tb_pass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username / E-Maill :";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(20, 65);
            this.tb_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_username.Multiline = true;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(312, 29);
            this.tb_username.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(799, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Location = new System.Drawing.Point(350, 100);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Clothing Store";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_guestmode;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_username;
        public System.Windows.Forms.Label lbl_signup;
    }
}
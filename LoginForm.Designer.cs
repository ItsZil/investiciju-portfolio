namespace investiciju_portfolio
{
    partial class LoginForm
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
            this.LoginForm_LoginButton = new System.Windows.Forms.Button();
            this.LoginForm_RegisterButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginForm_TurnOffButton = new System.Windows.Forms.Button();
            this.Logo_TextBox = new System.Windows.Forms.PictureBox();
            this.LoginForm_UsernameTextBox = new System.Windows.Forms.TextBox();
            this.LoginForm_PasswordTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_TextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(500, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "Investicijų portfolio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginForm_LoginButton
            // 
            this.LoginForm_LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(67)))));
            this.LoginForm_LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            this.LoginForm_LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginForm_LoginButton.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginForm_LoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            this.LoginForm_LoginButton.Location = new System.Drawing.Point(507, 326);
            this.LoginForm_LoginButton.Name = "LoginForm_LoginButton";
            this.LoginForm_LoginButton.Size = new System.Drawing.Size(140, 44);
            this.LoginForm_LoginButton.TabIndex = 2;
            this.LoginForm_LoginButton.Text = "Log in";
            this.LoginForm_LoginButton.UseVisualStyleBackColor = false;
            this.LoginForm_LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm_RegisterButton
            // 
            this.LoginForm_RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(67)))));
            this.LoginForm_RegisterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            this.LoginForm_RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginForm_RegisterButton.Font = new System.Drawing.Font("Verdana", 14F);
            this.LoginForm_RegisterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            this.LoginForm_RegisterButton.Location = new System.Drawing.Point(752, 326);
            this.LoginForm_RegisterButton.Name = "LoginForm_RegisterButton";
            this.LoginForm_RegisterButton.Size = new System.Drawing.Size(140, 44);
            this.LoginForm_RegisterButton.TabIndex = 3;
            this.LoginForm_RegisterButton.Text = "Register";
            this.LoginForm_RegisterButton.UseVisualStyleBackColor = false;
            this.LoginForm_RegisterButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.LoginForm_TurnOffButton);
            this.panel1.Controls.Add(this.Logo_TextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 77);
            this.panel1.TabIndex = 4;
            // 
            // LoginForm_TurnOffButton
            // 
            this.LoginForm_TurnOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginForm_TurnOffButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(67)))));
            this.LoginForm_TurnOffButton.Image = global::investiciju_portfolio.Properties.Resources.off_button20px;
            this.LoginForm_TurnOffButton.Location = new System.Drawing.Point(1342, 0);
            this.LoginForm_TurnOffButton.Name = "LoginForm_TurnOffButton";
            this.LoginForm_TurnOffButton.Size = new System.Drawing.Size(40, 40);
            this.LoginForm_TurnOffButton.TabIndex = 3;
            this.LoginForm_TurnOffButton.UseVisualStyleBackColor = true;
            this.LoginForm_TurnOffButton.Click += new System.EventHandler(this.LoginForm_TurnOffButton_Click);
            // 
            // Logo_TextBox
            // 
            this.Logo_TextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logo_TextBox.Image = global::investiciju_portfolio.Properties.Resources.logo77px;
            this.Logo_TextBox.Location = new System.Drawing.Point(0, 0);
            this.Logo_TextBox.Name = "Logo_TextBox";
            this.Logo_TextBox.Size = new System.Drawing.Size(77, 77);
            this.Logo_TextBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo_TextBox.TabIndex = 2;
            this.Logo_TextBox.TabStop = false;
            // 
            // LoginForm_UsernameTextBox
            // 
            this.LoginForm_UsernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(67)))));
            this.LoginForm_UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginForm_UsernameTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginForm_UsernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            this.LoginForm_UsernameTextBox.Location = new System.Drawing.Point(507, 183);
            this.LoginForm_UsernameTextBox.MaxLength = 64;
            this.LoginForm_UsernameTextBox.Name = "LoginForm_UsernameTextBox";
            this.LoginForm_UsernameTextBox.Size = new System.Drawing.Size(385, 25);
            this.LoginForm_UsernameTextBox.TabIndex = 12;
            this.LoginForm_UsernameTextBox.Text = "Username";
            this.LoginForm_UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginForm_PasswordTextBox
            // 
            this.LoginForm_PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(67)))));
            this.LoginForm_PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginForm_PasswordTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginForm_PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            this.LoginForm_PasswordTextBox.Location = new System.Drawing.Point(507, 241);
            this.LoginForm_PasswordTextBox.MaxLength = 256;
            this.LoginForm_PasswordTextBox.Name = "LoginForm_PasswordTextBox";
            this.LoginForm_PasswordTextBox.PasswordChar = '*';
            this.LoginForm_PasswordTextBox.Size = new System.Drawing.Size(385, 25);
            this.LoginForm_PasswordTextBox.TabIndex = 13;
            this.LoginForm_PasswordTextBox.Text = "Password";
            this.LoginForm_PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1382, 593);
            this.Controls.Add(this.LoginForm_PasswordTextBox);
            this.Controls.Add(this.LoginForm_UsernameTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginForm_RegisterButton);
            this.Controls.Add(this.LoginForm_LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_TextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginForm_LoginButton;
        private System.Windows.Forms.Button LoginForm_RegisterButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox LoginForm_UsernameTextBox;
        private System.Windows.Forms.TextBox LoginForm_PasswordTextBox;
        private System.Windows.Forms.PictureBox Logo_TextBox;
        private System.Windows.Forms.Button LoginForm_TurnOffButton;
    }
}


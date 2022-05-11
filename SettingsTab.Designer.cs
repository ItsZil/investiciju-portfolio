
namespace investiciju_portfolio
{
    partial class SettingsTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.SettingsTab_SettingsLabel = new System.Windows.Forms.Label();
            this.ChangePWPanel = new System.Windows.Forms.Panel();
            this.SettingsTab_SavePWButton = new System.Windows.Forms.Button();
            this.SettingsTab_ConfirmNewPWTextBox = new investiciju_portfolio.Classes.WatermarkTextBox();
            this.SettingsTab_NewPWTextBox = new investiciju_portfolio.Classes.WatermarkTextBox();
            this.SettingsTab_OldPWTextBox = new investiciju_portfolio.Classes.WatermarkTextBox();
            this.AccountDetailsPanel = new System.Windows.Forms.Panel();
            this.SettingsTab_SurnameDisplayLabel = new System.Windows.Forms.Label();
            this.SettingsTab_NameDisplayLabel = new System.Windows.Forms.Label();
            this.SettingsTab_SurnameLabel = new System.Windows.Forms.Label();
            this.SettingsTab_UsernameDisplayLabel = new System.Windows.Forms.Label();
            this.SettingsTab_NameLabel = new System.Windows.Forms.Label();
            this.SettingsTab_UsernameLabel = new System.Windows.Forms.Label();
            this.SettingsTab_AccountDetailsLabel = new System.Windows.Forms.Label();
            this.SettingsTab_ChangePWLabel = new System.Windows.Forms.Label();
            this.ChangeCurrencyPanel = new System.Windows.Forms.Panel();
            this.SettingsTab_SaveCurrencyButton = new System.Windows.Forms.Button();
            this.SettingsTab_ChangeBaseCurrencyLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SettingsTab_CurrencySelectionBox = new investiciju_portfolio.Classes.FlatCombo();
            this.HeaderPanel.SuspendLayout();
            this.ChangePWPanel.SuspendLayout();
            this.AccountDetailsPanel.SuspendLayout();
            this.ChangeCurrencyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.SettingsTab_SettingsLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1382, 66);
            this.HeaderPanel.TabIndex = 0;
            // 
            // SettingsTab_SettingsLabel
            // 
            this.SettingsTab_SettingsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsTab_SettingsLabel.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTab_SettingsLabel.ForeColor = System.Drawing.Color.White;
            this.SettingsTab_SettingsLabel.Location = new System.Drawing.Point(0, 0);
            this.SettingsTab_SettingsLabel.Name = "SettingsTab_SettingsLabel";
            this.SettingsTab_SettingsLabel.Size = new System.Drawing.Size(1382, 66);
            this.SettingsTab_SettingsLabel.TabIndex = 0;
            this.SettingsTab_SettingsLabel.Text = "Settings";
            this.SettingsTab_SettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangePWPanel
            // 
            this.ChangePWPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.ChangePWPanel.Controls.Add(this.SettingsTab_SavePWButton);
            this.ChangePWPanel.Controls.Add(this.SettingsTab_ConfirmNewPWTextBox);
            this.ChangePWPanel.Controls.Add(this.SettingsTab_NewPWTextBox);
            this.ChangePWPanel.Controls.Add(this.SettingsTab_OldPWTextBox);
            this.ChangePWPanel.Location = new System.Drawing.Point(716, 100);
            this.ChangePWPanel.Name = "ChangePWPanel";
            this.ChangePWPanel.Size = new System.Drawing.Size(616, 270);
            this.ChangePWPanel.TabIndex = 1;
            // 
            // SettingsTab_SavePWButton
            // 
            this.SettingsTab_SavePWButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsTab_SavePWButton.AutoSize = true;
            this.SettingsTab_SavePWButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(67)))));
            this.SettingsTab_SavePWButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsTab_SavePWButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            this.SettingsTab_SavePWButton.Location = new System.Drawing.Point(442, 222);
            this.SettingsTab_SavePWButton.Name = "SettingsTab_SavePWButton";
            this.SettingsTab_SavePWButton.Size = new System.Drawing.Size(138, 30);
            this.SettingsTab_SavePWButton.TabIndex = 14;
            this.SettingsTab_SavePWButton.Text = "Save ";
            this.SettingsTab_SavePWButton.UseVisualStyleBackColor = false;
            // 
            // SettingsTab_ConfirmNewPWTextBox
            // 
            this.SettingsTab_ConfirmNewPWTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(67)))));
            this.SettingsTab_ConfirmNewPWTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SettingsTab_ConfirmNewPWTextBox.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTab_ConfirmNewPWTextBox.Hint = "Confirm new password";
            this.SettingsTab_ConfirmNewPWTextBox.Location = new System.Drawing.Point(36, 168);
            this.SettingsTab_ConfirmNewPWTextBox.MaxLength = 256;
            this.SettingsTab_ConfirmNewPWTextBox.Name = "SettingsTab_ConfirmNewPWTextBox";
            this.SettingsTab_ConfirmNewPWTextBox.PasswordChar = '*';
            this.SettingsTab_ConfirmNewPWTextBox.Size = new System.Drawing.Size(544, 33);
            this.SettingsTab_ConfirmNewPWTextBox.TabIndex = 13;
            this.SettingsTab_ConfirmNewPWTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SettingsTab_NewPWTextBox
            // 
            this.SettingsTab_NewPWTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(67)))));
            this.SettingsTab_NewPWTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SettingsTab_NewPWTextBox.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTab_NewPWTextBox.Hint = "New password";
            this.SettingsTab_NewPWTextBox.Location = new System.Drawing.Point(36, 108);
            this.SettingsTab_NewPWTextBox.MaxLength = 256;
            this.SettingsTab_NewPWTextBox.Name = "SettingsTab_NewPWTextBox";
            this.SettingsTab_NewPWTextBox.PasswordChar = '*';
            this.SettingsTab_NewPWTextBox.Size = new System.Drawing.Size(544, 33);
            this.SettingsTab_NewPWTextBox.TabIndex = 12;
            this.SettingsTab_NewPWTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SettingsTab_OldPWTextBox
            // 
            this.SettingsTab_OldPWTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(67)))));
            this.SettingsTab_OldPWTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SettingsTab_OldPWTextBox.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTab_OldPWTextBox.Hint = "Old password";
            this.SettingsTab_OldPWTextBox.Location = new System.Drawing.Point(36, 38);
            this.SettingsTab_OldPWTextBox.MaxLength = 256;
            this.SettingsTab_OldPWTextBox.Name = "SettingsTab_OldPWTextBox";
            this.SettingsTab_OldPWTextBox.PasswordChar = '*';
            this.SettingsTab_OldPWTextBox.Size = new System.Drawing.Size(544, 33);
            this.SettingsTab_OldPWTextBox.TabIndex = 11;
            this.SettingsTab_OldPWTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AccountDetailsPanel
            // 
            this.AccountDetailsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.AccountDetailsPanel.Controls.Add(this.SettingsTab_SurnameDisplayLabel);
            this.AccountDetailsPanel.Controls.Add(this.SettingsTab_NameDisplayLabel);
            this.AccountDetailsPanel.Controls.Add(this.SettingsTab_SurnameLabel);
            this.AccountDetailsPanel.Controls.Add(this.SettingsTab_UsernameDisplayLabel);
            this.AccountDetailsPanel.Controls.Add(this.SettingsTab_NameLabel);
            this.AccountDetailsPanel.Controls.Add(this.SettingsTab_UsernameLabel);
            this.AccountDetailsPanel.Location = new System.Drawing.Point(50, 100);
            this.AccountDetailsPanel.Name = "AccountDetailsPanel";
            this.AccountDetailsPanel.Size = new System.Drawing.Size(616, 420);
            this.AccountDetailsPanel.TabIndex = 2;
            // 
            // SettingsTab_SurnameDisplayLabel
            // 
            this.SettingsTab_SurnameDisplayLabel.AutoSize = true;
            this.SettingsTab_SurnameDisplayLabel.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTab_SurnameDisplayLabel.ForeColor = System.Drawing.Color.LightGray;
            this.SettingsTab_SurnameDisplayLabel.Location = new System.Drawing.Point(400, 308);
            this.SettingsTab_SurnameDisplayLabel.Name = "SettingsTab_SurnameDisplayLabel";
            this.SettingsTab_SurnameDisplayLabel.Size = new System.Drawing.Size(139, 34);
            this.SettingsTab_SurnameDisplayLabel.TabIndex = 6;
            this.SettingsTab_SurnameDisplayLabel.Text = "surname";
            // 
            // SettingsTab_NameDisplayLabel
            // 
            this.SettingsTab_NameDisplayLabel.AutoSize = true;
            this.SettingsTab_NameDisplayLabel.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTab_NameDisplayLabel.ForeColor = System.Drawing.Color.LightGray;
            this.SettingsTab_NameDisplayLabel.Location = new System.Drawing.Point(400, 194);
            this.SettingsTab_NameDisplayLabel.Name = "SettingsTab_NameDisplayLabel";
            this.SettingsTab_NameDisplayLabel.Size = new System.Drawing.Size(94, 34);
            this.SettingsTab_NameDisplayLabel.TabIndex = 5;
            this.SettingsTab_NameDisplayLabel.Text = "name";
            // 
            // SettingsTab_SurnameLabel
            // 
            this.SettingsTab_SurnameLabel.AutoSize = true;
            this.SettingsTab_SurnameLabel.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTab_SurnameLabel.ForeColor = System.Drawing.Color.White;
            this.SettingsTab_SurnameLabel.Location = new System.Drawing.Point(36, 308);
            this.SettingsTab_SurnameLabel.Name = "SettingsTab_SurnameLabel";
            this.SettingsTab_SurnameLabel.Size = new System.Drawing.Size(143, 34);
            this.SettingsTab_SurnameLabel.TabIndex = 3;
            this.SettingsTab_SurnameLabel.Text = "Surname";
            // 
            // SettingsTab_UsernameDisplayLabel
            // 
            this.SettingsTab_UsernameDisplayLabel.AutoSize = true;
            this.SettingsTab_UsernameDisplayLabel.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTab_UsernameDisplayLabel.ForeColor = System.Drawing.Color.LightGray;
            this.SettingsTab_UsernameDisplayLabel.Location = new System.Drawing.Point(400, 80);
            this.SettingsTab_UsernameDisplayLabel.Name = "SettingsTab_UsernameDisplayLabel";
            this.SettingsTab_UsernameDisplayLabel.Size = new System.Drawing.Size(156, 34);
            this.SettingsTab_UsernameDisplayLabel.TabIndex = 2;
            this.SettingsTab_UsernameDisplayLabel.Text = "username";
            // 
            // SettingsTab_NameLabel
            // 
            this.SettingsTab_NameLabel.AutoSize = true;
            this.SettingsTab_NameLabel.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTab_NameLabel.ForeColor = System.Drawing.Color.White;
            this.SettingsTab_NameLabel.Location = new System.Drawing.Point(36, 194);
            this.SettingsTab_NameLabel.Name = "SettingsTab_NameLabel";
            this.SettingsTab_NameLabel.Size = new System.Drawing.Size(97, 34);
            this.SettingsTab_NameLabel.TabIndex = 1;
            this.SettingsTab_NameLabel.Text = "Name";
            // 
            // SettingsTab_UsernameLabel
            // 
            this.SettingsTab_UsernameLabel.AutoSize = true;
            this.SettingsTab_UsernameLabel.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTab_UsernameLabel.ForeColor = System.Drawing.Color.White;
            this.SettingsTab_UsernameLabel.Location = new System.Drawing.Point(36, 80);
            this.SettingsTab_UsernameLabel.Name = "SettingsTab_UsernameLabel";
            this.SettingsTab_UsernameLabel.Size = new System.Drawing.Size(159, 34);
            this.SettingsTab_UsernameLabel.TabIndex = 0;
            this.SettingsTab_UsernameLabel.Text = "Username";
            // 
            // SettingsTab_AccountDetailsLabel
            // 
            this.SettingsTab_AccountDetailsLabel.AutoSize = true;
            this.SettingsTab_AccountDetailsLabel.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTab_AccountDetailsLabel.ForeColor = System.Drawing.Color.Silver;
            this.SettingsTab_AccountDetailsLabel.Location = new System.Drawing.Point(50, 69);
            this.SettingsTab_AccountDetailsLabel.Name = "SettingsTab_AccountDetailsLabel";
            this.SettingsTab_AccountDetailsLabel.Size = new System.Drawing.Size(233, 34);
            this.SettingsTab_AccountDetailsLabel.TabIndex = 8;
            this.SettingsTab_AccountDetailsLabel.Text = "Account details";
            // 
            // SettingsTab_ChangePWLabel
            // 
            this.SettingsTab_ChangePWLabel.AutoSize = true;
            this.SettingsTab_ChangePWLabel.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTab_ChangePWLabel.ForeColor = System.Drawing.Color.Silver;
            this.SettingsTab_ChangePWLabel.Location = new System.Drawing.Point(719, 69);
            this.SettingsTab_ChangePWLabel.Name = "SettingsTab_ChangePWLabel";
            this.SettingsTab_ChangePWLabel.Size = new System.Drawing.Size(265, 34);
            this.SettingsTab_ChangePWLabel.TabIndex = 9;
            this.SettingsTab_ChangePWLabel.Text = "Change password";
            // 
            // ChangeCurrencyPanel
            // 
            this.ChangeCurrencyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.ChangeCurrencyPanel.Controls.Add(this.SettingsTab_CurrencySelectionBox);
            this.ChangeCurrencyPanel.Controls.Add(this.SettingsTab_SaveCurrencyButton);
            this.ChangeCurrencyPanel.Location = new System.Drawing.Point(716, 440);
            this.ChangeCurrencyPanel.Name = "ChangeCurrencyPanel";
            this.ChangeCurrencyPanel.Size = new System.Drawing.Size(616, 80);
            this.ChangeCurrencyPanel.TabIndex = 10;
            // 
            // SettingsTab_SaveCurrencyButton
            // 
            this.SettingsTab_SaveCurrencyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsTab_SaveCurrencyButton.AutoSize = true;
            this.SettingsTab_SaveCurrencyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(67)))));
            this.SettingsTab_SaveCurrencyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsTab_SaveCurrencyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            this.SettingsTab_SaveCurrencyButton.Location = new System.Drawing.Point(442, 25);
            this.SettingsTab_SaveCurrencyButton.Name = "SettingsTab_SaveCurrencyButton";
            this.SettingsTab_SaveCurrencyButton.Size = new System.Drawing.Size(138, 30);
            this.SettingsTab_SaveCurrencyButton.TabIndex = 15;
            this.SettingsTab_SaveCurrencyButton.Text = "Save ";
            this.SettingsTab_SaveCurrencyButton.UseVisualStyleBackColor = false;
            // 
            // SettingsTab_ChangeBaseCurrencyLabel
            // 
            this.SettingsTab_ChangeBaseCurrencyLabel.AutoSize = true;
            this.SettingsTab_ChangeBaseCurrencyLabel.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTab_ChangeBaseCurrencyLabel.ForeColor = System.Drawing.Color.Silver;
            this.SettingsTab_ChangeBaseCurrencyLabel.Location = new System.Drawing.Point(716, 403);
            this.SettingsTab_ChangeBaseCurrencyLabel.Name = "SettingsTab_ChangeBaseCurrencyLabel";
            this.SettingsTab_ChangeBaseCurrencyLabel.Size = new System.Drawing.Size(332, 34);
            this.SettingsTab_ChangeBaseCurrencyLabel.TabIndex = 11;
            this.SettingsTab_ChangeBaseCurrencyLabel.Text = "Change base currency";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SettingsTab_CurrencySelectionBox
            // 
            this.SettingsTab_CurrencySelectionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(67)))));
            this.SettingsTab_CurrencySelectionBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(67)))));
            this.SettingsTab_CurrencySelectionBox.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(139)))), ((int)(((byte)(113)))));
            this.SettingsTab_CurrencySelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SettingsTab_CurrencySelectionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsTab_CurrencySelectionBox.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTab_CurrencySelectionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            this.SettingsTab_CurrencySelectionBox.FormattingEnabled = true;
            this.SettingsTab_CurrencySelectionBox.Items.AddRange(new object[] {
            "Euro (€)",
            "British Pound (£)",
            "United States Dollar ($)"});
            this.SettingsTab_CurrencySelectionBox.Location = new System.Drawing.Point(36, 20);
            this.SettingsTab_CurrencySelectionBox.Name = "SettingsTab_CurrencySelectionBox";
            this.SettingsTab_CurrencySelectionBox.Size = new System.Drawing.Size(323, 40);
            this.SettingsTab_CurrencySelectionBox.TabIndex = 16;
            // 
            // SettingsTab
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.SettingsTab_ChangeBaseCurrencyLabel);
            this.Controls.Add(this.ChangeCurrencyPanel);
            this.Controls.Add(this.SettingsTab_ChangePWLabel);
            this.Controls.Add(this.SettingsTab_AccountDetailsLabel);
            this.Controls.Add(this.AccountDetailsPanel);
            this.Controls.Add(this.ChangePWPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SettingsTab";
            this.Size = new System.Drawing.Size(1382, 576);
            this.HeaderPanel.ResumeLayout(false);
            this.ChangePWPanel.ResumeLayout(false);
            this.ChangePWPanel.PerformLayout();
            this.AccountDetailsPanel.ResumeLayout(false);
            this.AccountDetailsPanel.PerformLayout();
            this.ChangeCurrencyPanel.ResumeLayout(false);
            this.ChangeCurrencyPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label SettingsTab_SettingsLabel;
        private System.Windows.Forms.Panel ChangePWPanel;
        private System.Windows.Forms.Panel AccountDetailsPanel;
        private System.Windows.Forms.Label SettingsTab_SurnameDisplayLabel;
        private System.Windows.Forms.Label SettingsTab_NameDisplayLabel;
        private System.Windows.Forms.Label SettingsTab_SurnameLabel;
        private System.Windows.Forms.Label SettingsTab_UsernameDisplayLabel;
        private System.Windows.Forms.Label SettingsTab_NameLabel;
        private System.Windows.Forms.Label SettingsTab_UsernameLabel;
        private System.Windows.Forms.Label SettingsTab_AccountDetailsLabel;
        private Classes.WatermarkTextBox SettingsTab_OldPWTextBox;
        private System.Windows.Forms.Label SettingsTab_ChangePWLabel;
        private Classes.WatermarkTextBox SettingsTab_ConfirmNewPWTextBox;
        private Classes.WatermarkTextBox SettingsTab_NewPWTextBox;
        private System.Windows.Forms.Button SettingsTab_SavePWButton;
        private System.Windows.Forms.Panel ChangeCurrencyPanel;
        private System.Windows.Forms.Label SettingsTab_ChangeBaseCurrencyLabel;
        private System.Windows.Forms.Button SettingsTab_SaveCurrencyButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Classes.FlatCombo SettingsTab_CurrencySelectionBox;
    }
}

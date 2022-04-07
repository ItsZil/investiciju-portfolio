
namespace investiciju_portfolio
{
    partial class HomeWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logo_TextBox = new System.Windows.Forms.PictureBox();
            this.HomeWindowForm_TurnOffButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.overviewTab1 = new investiciju_portfolio.OverviewTab();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_TextBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.Logo_TextBox);
            this.panel1.Controls.Add(this.HomeWindowForm_TurnOffButton);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 77);
            this.panel1.TabIndex = 2;
            // 
            // Logo_TextBox
            // 
            this.Logo_TextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logo_TextBox.Image = global::investiciju_portfolio.Properties.Resources.logo77px;
            this.Logo_TextBox.Location = new System.Drawing.Point(0, 0);
            this.Logo_TextBox.Name = "Logo_TextBox";
            this.Logo_TextBox.Size = new System.Drawing.Size(77, 77);
            this.Logo_TextBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo_TextBox.TabIndex = 7;
            this.Logo_TextBox.TabStop = false;
            // 
            // HomeWindowForm_TurnOffButton
            // 
            this.HomeWindowForm_TurnOffButton.FlatAppearance.BorderSize = 0;
            this.HomeWindowForm_TurnOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeWindowForm_TurnOffButton.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeWindowForm_TurnOffButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(101)))), ((int)(((byte)(67)))));
            this.HomeWindowForm_TurnOffButton.Image = global::investiciju_portfolio.Properties.Resources.off_button20px;
            this.HomeWindowForm_TurnOffButton.Location = new System.Drawing.Point(1342, 0);
            this.HomeWindowForm_TurnOffButton.Name = "HomeWindowForm_TurnOffButton";
            this.HomeWindowForm_TurnOffButton.Size = new System.Drawing.Size(40, 40);
            this.HomeWindowForm_TurnOffButton.TabIndex = 6;
            this.HomeWindowForm_TurnOffButton.UseVisualStyleBackColor = true;
            this.HomeWindowForm_TurnOffButton.Click += new System.EventHandler(this.HomeWindowForm_TurnOffButton_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(211, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 77);
            this.button2.TabIndex = 3;
            this.button2.Text = "Charts";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(73, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 77);
            this.button1.TabIndex = 2;
            this.button1.Text = "Overview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.overviewTab1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1382, 576);
            this.panel2.TabIndex = 3;
            // 
            // overviewTab1
            // 
            this.overviewTab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.overviewTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewTab1.Location = new System.Drawing.Point(0, 0);
            this.overviewTab1.Margin = new System.Windows.Forms.Padding(5);
            this.overviewTab1.Name = "overviewTab1";
            this.overviewTab1.Size = new System.Drawing.Size(1382, 576);
            this.overviewTab1.TabIndex = 0;
            this.overviewTab1.Load += new System.EventHandler(this.overviewTab1_Load);
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HomeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeWindow";
            this.Load += new System.EventHandler(this.HomeWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_TextBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button HomeWindowForm_TurnOffButton;
        private System.Windows.Forms.PictureBox Logo_TextBox;
        private System.Windows.Forms.Panel panel2;
        private OverviewTab overviewTab1;
    }
}

namespace investiciju_portfolio
{
    partial class OverviewTab
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
            this.StockPricePanel = new System.Windows.Forms.Panel();
            this.StockListView = new System.Windows.Forms.ListView();
            this.StockName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StockPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OverviewTab_EquityValueLabel = new System.Windows.Forms.Label();
            this.OverviewTab_EquityLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OverviewTab_HeaderPanel = new System.Windows.Forms.Panel();
            this.OverviewTab_OverviewLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OverviewTab_PNLLabel = new System.Windows.Forms.Label();
            this.OverviewTab_PNLValueLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.OverviewTab_StockCountLabel = new System.Windows.Forms.Label();
            this.OverviewTab_StockCountValueLabel = new System.Windows.Forms.Label();
            this.OverviewTab_CreateButton = new System.Windows.Forms.Button();
            this.OverviewTab_InstrumentButtonsPanel = new System.Windows.Forms.Panel();
            this.OverviewTab_EditButton = new System.Windows.Forms.Button();
            this.OverviewTab_RemoveButton = new System.Windows.Forms.Button();
            this.StockPricePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.OverviewTab_HeaderPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.OverviewTab_InstrumentButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StockPricePanel
            // 
            this.StockPricePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            this.StockPricePanel.Controls.Add(this.StockListView);
            this.StockPricePanel.Location = new System.Drawing.Point(-1, -2);
            this.StockPricePanel.Margin = new System.Windows.Forms.Padding(2);
            this.StockPricePanel.Name = "StockPricePanel";
            this.StockPricePanel.Size = new System.Drawing.Size(310, 547);
            this.StockPricePanel.TabIndex = 0;
            // 
            // StockListView
            // 
            this.StockListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.StockListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StockListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StockName,
            this.StockPrice});
            this.StockListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.StockListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockListView.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.StockListView.HideSelection = false;
            this.StockListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StockListView.Location = new System.Drawing.Point(0, 0);
            this.StockListView.Name = "StockListView";
            this.StockListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StockListView.Size = new System.Drawing.Size(310, 547);
            this.StockListView.TabIndex = 0;
            this.StockListView.TileSize = new System.Drawing.Size(1, 1);
            this.StockListView.UseCompatibleStateImageBehavior = false;
            this.StockListView.View = System.Windows.Forms.View.Details;
            // 
            // StockName
            // 
            this.StockName.Text = "Instrument";
            this.StockName.Width = 155;
            // 
            // StockPrice
            // 
            this.StockPrice.Text = "Last";
            this.StockPrice.Width = 155;
            // 
            // OverviewTab_EquityValueLabel
            // 
            this.OverviewTab_EquityValueLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OverviewTab_EquityValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverviewTab_EquityValueLabel.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverviewTab_EquityValueLabel.ForeColor = System.Drawing.Color.White;
            this.OverviewTab_EquityValueLabel.Location = new System.Drawing.Point(0, 37);
            this.OverviewTab_EquityValueLabel.Name = "OverviewTab_EquityValueLabel";
            this.OverviewTab_EquityValueLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.OverviewTab_EquityValueLabel.Size = new System.Drawing.Size(350, 43);
            this.OverviewTab_EquityValueLabel.TabIndex = 1;
            this.OverviewTab_EquityValueLabel.Text = "€ 1000";
            this.OverviewTab_EquityValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OverviewTab_EquityLabel
            // 
            this.OverviewTab_EquityLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OverviewTab_EquityLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverviewTab_EquityLabel.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverviewTab_EquityLabel.ForeColor = System.Drawing.Color.LightGray;
            this.OverviewTab_EquityLabel.Location = new System.Drawing.Point(0, 0);
            this.OverviewTab_EquityLabel.Name = "OverviewTab_EquityLabel";
            this.OverviewTab_EquityLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.OverviewTab_EquityLabel.Size = new System.Drawing.Size(350, 37);
            this.OverviewTab_EquityLabel.TabIndex = 2;
            this.OverviewTab_EquityLabel.Text = "Equity Value";
            this.OverviewTab_EquityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.OverviewTab_EquityLabel);
            this.panel1.Controls.Add(this.OverviewTab_EquityValueLabel);
            this.panel1.Location = new System.Drawing.Point(315, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 80);
            this.panel1.TabIndex = 3;
            // 
            // OverviewTab_HeaderPanel
            // 
            this.OverviewTab_HeaderPanel.Controls.Add(this.OverviewTab_OverviewLabel);
            this.OverviewTab_HeaderPanel.Location = new System.Drawing.Point(310, 0);
            this.OverviewTab_HeaderPanel.Name = "OverviewTab_HeaderPanel";
            this.OverviewTab_HeaderPanel.Size = new System.Drawing.Size(1072, 52);
            this.OverviewTab_HeaderPanel.TabIndex = 4;
            // 
            // OverviewTab_OverviewLabel
            // 
            this.OverviewTab_OverviewLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OverviewTab_OverviewLabel.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverviewTab_OverviewLabel.ForeColor = System.Drawing.Color.White;
            this.OverviewTab_OverviewLabel.Location = new System.Drawing.Point(0, 0);
            this.OverviewTab_OverviewLabel.Name = "OverviewTab_OverviewLabel";
            this.OverviewTab_OverviewLabel.Size = new System.Drawing.Size(1072, 52);
            this.OverviewTab_OverviewLabel.TabIndex = 0;
            this.OverviewTab_OverviewLabel.Text = "Overview";
            this.OverviewTab_OverviewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.panel3.Controls.Add(this.OverviewTab_PNLLabel);
            this.panel3.Controls.Add(this.OverviewTab_PNLValueLabel);
            this.panel3.Location = new System.Drawing.Point(671, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 80);
            this.panel3.TabIndex = 4;
            // 
            // OverviewTab_PNLLabel
            // 
            this.OverviewTab_PNLLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OverviewTab_PNLLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverviewTab_PNLLabel.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverviewTab_PNLLabel.ForeColor = System.Drawing.Color.LightGray;
            this.OverviewTab_PNLLabel.Location = new System.Drawing.Point(0, 0);
            this.OverviewTab_PNLLabel.Name = "OverviewTab_PNLLabel";
            this.OverviewTab_PNLLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.OverviewTab_PNLLabel.Size = new System.Drawing.Size(350, 37);
            this.OverviewTab_PNLLabel.TabIndex = 2;
            this.OverviewTab_PNLLabel.Text = "Yesterdays PNL";
            this.OverviewTab_PNLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OverviewTab_PNLValueLabel
            // 
            this.OverviewTab_PNLValueLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OverviewTab_PNLValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverviewTab_PNLValueLabel.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverviewTab_PNLValueLabel.ForeColor = System.Drawing.Color.White;
            this.OverviewTab_PNLValueLabel.Location = new System.Drawing.Point(0, 37);
            this.OverviewTab_PNLValueLabel.Name = "OverviewTab_PNLValueLabel";
            this.OverviewTab_PNLValueLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.OverviewTab_PNLValueLabel.Size = new System.Drawing.Size(350, 43);
            this.OverviewTab_PNLValueLabel.TabIndex = 1;
            this.OverviewTab_PNLValueLabel.Text = "+-5%";
            this.OverviewTab_PNLValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.panel4.Controls.Add(this.OverviewTab_StockCountLabel);
            this.panel4.Controls.Add(this.OverviewTab_StockCountValueLabel);
            this.panel4.Location = new System.Drawing.Point(1027, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 80);
            this.panel4.TabIndex = 4;
            // 
            // OverviewTab_StockCountLabel
            // 
            this.OverviewTab_StockCountLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OverviewTab_StockCountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverviewTab_StockCountLabel.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverviewTab_StockCountLabel.ForeColor = System.Drawing.Color.LightGray;
            this.OverviewTab_StockCountLabel.Location = new System.Drawing.Point(0, 0);
            this.OverviewTab_StockCountLabel.Name = "OverviewTab_StockCountLabel";
            this.OverviewTab_StockCountLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.OverviewTab_StockCountLabel.Size = new System.Drawing.Size(350, 37);
            this.OverviewTab_StockCountLabel.TabIndex = 2;
            this.OverviewTab_StockCountLabel.Text = "Total Stock Count";
            this.OverviewTab_StockCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OverviewTab_StockCountValueLabel
            // 
            this.OverviewTab_StockCountValueLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OverviewTab_StockCountValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverviewTab_StockCountValueLabel.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverviewTab_StockCountValueLabel.ForeColor = System.Drawing.Color.White;
            this.OverviewTab_StockCountValueLabel.Location = new System.Drawing.Point(0, 37);
            this.OverviewTab_StockCountValueLabel.Name = "OverviewTab_StockCountValueLabel";
            this.OverviewTab_StockCountValueLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.OverviewTab_StockCountValueLabel.Size = new System.Drawing.Size(350, 43);
            this.OverviewTab_StockCountValueLabel.TabIndex = 1;
            this.OverviewTab_StockCountValueLabel.Text = "5";
            this.OverviewTab_StockCountValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OverviewTab_CreateButton
            // 
            this.OverviewTab_CreateButton.FlatAppearance.BorderSize = 0;
            this.OverviewTab_CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverviewTab_CreateButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverviewTab_CreateButton.ForeColor = System.Drawing.Color.White;
            this.OverviewTab_CreateButton.Location = new System.Drawing.Point(0, 0);
            this.OverviewTab_CreateButton.Name = "OverviewTab_CreateButton";
            this.OverviewTab_CreateButton.Size = new System.Drawing.Size(90, 30);
            this.OverviewTab_CreateButton.TabIndex = 5;
            this.OverviewTab_CreateButton.Text = "Create";
            this.OverviewTab_CreateButton.UseVisualStyleBackColor = true;
            // 
            // OverviewTab_InstrumentButtonsPanel
            // 
            this.OverviewTab_InstrumentButtonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.OverviewTab_InstrumentButtonsPanel.Controls.Add(this.OverviewTab_RemoveButton);
            this.OverviewTab_InstrumentButtonsPanel.Controls.Add(this.OverviewTab_CreateButton);
            this.OverviewTab_InstrumentButtonsPanel.Controls.Add(this.OverviewTab_EditButton);
            this.OverviewTab_InstrumentButtonsPanel.Location = new System.Drawing.Point(0, 547);
            this.OverviewTab_InstrumentButtonsPanel.Name = "OverviewTab_InstrumentButtonsPanel";
            this.OverviewTab_InstrumentButtonsPanel.Size = new System.Drawing.Size(310, 30);
            this.OverviewTab_InstrumentButtonsPanel.TabIndex = 6;
            // 
            // OverviewTab_EditButton
            // 
            this.OverviewTab_EditButton.FlatAppearance.BorderSize = 0;
            this.OverviewTab_EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverviewTab_EditButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverviewTab_EditButton.ForeColor = System.Drawing.Color.White;
            this.OverviewTab_EditButton.Location = new System.Drawing.Point(110, 0);
            this.OverviewTab_EditButton.Name = "OverviewTab_EditButton";
            this.OverviewTab_EditButton.Size = new System.Drawing.Size(90, 30);
            this.OverviewTab_EditButton.TabIndex = 7;
            this.OverviewTab_EditButton.Text = "Edit";
            this.OverviewTab_EditButton.UseVisualStyleBackColor = true;
            // 
            // OverviewTab_RemoveButton
            // 
            this.OverviewTab_RemoveButton.FlatAppearance.BorderSize = 0;
            this.OverviewTab_RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverviewTab_RemoveButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverviewTab_RemoveButton.ForeColor = System.Drawing.Color.White;
            this.OverviewTab_RemoveButton.Location = new System.Drawing.Point(220, 0);
            this.OverviewTab_RemoveButton.Name = "OverviewTab_RemoveButton";
            this.OverviewTab_RemoveButton.Size = new System.Drawing.Size(90, 30);
            this.OverviewTab_RemoveButton.TabIndex = 8;
            this.OverviewTab_RemoveButton.Text = "Remove";
            this.OverviewTab_RemoveButton.UseVisualStyleBackColor = true;
            // 
            // OverviewTab
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.OverviewTab_InstrumentButtonsPanel);
            this.Controls.Add(this.StockPricePanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.OverviewTab_HeaderPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OverviewTab";
            this.Size = new System.Drawing.Size(1382, 576);
            this.Load += new System.EventHandler(this.OverviewTab_Load);
            this.StockPricePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.OverviewTab_HeaderPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.OverviewTab_InstrumentButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StockPricePanel;
        private System.Windows.Forms.Label OverviewTab_EquityValueLabel;
        private System.Windows.Forms.Label OverviewTab_EquityLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel OverviewTab_HeaderPanel;
        private System.Windows.Forms.Label OverviewTab_OverviewLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label OverviewTab_PNLLabel;
        private System.Windows.Forms.Label OverviewTab_PNLValueLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label OverviewTab_StockCountLabel;
        private System.Windows.Forms.Label OverviewTab_StockCountValueLabel;
        private System.Windows.Forms.ColumnHeader StockName;
        private System.Windows.Forms.ColumnHeader StockPrice;
        private System.Windows.Forms.ListView StockListView;
        private System.Windows.Forms.Button OverviewTab_CreateButton;
        private System.Windows.Forms.Panel OverviewTab_InstrumentButtonsPanel;
        private System.Windows.Forms.Button OverviewTab_RemoveButton;
        private System.Windows.Forms.Button OverviewTab_EditButton;
    }
}

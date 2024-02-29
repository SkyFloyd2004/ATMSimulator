namespace ATMSimulator
{
    partial class ATMMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATMMenu));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.availableCashTabPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.availableCashLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.recentTransactionsTabPage = new System.Windows.Forms.TabPage();
            this.transactionListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.withdrawalTabPage = new System.Windows.Forms.TabPage();
            this.withdrawalButton = new System.Windows.Forms.Button();
            this.withdrawalCashTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.errorProviderWithdrawal = new System.Windows.Forms.ErrorProvider(this.components);
            this.exitTabPage = new System.Windows.Forms.TabPage();
            this.exitButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.availableCashTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.recentTransactionsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.withdrawalTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWithdrawal)).BeginInit();
            this.exitTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.availableCashTabPage);
            this.tabControl1.Controls.Add(this.recentTransactionsTabPage);
            this.tabControl1.Controls.Add(this.withdrawalTabPage);
            this.tabControl1.Controls.Add(this.exitTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 359);
            this.tabControl1.TabIndex = 0;
            // 
            // availableCashTabPage
            // 
            this.availableCashTabPage.BackColor = System.Drawing.Color.MidnightBlue;
            this.availableCashTabPage.Controls.Add(this.pictureBox1);
            this.availableCashTabPage.Controls.Add(this.availableCashLabel);
            this.availableCashTabPage.Controls.Add(this.label1);
            this.availableCashTabPage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.availableCashTabPage.Location = new System.Drawing.Point(4, 47);
            this.availableCashTabPage.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.availableCashTabPage.Name = "availableCashTabPage";
            this.availableCashTabPage.Padding = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.availableCashTabPage.Size = new System.Drawing.Size(548, 308);
            this.availableCashTabPage.TabIndex = 0;
            this.availableCashTabPage.Text = "Available Cash";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATMSimulator.Properties.Resources.ATMBankLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // availableCashLabel
            // 
            this.availableCashLabel.Location = new System.Drawing.Point(200, 143);
            this.availableCashLabel.Name = "availableCashLabel";
            this.availableCashLabel.Size = new System.Drawing.Size(137, 41);
            this.availableCashLabel.TabIndex = 1;
            this.availableCashLabel.Text = "$0.00";
            this.availableCashLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Cash";
            // 
            // recentTransactionsTabPage
            // 
            this.recentTransactionsTabPage.BackColor = System.Drawing.Color.MidnightBlue;
            this.recentTransactionsTabPage.Controls.Add(this.transactionListBox);
            this.recentTransactionsTabPage.Controls.Add(this.label2);
            this.recentTransactionsTabPage.Controls.Add(this.pictureBox2);
            this.recentTransactionsTabPage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.recentTransactionsTabPage.Location = new System.Drawing.Point(4, 47);
            this.recentTransactionsTabPage.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.recentTransactionsTabPage.Name = "recentTransactionsTabPage";
            this.recentTransactionsTabPage.Padding = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.recentTransactionsTabPage.Size = new System.Drawing.Size(548, 308);
            this.recentTransactionsTabPage.TabIndex = 1;
            this.recentTransactionsTabPage.Text = "Recent Transactions";
            // 
            // transactionListBox
            // 
            this.transactionListBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.transactionListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactionListBox.FormattingEnabled = true;
            this.transactionListBox.ItemHeight = 38;
            this.transactionListBox.Location = new System.Drawing.Point(72, 73);
            this.transactionListBox.Name = "transactionListBox";
            this.transactionListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.transactionListBox.Size = new System.Drawing.Size(405, 190);
            this.transactionListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transaction History";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ATMSimulator.Properties.Resources.ATMBankLogo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // withdrawalTabPage
            // 
            this.withdrawalTabPage.BackColor = System.Drawing.Color.MidnightBlue;
            this.withdrawalTabPage.Controls.Add(this.withdrawalButton);
            this.withdrawalTabPage.Controls.Add(this.withdrawalCashTextBox);
            this.withdrawalTabPage.Controls.Add(this.label4);
            this.withdrawalTabPage.Controls.Add(this.label3);
            this.withdrawalTabPage.Controls.Add(this.pictureBox3);
            this.withdrawalTabPage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.withdrawalTabPage.Location = new System.Drawing.Point(4, 47);
            this.withdrawalTabPage.Name = "withdrawalTabPage";
            this.withdrawalTabPage.Size = new System.Drawing.Size(548, 308);
            this.withdrawalTabPage.TabIndex = 2;
            this.withdrawalTabPage.Text = "Withdrawal";
            // 
            // withdrawalButton
            // 
            this.withdrawalButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.withdrawalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdrawalButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.withdrawalButton.Location = new System.Drawing.Point(174, 193);
            this.withdrawalButton.Name = "withdrawalButton";
            this.withdrawalButton.Size = new System.Drawing.Size(203, 54);
            this.withdrawalButton.TabIndex = 6;
            this.withdrawalButton.Text = "Withdrawal";
            this.withdrawalButton.UseVisualStyleBackColor = false;
            this.withdrawalButton.Click += new System.EventHandler(this.withdrawalButton_Click);
            // 
            // withdrawalCashTextBox
            // 
            this.withdrawalCashTextBox.BackColor = System.Drawing.Color.Gold;
            this.withdrawalCashTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.withdrawalCashTextBox.Location = new System.Drawing.Point(159, 111);
            this.withdrawalCashTextBox.Name = "withdrawalCashTextBox";
            this.withdrawalCashTextBox.Size = new System.Drawing.Size(235, 45);
            this.withdrawalCashTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bodoni MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max Withdrawal $500.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Withdrawal Amount";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ATMSimulator.Properties.Resources.ATMBankLogo;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // errorProviderWithdrawal
            // 
            this.errorProviderWithdrawal.ContainerControl = this;
            // 
            // exitTabPage
            // 
            this.exitTabPage.BackColor = System.Drawing.Color.MidnightBlue;
            this.exitTabPage.Controls.Add(this.exitButton);
            this.exitTabPage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitTabPage.Location = new System.Drawing.Point(4, 47);
            this.exitTabPage.Name = "exitTabPage";
            this.exitTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.exitTabPage.Size = new System.Drawing.Size(548, 308);
            this.exitTabPage.TabIndex = 3;
            this.exitTabPage.Text = "Exit";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(173, 127);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(203, 54);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ATMMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 356);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Bodoni MT Condensed", 24F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.Name = "ATMMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATMMenu";
            this.Load += new System.EventHandler(this.ATMMenu_Load);
            this.tabControl1.ResumeLayout(false);
            this.availableCashTabPage.ResumeLayout(false);
            this.availableCashTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.recentTransactionsTabPage.ResumeLayout(false);
            this.recentTransactionsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.withdrawalTabPage.ResumeLayout(false);
            this.withdrawalTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWithdrawal)).EndInit();
            this.exitTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage availableCashTabPage;
        private System.Windows.Forms.TabPage recentTransactionsTabPage;
        private System.Windows.Forms.TabPage withdrawalTabPage;
        private System.Windows.Forms.Label availableCashLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox transactionListBox;
        private System.Windows.Forms.TextBox withdrawalCashTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button withdrawalButton;
        private System.Windows.Forms.ErrorProvider errorProviderWithdrawal;
        private System.Windows.Forms.TabPage exitTabPage;
        private System.Windows.Forms.Button exitButton;
    }
}
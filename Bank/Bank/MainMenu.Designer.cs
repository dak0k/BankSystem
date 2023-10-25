namespace Bank
{
    partial class MainMenu
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
            _paymentsBtn = new Button();
            _myBankBtn = new Button();
            _transferBtn = new Button();
            title = new Label();
            _balanceValueText = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // _paymentsBtn
            // 
            _paymentsBtn.BackColor = Color.DarkKhaki;
            _paymentsBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            _paymentsBtn.ForeColor = SystemColors.ButtonHighlight;
            _paymentsBtn.Location = new Point(107, 318);
            _paymentsBtn.Name = "_paymentsBtn";
            _paymentsBtn.Padding = new Padding(5);
            _paymentsBtn.Size = new Size(168, 46);
            _paymentsBtn.TabIndex = 3;
            _paymentsBtn.Text = "PAYMENTS";
            _paymentsBtn.UseVisualStyleBackColor = false;
            // 
            // _myBankBtn
            // 
            _myBankBtn.BackColor = Color.Olive;
            _myBankBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            _myBankBtn.ForeColor = SystemColors.ButtonFace;
            _myBankBtn.Location = new Point(107, 248);
            _myBankBtn.Name = "_myBankBtn";
            _myBankBtn.Padding = new Padding(5);
            _myBankBtn.Size = new Size(168, 46);
            _myBankBtn.TabIndex = 4;
            _myBankBtn.Text = "MY BANK";
            _myBankBtn.UseVisualStyleBackColor = false;
            // 
            // _transferBtn
            // 
            _transferBtn.BackColor = Color.DarkOliveGreen;
            _transferBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            _transferBtn.ForeColor = Color.Transparent;
            _transferBtn.Location = new Point(107, 182);
            _transferBtn.Name = "_transferBtn";
            _transferBtn.Padding = new Padding(5);
            _transferBtn.Size = new Size(168, 46);
            _transferBtn.TabIndex = 5;
            _transferBtn.Text = "TRANSFERS";
            _transferBtn.UseVisualStyleBackColor = false;
            _transferBtn.Click += button1_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Verdana", 20.2F, FontStyle.Bold, GraphicsUnit.Point);
            title.ForeColor = Color.Transparent;
            title.Location = new Point(127, 74);
            title.Name = "title";
            title.Size = new Size(125, 41);
            title.TabIndex = 2;
            title.Text = "BANK";
            // 
            // _balanceValueText
            // 
            _balanceValueText.AutoSize = true;
            _balanceValueText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            _balanceValueText.ForeColor = SystemColors.ButtonHighlight;
            _balanceValueText.Location = new Point(178, 127);
            _balanceValueText.Name = "_balanceValueText";
            _balanceValueText.Size = new Size(120, 28);
            _balanceValueText.TabIndex = 7;
            _balanceValueText.Text = "*BALANCE*";
            _balanceValueText.Click += _balanceValueText_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(107, 133);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 8;
            label3.Text = "BALANCE";
            label3.Click += label3_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(382, 453);
            Controls.Add(_balanceValueText);
            Controls.Add(label3);
            Controls.Add(_paymentsBtn);
            Controls.Add(_myBankBtn);
            Controls.Add(_transferBtn);
            Controls.Add(title);
            Name = "MainMenu";
            Text = "MainMenu";
            Load += MainMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button _paymentsBtn;
        private Button _myBankBtn;
        private Button _transferBtn;
        private Label title;
        private Label _balanceValueText;
        private Label label3;
    }
}
namespace Bank
{
    partial class TransferForm
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
            label1 = new Label();
            _inputValue = new TextBox();
            label2 = new Label();
            button1 = new Button();
            _infoText = new TextBox();
            label3 = new Label();
            _balanceValueText = new Label();
            _backButton = new Button();
            _transferListView = new ListView();
            date = new ColumnHeader();
            value = new ColumnHeader();
            target = new ColumnHeader();
            _listViewLClear = new Button();
            _transferTargetInput = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(78, 21);
            label1.Name = "label1";
            label1.Size = new Size(243, 41);
            label1.TabIndex = 1;
            label1.Text = "TRANSFERS";
            // 
            // _inputValue
            // 
            _inputValue.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            _inputValue.ForeColor = Color.OliveDrab;
            _inputValue.Location = new Point(36, 223);
            _inputValue.Name = "_inputValue";
            _inputValue.PlaceholderText = "Input Sum";
            _inputValue.Size = new Size(328, 41);
            _inputValue.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.YellowGreen;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(36, 100);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 3;
            label2.Text = "Whom";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(123, 270);
            button1.Name = "button1";
            button1.Size = new Size(152, 57);
            button1.TabIndex = 4;
            button1.Text = "TRANSFER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _infoText
            // 
            _infoText.BackColor = Color.Green;
            _infoText.Location = new Point(35, 506);
            _infoText.Name = "_infoText";
            _infoText.ReadOnly = true;
            _infoText.Size = new Size(329, 27);
            _infoText.TabIndex = 5;
            _infoText.TextChanged += _infoText_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(113, 83);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 6;
            label3.Text = "BALANCE";
            // 
            // _balanceValueText
            // 
            _balanceValueText.AutoSize = true;
            _balanceValueText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            _balanceValueText.ForeColor = SystemColors.ButtonHighlight;
            _balanceValueText.Location = new Point(184, 77);
            _balanceValueText.Name = "_balanceValueText";
            _balanceValueText.Size = new Size(120, 28);
            _balanceValueText.TabIndex = 6;
            _balanceValueText.Text = "*BALANCE*";
            // 
            // _backButton
            // 
            _backButton.BackColor = Color.Crimson;
            _backButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            _backButton.ForeColor = SystemColors.ButtonHighlight;
            _backButton.Location = new Point(12, 12);
            _backButton.Name = "_backButton";
            _backButton.Size = new Size(44, 54);
            _backButton.TabIndex = 7;
            _backButton.Text = "<";
            _backButton.UseVisualStyleBackColor = false;
            _backButton.Click += _backButton_Click;
            // 
            // _transferListView
            // 
            _transferListView.Columns.AddRange(new ColumnHeader[] { date, value, target });
            _transferListView.Location = new Point(36, 333);
            _transferListView.Name = "_transferListView";
            _transferListView.Size = new Size(328, 167);
            _transferListView.TabIndex = 8;
            _transferListView.UseCompatibleStateImageBehavior = false;
            _transferListView.View = View.Details;
            _transferListView.SelectedIndexChanged += _transferListView_SelectedIndexChanged;
            // 
            // date
            // 
            date.Text = "Date";
            date.Width = 93;
            // 
            // value
            // 
            value.Text = "Value";
            value.Width = 80;
            // 
            // target
            // 
            target.Text = "Whom";
            target.Width = 150;
            // 
            // _listViewLClear
            // 
            _listViewLClear.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            _listViewLClear.Location = new Point(281, 270);
            _listViewLClear.Name = "_listViewLClear";
            _listViewLClear.Size = new Size(83, 57);
            _listViewLClear.TabIndex = 9;
            _listViewLClear.Text = "X";
            _listViewLClear.UseVisualStyleBackColor = true;
            _listViewLClear.Click += ListViewLClear_Click;
            // 
            // _transferTargetInput
            // 
            _transferTargetInput.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            _transferTargetInput.ForeColor = Color.OliveDrab;
            _transferTargetInput.Location = new Point(37, 131);
            _transferTargetInput.Name = "_transferTargetInput";
            _transferTargetInput.PlaceholderText = "Input Card Number";
            _transferTargetInput.Size = new Size(328, 41);
            _transferTargetInput.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.YellowGreen;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(37, 192);
            label4.Name = "label4";
            label4.Size = new Size(53, 28);
            label4.TabIndex = 3;
            label4.Text = "Sum";
            // 
            // TransferForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            ClientSize = new Size(400, 554);
            Controls.Add(_listViewLClear);
            Controls.Add(_transferListView);
            Controls.Add(_backButton);
            Controls.Add(_balanceValueText);
            Controls.Add(label3);
            Controls.Add(_infoText);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(_transferTargetInput);
            Controls.Add(_inputValue);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TransferForm";
            Text = "TransferForm";
            Load += TransferForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox _inputValue;
        private Label label2;
        private Button button1;
        private TextBox _infoText;
        private Label label3;
        private Label _balanceValueText;
        private Button _backButton;
        private ListView _transferListView;
        private ColumnHeader date;
        private ColumnHeader value;
        private Button _listViewLClear;
        private TextBox _transferTargetInput;
        private ColumnHeader target;
        private Label label4;
    }
}
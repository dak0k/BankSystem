using Bank.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Bank
{
    public partial class TransferForm : Form
    {
        private Account _account;
        public TransferForm(Account account)
        {
            _account = account;

            InitializeComponent();
            _account.NotifyEvent += AccountNotifyEventHandler;
            _balanceValueText.Text = _account.Balance.ToString();
        }

        private void TransferForm_Load(object sender, EventArgs e)
        {
            foreach(var item in _account.Items)
            {
                _transferListView.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
            _inputValue.BackColor = Color.White;
            if (_account.TryTake(int.Parse(_inputValue.Text)))
            {
                listViewItem.Text = DateTime.Now.ToLongDateString();

                subItem.Text = _inputValue.Text;

                listViewItem.SubItems.Add(subItem);
                listViewItem.SubItems.Add(_transferTargetInput.Text);
                _transferListView.Items.Add(listViewItem);
                _account.Items.Add(listViewItem);
                _balanceValueText.Text = _account.Balance.ToString();
                _inputValue.Clear();
                _transferTargetInput.Clear();
            }
            else
            {

                _inputValue.BackColor = Color.Red;
                listViewItem.Text = DateTime.Now.ToLongDateString();
                subItem.Text = "not enough MONEY YOU ASSHOLE BULLSHIT FUCKING LAZY NIGGER";
                listViewItem.SubItems.Add(subItem);
                _transferListView.Items.Add(listViewItem);
            }

        }

        private void AccountNotifyEventHandler(string message)
        {
            _infoText.Text = message;
        }

        private void _backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu(_account).Show();
        }

        private void _transferListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void _infoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListViewLClear_Click(object sender, EventArgs e)
        {
           
            _transferListView.Items.Clear();
        }
    }
}

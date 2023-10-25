using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Data
{
    public class Account
    {   
        public delegate void AccountMessageHandler(string message);
        public event AccountMessageHandler NotifyEvent;

        private int _balance;
        private List<ListViewItem> _items = new List<ListViewItem>();
        public int Balance { get => _balance; }
        public List<ListViewItem> Items { get => _items;  }

        public Account(int balance)
        {
            _balance = balance;
        }

        /// <summary>
        /// It's function trying to take balance money if it is not it returns false
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool TryTake(int value)
        {
            if (value <= _balance)
            {
                _balance -= value;
                NotifyEvent?.Invoke($"From Balance was took: {value}");
                return true;
            }
            else
            {
                NotifyEvent?.Invoke($"Not enough money in balance");
                return false;
            }
        }
       
    }
}

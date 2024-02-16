using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynContext
{
    public class Bank
    {
        private decimal money;
        private string name;
        private int percent;

        public event EventHandler<BankChangedEventArgs> BankChanged;

        public decimal Money
        {
            get { return money; }
            set
            {
                if (money != value)
                {
                    money = value;
                    OnBankChanged(new BankChangedEventArgs("Money", money));
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnBankChanged(new BankChangedEventArgs("Name", name));
                }
            }
        }

        public int Percent
        {
            get { return percent; }
            set
            {
                if (percent != value)
                {
                    percent = value;
                    OnBankChanged(new BankChangedEventArgs("Percent", percent));
                }
            }
        }

        protected virtual void OnBankChanged(BankChangedEventArgs e)
        {
            BankChanged?.Invoke(this, e);
        }
    }
}

using System;
using System.Windows.Forms;

namespace SynContext
{
    public partial class Form1 : Form
    {
        private Bank bank = new Bank();
        private SynchronizationContext synchronizationContext;

        public Form1()
        {
            InitializeComponent();

            synchronizationContext = SynchronizationContext.Current;

            bank.BankChanged += Bank_BankChanged;

            moneyTextBox.KeyDown += TextBox_KeyDown;
            nameTextBox.KeyDown += TextBox_KeyDown;
            percentTextBox.KeyDown += TextBox_KeyDown;
        }

        private void Bank_BankChanged(object sender, BankChangedEventArgs e)
        {
            synchronizationContext.Send(state =>
            {
                int existingIndex = -1;
                for (int i = 0; i < outputListBox.Items.Count; i++)
                {
                    string existingItem = outputListBox.Items[i].ToString();
                    if (existingItem.StartsWith($"{e.PropertyName}:"))
                    {
                        existingIndex = i;
                        break;
                    }
                }
                if (existingIndex != -1)
                {
                    outputListBox.Items[existingIndex] = $"{e.PropertyName}: {e.NewValue}";
                }
                else
                {
                    outputListBox.Items.Add($"{e.PropertyName}: {e.NewValue}");
                }
            }, null);
        }

        private void moneyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(moneyTextBox.Text, out decimal money))
            {
                bank.Money = money;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            bank.Name = nameTextBox.Text;
        }

        private void percentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(percentTextBox.Text, out int percent))
            {
                bank.Percent = percent;
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sender == moneyTextBox)
                {
                    if (decimal.TryParse(moneyTextBox.Text, out decimal money))
                    {
                        bank.Money = money;
                    }
                }
                else if (sender == nameTextBox)
                {
                    bank.Name = nameTextBox.Text;
                }
                else if (sender == percentTextBox)
                {
                    if (int.TryParse(percentTextBox.Text, out int percent))
                    {
                        bank.Percent = percent;
                    }
                }
            }
        }
    }
}

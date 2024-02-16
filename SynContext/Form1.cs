using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SynContext
{
    public partial class Form1 : Form
    {
        private Bank bank = new Bank();
        public Form1()
        {
            InitializeComponent();

            bank.BankChanged += Bank_BankChanged;

            //привязка события к обработчику при нажатии на Enter
            moneyTextBox.KeyDown += TextBox_KeyDown;
            nameTextBox.KeyDown += TextBox_KeyDown;
            percentTextBox.KeyDown += TextBox_KeyDown;
        }
        //добавление потока
        private void Bank_BankChanged(object sender, BankChangedEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                outputListBox.Items.Add($"{e.PropertyName}: {e.NewValue}");
            }));
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

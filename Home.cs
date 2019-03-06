using Blackbox.Client.Prop;
using Blackbox.Client.src;
using System;
using System.Windows.Forms;
using static Blackbox.Client.src.SocketConn.SynchronousSocketClient;

namespace Blackbox.Client
{
    public partial class Home : Form
    {
        public string withdrawAmount = string.Empty;
        public int Account;

        public Home(int accountId)
        {
            Account = accountId;
            InitializeComponent();
        }

        private void Balance_Click(object sender, EventArgs e)
        {
            StartClient(Serialization.SerializeAccountBalance(Account));
        }
        internal static void ShowAccountBalance(AccountBalanceResponse accountBalance)
        {
            MessageBox.Show("Your Balance is $" + accountBalance.Balance);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        internal static void ShowBalanceErrorMessage()
        {
            string ScreenText = string.Empty;
            ScreenText = "Hola";
            MessageBox.Show("Error retrieving your current balance.");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ScreenText.Clear();
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            withdrawAmount = "";
            ScreenText.Clear();
            ScreenText.Text = "Enter withdraw amount\n --> ";
        }

        private void One_Click(object sender, EventArgs e)
        {
            withdrawAmount += One.Text;
            ScreenText.AppendText(One.Text);
        }

        private void Two_Click(object sender, EventArgs e)
        {
            withdrawAmount += Two.Text;
            ScreenText.AppendText(Two.Text);
        }

        private void Three_Click(object sender, EventArgs e)
        {
            withdrawAmount += Three.Text;
            ScreenText.AppendText(Three.Text);
        }

        private void Four_Click(object sender, EventArgs e)
        {
            withdrawAmount += Four.Text;
            ScreenText.AppendText(Four.Text);
        }

        private void Five_Click(object sender, EventArgs e)
        {
            withdrawAmount += Five.Text;
            ScreenText.AppendText(Five.Text);
        }

        private void Six_Click(object sender, EventArgs e)
        {
            withdrawAmount += Six.Text;
            ScreenText.AppendText(Six.Text);
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            withdrawAmount += Seven.Text;
            ScreenText.AppendText(Seven.Text);
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            withdrawAmount += Eight.Text;
            ScreenText.AppendText(Eight.Text);
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            withdrawAmount += Nine.Text;
            ScreenText.AppendText(Nine.Text);
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (withdrawAmount.Length > 0)
            {
                withdrawAmount += Zero.Text;
                ScreenText.AppendText(Zero.Text);
            }
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (withdrawAmount.Length > 0)
            {
                StartClient(Serialization.SerializeWithdraw(Account, Convert.ToDouble(withdrawAmount)));
            }
            else
            {
                MessageBox.Show("Enter a valid amount to continue");
            }
        }

        public static void WithdrawResult(WithdrawResponse withdraw)
        {
            Home home = new Home(withdraw.AccountId);
            home.ShowWithdraw(withdraw);
        }

        public void ShowWithdraw(WithdrawResponse withdraw)
        {
            ScreenText.Clear();
            MessageBox.Show("Account type: " + withdraw.AccountTypeName +
                "\nYour Current Balance is $" + withdraw.NewBalance +
                "\nYou can take your money");
        }
    }
}

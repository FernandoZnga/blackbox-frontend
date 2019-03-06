using Blackbox.Client.Prop;
using Blackbox.Client.src;
using System;
using System.Windows.Forms;
using static Blackbox.Client.src.SocketConn.SynchronousSocketClient;

namespace Blackbox.Client
{
    public partial class Home : Form
    {
        public string action = string.Empty;
        public string withdrawAmount = string.Empty;
        public string transferAmount = string.Empty;
        public string transferAccount = string.Empty;
        public string depositAmount = string.Empty;
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
            MessageBox.Show("Error retrieving your current balance.");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ScreenText.Clear();
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            action = Withdraw.Text;
            withdrawAmount = "";
            ScreenText.Clear();
            ScreenText.Text = "Enter withdraw amount\n --> ";
        }

        internal static void ShowCheckAmount()
        {
            string ScreenText = string.Empty;
            MessageBox.Show("Amount entered invalid , check your balance first.");
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (action == "Withdraw")
            {
                withdrawAmount += One.Text;
                ScreenText.AppendText(One.Text);
            }
            else if (action == "Deposit")
            {
                depositAmount += One.Text;
                ScreenText.AppendText(One.Text);
            }
            else if (action == "Transfer")
            {
                transferAmount += One.Text;
                ScreenText.AppendText(One.Text);
            }
            else if (action == "TransferAccount")
            {
                transferAccount += One.Text;
                ScreenText.AppendText(One.Text);
            }
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (action == "Withdraw")
            {
                withdrawAmount += Two.Text;
                ScreenText.AppendText(Two.Text);
            }
            else if (action == "Deposit")
            {
                depositAmount += Two.Text;
                ScreenText.AppendText(Two.Text);
            }
            else if (action == "Transfer")
            {
                transferAmount += Two.Text;
                ScreenText.AppendText(Two.Text);
            }
            else if (action == "TransferAccount")
            {
                transferAccount += Two.Text;
                ScreenText.AppendText(Two.Text);
            }
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (action == "Withdraw")
            {
                withdrawAmount += Three.Text;
                ScreenText.AppendText(Three.Text);
            }
            else if (action == "Deposit")
            {
                depositAmount += Three.Text;
                ScreenText.AppendText(Three.Text);
            }
            else if (action == "Transfer")
            {
                transferAmount += Three.Text;
                ScreenText.AppendText(Three.Text);
            }
            else if (action == "TransferAccount")
            {
                transferAccount += Three.Text;
                ScreenText.AppendText(Three.Text);
            }
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (action == "Withdraw")
            {
                withdrawAmount += Four.Text;
                ScreenText.AppendText(Four.Text);
            }
            else if (action == "Deposit")
            {
                depositAmount += Four.Text;
                ScreenText.AppendText(Four.Text);
            }
            else if (action == "Transfer")
            {
                transferAmount += Four.Text;
                ScreenText.AppendText(Four.Text);
            }
            else if (action == "TransferAccount")
            {
                transferAccount += Four.Text;
                ScreenText.AppendText(Four.Text);
            }
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (action == "Withdraw")
            {
                withdrawAmount += Five.Text;
                ScreenText.AppendText(Five.Text);
            }
            else if (action == "Deposit")
            {
                depositAmount += Five.Text;
                ScreenText.AppendText(Five.Text);
            }
            else if (action == "Transfer")
            {
                transferAmount += Five.Text;
                ScreenText.AppendText(Five.Text);
            }
            else if (action == "TransferAccount")
            {
                transferAccount += Five.Text;
                ScreenText.AppendText(Five.Text);
            }
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (action == "Withdraw")
            {
                withdrawAmount += Six.Text;
                ScreenText.AppendText(Six.Text);
            }
            else if (action == "Deposit")
            {
                depositAmount += Six.Text;
                ScreenText.AppendText(Six.Text);
            }
            else if (action == "Transfer")
            {
                transferAmount += Six.Text;
                ScreenText.AppendText(Six.Text);
            }
            else if (action == "TransferAccount")
            {
                transferAccount += Six.Text;
                ScreenText.AppendText(Six.Text);
            }
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (action == "Withdraw")
            {
                withdrawAmount += Seven.Text;
                ScreenText.AppendText(Seven.Text);
            }
            else if (action == "Deposit")
            {
                depositAmount += Seven.Text;
                ScreenText.AppendText(Seven.Text);
            }
            else if (action == "Transfer")
            {
                transferAmount += Seven.Text;
                ScreenText.AppendText(Seven.Text);
            }
            else if (action == "TransferAccount")
            {
                transferAccount += Seven.Text;
                ScreenText.AppendText(Seven.Text);
            }
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (action == "Withdraw")
            {
                withdrawAmount += Eight.Text;
                ScreenText.AppendText(Eight.Text);
            }
            else if (action == "Deposit")
            {
                depositAmount += Eight.Text;
                ScreenText.AppendText(Eight.Text);
            }
            else if (action == "Transfer")
            {
                transferAmount += Eight.Text;
                ScreenText.AppendText(Eight.Text);
            }
            else if (action == "TransferAccount")
            {
                transferAccount += Eight.Text;
                ScreenText.AppendText(Eight.Text);
            }
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (action == "Withdraw")
            {
                withdrawAmount += Nine.Text;
                ScreenText.AppendText(Nine.Text);
            }
            else if (action == "Deposit")
            {
                depositAmount += Nine.Text;
                ScreenText.AppendText(Nine.Text);
            }
            else if (action == "Transfer")
            {
                transferAmount += Nine.Text;
                ScreenText.AppendText(Nine.Text);
            }
            else if (action == "TransferAccount")
            {
                transferAccount += Nine.Text;
                ScreenText.AppendText(Nine.Text);
            }
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (withdrawAmount.Length > 0 && action == "Withdraw")
            {
                withdrawAmount += Zero.Text;
                ScreenText.AppendText(Zero.Text);
            }
            else if (depositAmount.Length > 0 && action == "Deposit")
            {
                depositAmount += Zero.Text;
                ScreenText.AppendText(Zero.Text);
            }
            else if (transferAmount.Length > 0 && action == "Transfer")
            {
                transferAmount += Zero.Text;
                ScreenText.AppendText(Zero.Text);
            }
            else if (transferAccount.Length > 0 && action == "TransferAcount")
            {
                transferAccount += Zero.Text;
                ScreenText.AppendText(Zero.Text);
            }
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (withdrawAmount.Length > 0)
            {
                StartClient(Serialization.SerializeWithdraw(Account, Convert.ToDouble(withdrawAmount)));
            }
            else if (depositAmount.Length > 0)
            {
                StartClient(Serialization.SerializeDeposit(Account, Convert.ToDouble(depositAmount)));
            }
            else if (transferAmount.Length == 0)
            {
                MessageBox.Show("Enter Amount to continue");
            }
            else if (transferAmount.Length > 0 && transferAccount.Length == 0)
            {
                action = "TransferAccount";
                ScreenText.AppendText("\n\nEnter Account Number\n -->");
            }
            else if (action == "TransferAccount" && transferAccount.Length > 0)
            {
                StartClient(Serialization.SerializeTransfer(Account, Convert.ToDouble(transferAmount), Convert.ToInt32(transferAccount)));
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
            ScreenText.Text = "";
            MessageBox.Show("Account type: " + withdraw.AccountTypeName +
                "\nYour Current Balance is $" + withdraw.NewBalance +
                "\nYou can take your money");
            action = string.Empty;
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            action = Deposit.Text;
            depositAmount = "";
            ScreenText.Clear();
            ScreenText.Text = "Enter deposit amount\n --> ";
        }

        public static void DepositResult(DepositResponse deposit)
        {
            Home home = new Home(deposit.AccountId);
            home.ShowDeposit(deposit);
        }

        public void ShowDeposit(DepositResponse deposit)
        {
            ScreenText.Text = "";
            MessageBox.Show("Account type: " + deposit.AccountTypeName +
                "\nYour Current Balance is $" + deposit.NewBalance);
            action = string.Empty;
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            action = Transfer.Text;
            transferAmount = "";
            transferAccount = "";
            ScreenText.Clear();
            ScreenText.Text = "Enter transfer amount\n -->";
        }

        internal static void TransferResult(TransferResponse transfer)
        {
            Home home = new Home(transfer.AccountId);
            home.ShowTransfer(transfer);
        }

        private void ShowTransfer(TransferResponse transfer)
        {
            ScreenText.Text = "";
            MessageBox.Show("Account type: " + transfer.AccountTypeName +
                "\nTransfer to the account " + transfer.AccountIdDestiny + " Done!" +
                "\nYour New Balance is $" + transfer.NewBalance);
            action = string.Empty;
        }
    }
}

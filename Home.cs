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
        public string currentPin = string.Empty;
        public string newPin = string.Empty;
        public string confirmPin = string.Empty;

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
            Reset();
        }

        internal void Reset()
        {
            ScreenText.Clear();
            transferAccount = string.Empty;
            transferAmount = string.Empty;
            withdrawAmount = string.Empty;
            depositAmount = string.Empty;
            action = string.Empty;
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            action = Withdraw.Text;
            withdrawAmount = "";
            ScreenText.Clear();
            ScreenText.Text = "Enter withdraw amount" + Environment.NewLine + "--> ";
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
            else if (action == "ChangeMyPin")
            {
                currentPin += One.Text;
                ScreenText.AppendText(One.Text);
            }
            else if (action == "ChangeMyPinNew")
            {
                newPin += One.Text;
                ScreenText.AppendText(One.Text);
            }
            else if (action == "ChangeMyPinConfirm")
            {
                confirmPin += One.Text;
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
            else if (action == "ChangeMyPin")
            {
                currentPin += Two.Text;
                ScreenText.AppendText(Two.Text);
            }
            else if (action == "ChangeMyPinNew")
            {
                newPin += Two.Text;
                ScreenText.AppendText(Two.Text);
            }
            else if (action == "ChangeMyPinConfirm")
            {
                confirmPin += Two.Text;
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
            else if (action == "ChangeMyPin")
            {
                currentPin += Three.Text;
                ScreenText.AppendText(Three.Text);
            }
            else if (action == "ChangeMyPinNew")
            {
                newPin += Three.Text;
                ScreenText.AppendText(Three.Text);
            }
            else if (action == "ChangeMyPinConfirm")
            {
                confirmPin += Three.Text;
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
            else if (action == "ChangeMyPin")
            {
                currentPin += Four.Text;
                ScreenText.AppendText(Four.Text);
            }
            else if (action == "ChangeMyPinNew")
            {
                newPin += Four.Text;
                ScreenText.AppendText(Four.Text);
            }
            else if (action == "ChangeMyPinConfirm")
            {
                confirmPin += Four.Text;
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
            else if (action == "ChangeMyPin")
            {
                currentPin += Five.Text;
                ScreenText.AppendText(Five.Text);
            }
            else if (action == "ChangeMyPinNew")
            {
                newPin += Five.Text;
                ScreenText.AppendText(Five.Text);
            }
            else if (action == "ChangeMyPinConfirm")
            {
                confirmPin += Five.Text;
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
            else if (action == "ChangeMyPin")
            {
                currentPin += Six.Text;
                ScreenText.AppendText(Six.Text);
            }
            else if (action == "ChangeMyPinNew")
            {
                newPin += Six.Text;
                ScreenText.AppendText(Six.Text);
            }
            else if (action == "ChangeMyPinConfirm")
            {
                confirmPin += Six.Text;
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
            else if (action == "ChangeMyPin")
            {
                currentPin += Seven.Text;
                ScreenText.AppendText(Seven.Text);
            }
            else if (action == "ChangeMyPinNew")
            {
                newPin += Seven.Text;
                ScreenText.AppendText(Seven.Text);
            }
            else if (action == "ChangeMyPinConfirm")
            {
                confirmPin += Seven.Text;
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
            else if (action == "ChangeMyPin")
            {
                currentPin += Eight.Text;
                ScreenText.AppendText(Eight.Text);
            }
            else if (action == "ChangeMyPinNew")
            {
                newPin += Eight.Text;
                ScreenText.AppendText(Eight.Text);
            }
            else if (action == "ChangeMyPinConfirm")
            {
                confirmPin += Eight.Text;
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
            else if (action == "ChangeMyPin")
            {
                currentPin += Nine.Text;
                ScreenText.AppendText(Nine.Text);
            }
            else if (action == "ChangeMyPinNew")
            {
                newPin += Nine.Text;
                ScreenText.AppendText(Nine.Text);
            }
            else if (action == "ChangeMyPinConfirm")
            {
                confirmPin += Nine.Text;
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
            else if (currentPin.Length > 0 && action == "ChangeMyPin")
            {
                currentPin += Zero.Text;
                ScreenText.AppendText(Zero.Text);
            }
            else if (newPin.Length > 0 && action == "ChangeMyPinNew")
            {
                newPin += Zero.Text;
                ScreenText.AppendText(Zero.Text);
            }
            else if (confirmPin.Length > 0 && action == "ChangeMyPinConfirm")
            {
                confirmPin += Zero.Text;
                ScreenText.AppendText(Zero.Text);
            }
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (withdrawAmount.Length > 0)
            {
                StartClient(Serialization.SerializeWithdraw(Account, 
                    Convert.ToDouble(withdrawAmount)));
                Reset();
            }
            else if (depositAmount.Length > 0)
            {
                StartClient(Serialization.SerializeDeposit(Account, 
                    Convert.ToDouble(depositAmount)));
                Reset();
            }
            else if (transferAmount.Length == 0)
            {
                MessageBox.Show("Enter Amount to continue");
            }
            else if (transferAmount.Length > 0 && transferAccount.Length == 0)
            {
                action = "TransferAccount";
                ScreenText.AppendText(Environment.NewLine + "Enter Account Number" + 
                    Environment.NewLine + "-->");
            }
            else if (action == "TransferAccount" && transferAccount.Length > 0)
            {
                if (Convert.ToInt32(transferAccount) != Account)
                {
                    StartClient(Serialization.SerializeTransfer(Account,
                    Convert.ToDouble(transferAmount), Convert.ToInt32(transferAccount)));
                    Reset();
                }
                else
                {
                    MessageBox.Show("Error - Account Destiny cannot be Your own Account");
                    Reset();
                }
            }
            else if (action == "ChangeMyPin" && currentPin.Length > 0)
            {
                action = "ChangeMyPinNew";
                ScreenText.AppendText("Enter your new Pin" + Environment.NewLine + "--> ");
            }
            else if (action == "ChangeMyPinNew" && newPin.Length > 0)
            {
                action = "ChangeMyPinConfirm";
                ScreenText.AppendText("Confirm you new Pin" + Environment.NewLine + "--> ");
            }
            else if (action == "ChangeMyPinConfirm" && confirmPin.Length > 0)
            {
                if (newPin != confirmPin || newPin == currentPin)
                {
                    MessageBox.Show("Error - New and Confirm must be the same to continue and Current and New must be differente");
                    Reset();
                }
                else
                {
                    StartClient(Serialization.SerializeChangePin(Account, currentPin, newPin));
                    Reset();
                }
            }
            else
            {
                MessageBox.Show("Enter a value to continue");
            }
        }

        public static void WithdrawResult(WithdrawResponse withdraw)
        {
            Home home = new Home(withdraw.AccountId);
            home.ShowWithdraw(withdraw);
            home.Reset();
        }

        public void ShowWithdraw(WithdrawResponse withdraw)
        {
            ScreenText.Text = "";
            MessageBox.Show("Account type: " + withdraw.AccountTypeName +
                Environment.NewLine + "Your Current Balance is $" + withdraw.NewBalance +
                Environment.NewLine + "You can take your money");
            //Reset();
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            action = Deposit.Text;
            depositAmount = "";
            ScreenText.Clear();
            ScreenText.Text = "Enter deposit amount" + Environment.NewLine + "--> ";
        }

        public static void DepositResult(DepositResponse deposit)
        {
            Home home = new Home(deposit.AccountId);
            home.ShowDeposit(deposit);
            home.Reset();
        }

        public void ShowDeposit(DepositResponse deposit)
        {
            ScreenText.Text = "";
            MessageBox.Show("Account type: " + deposit.AccountTypeName +
                Environment.NewLine + "Your Current Balance is $" + deposit.NewBalance);
            //Reset();
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            action = Transfer.Text;
            transferAmount = "";
            transferAccount = "";
            ScreenText.Clear();
            ScreenText.Text = "Enter transfer amount" + Environment.NewLine + "-->";
        }

        internal static void TransferResult(TransferResponse transfer)
        {
            Home home = new Home(transfer.AccountId);
            home.ShowTransfer(transfer);
            home.Reset();
        }

        private void ShowTransfer(TransferResponse transfer)
        {
            ScreenText.Text = "";
            MessageBox.Show("Account type: " + transfer.AccountTypeName +
                Environment.NewLine + "Transfer to the account " + transfer.AccountIdDestiny + " Done!" +
                Environment.NewLine + "Your New Balance is $" + transfer.NewBalance);
            //Reset();
        }

        private void ChangeMyPin_Click(object sender, EventArgs e)
        {
            Reset();
            action = "ChangeMyPin";
            ScreenText.Text = "Enter your Current Pin" + Environment.NewLine + "-->");
        }


        internal static void ChangePinResult(ChangePinResponse changePin)
        {
            Home home = new Home(changePin.AccountId);
            home.ShowChangePin(changePin);
            home.Reset();
        }

        private void ShowChangePin(ChangePinResponse changePin)
        {
            ScreenText.Text = "";
            MessageBox.Show("Pin Changed Successfully");
            //Reset();
        }
    }
}

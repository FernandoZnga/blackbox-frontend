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
        public string serviceOption = string.Empty;
        public string billingId = string.Empty;

        public int Account;

        public Home(int accountId)
        {
            Account = accountId;
            InitializeComponent();
        }

        private void Balance_Click(object sender, EventArgs e)
        {
            Reset();
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
            currentPin = string.Empty;
            newPin = string.Empty;
            confirmPin = string.Empty;
            serviceOption = string.Empty;
            billingId = string.Empty;
            action = string.Empty;
        }

        internal static void ShowNotEnoughBalance()
        {
            MessageBox.Show("You don't have enough balance to pay");
        }

        internal static void ShowBillAlreadyPayed()
        {
            MessageBox.Show("Alert! Billing already Payed");
        }

        internal static void ShowNoTransactionsMsg()
        {
            MessageBox.Show("There is no transactions to List");
        }

        internal static void ShowBillingIdInvalid()
        {
            MessageBox.Show("Billing Id invalid");
        }

        internal static void ShowAccountInvalid()
        {
            MessageBox.Show("Account Id invalid");
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            Reset();
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
            else if (action == "PayService" && serviceOption.Length == 0)
            {
                serviceOption = One.Text;
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
            else if (action == "ChangeMyPin" && currentPin.Length < 4)
            {
                currentPin += One.Text;
                ScreenText.AppendText(One.Text);
            }
            else if (action == "ChangeMyPinNew" && newPin.Length < 4)
            {
                newPin += One.Text;
                ScreenText.AppendText(One.Text);
            }
            else if (action == "ChangeMyPinConfirm" && confirmPin.Length < 4)
            {
                confirmPin += One.Text;
                ScreenText.AppendText(One.Text);
            }
            else if (action == "BillingId")
            {
                billingId += One.Text;
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
            else if (action == "PayService" && serviceOption.Length == 0)
            {
                serviceOption = Two.Text;
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
            else if (action == "ChangeMyPin" && currentPin.Length < 4)
            {
                currentPin += Two.Text;
                ScreenText.AppendText(Two.Text);
            }
            else if (action == "ChangeMyPinNew" && newPin.Length < 4)
            {
                newPin += Two.Text;
                ScreenText.AppendText(Two.Text);
            }
            else if (action == "ChangeMyPinConfirm" && confirmPin.Length < 4)
            {
                confirmPin += Two.Text;
                ScreenText.AppendText(Two.Text);
            }
            else if (action == "BillingId")
            {
                billingId += Two.Text;
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
            else if (action == "PayService" && serviceOption.Length == 0)
            {
                serviceOption = Three.Text;
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
            else if (action == "ChangeMyPin" && currentPin.Length < 4)
            {
                currentPin += Three.Text;
                ScreenText.AppendText(Three.Text);
            }
            else if (action == "ChangeMyPinNew" && newPin.Length < 4)
            {
                newPin += Three.Text;
                ScreenText.AppendText(Three.Text);
            }
            else if (action == "ChangeMyPinConfirm" && confirmPin.Length < 4)
            {
                confirmPin += Three.Text;
                ScreenText.AppendText(Three.Text);
            }
            else if (action == "BillingId")
            {
                billingId += Three.Text;
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
            else if (action == "ChangeMyPin" && currentPin.Length < 4)
            {
                currentPin += Four.Text;
                ScreenText.AppendText(Four.Text);
            }
            else if (action == "ChangeMyPinNew" && newPin.Length < 4)
            {
                newPin += Four.Text;
                ScreenText.AppendText(Four.Text);
            }
            else if (action == "ChangeMyPinConfirm" && confirmPin.Length < 4)
            {
                confirmPin += Four.Text;
                ScreenText.AppendText(Four.Text);
            }
            else if (action == "BillingId")
            {
                billingId += Four.Text;
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
            else if (action == "ChangeMyPin" && currentPin.Length < 4)
            {
                currentPin += Five.Text;
                ScreenText.AppendText(Five.Text);
            }
            else if (action == "ChangeMyPinNew" && newPin.Length < 4)
            {
                newPin += Five.Text;
                ScreenText.AppendText(Five.Text);
            }
            else if (action == "ChangeMyPinConfirm" && confirmPin.Length < 4)
            {
                confirmPin += Five.Text;
                ScreenText.AppendText(Five.Text);
            }
            else if (action == "BillingId")
            {
                billingId += Five.Text;
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
            else if (action == "ChangeMyPin" && currentPin.Length < 4)
            {
                currentPin += Six.Text;
                ScreenText.AppendText(Six.Text);
            }
            else if (action == "ChangeMyPinNew" && newPin.Length < 4)
            {
                newPin += Six.Text;
                ScreenText.AppendText(Six.Text);
            }
            else if (action == "ChangeMyPinConfirm" && confirmPin.Length < 4)
            {
                confirmPin += Six.Text;
                ScreenText.AppendText(Six.Text);
            }
            else if (action == "BillingId")
            {
                billingId += Six.Text;
                ScreenText.AppendText(Six.Text);
            }
        }

        internal static void ShowMyTransactionsMsg(MyTransactionsResponse myTransactionsResponse)
        {
            MessageBox.Show("Your history was sent to your Email account.");
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
            else if (action == "ChangeMyPin" && currentPin.Length < 4)
            {
                currentPin += Seven.Text;
                ScreenText.AppendText(Seven.Text);
            }
            else if (action == "ChangeMyPinNew" && newPin.Length < 4)
            {
                newPin += Seven.Text;
                ScreenText.AppendText(Seven.Text);
            }
            else if (action == "ChangeMyPinConfirm" && confirmPin.Length < 4)
            {
                confirmPin += Seven.Text;
                ScreenText.AppendText(Seven.Text);
            }
            else if (action == "BillingId")
            {
                billingId += Seven.Text;
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
            else if (action == "ChangeMyPin" && currentPin.Length < 4)
            {
                currentPin += Eight.Text;
                ScreenText.AppendText(Eight.Text);
            }
            else if (action == "ChangeMyPinNew" && newPin.Length < 4)
            {
                newPin += Eight.Text;
                ScreenText.AppendText(Eight.Text);
            }
            else if (action == "ChangeMyPinConfirm" && confirmPin.Length < 4)
            {
                confirmPin += Eight.Text;
                ScreenText.AppendText(Eight.Text);
            }
            else if (action == "BillingId")
            {
                billingId += Eight.Text;
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
            else if (action == "ChangeMyPin" && currentPin.Length < 4)
            {
                currentPin += Nine.Text;
                ScreenText.AppendText(Nine.Text);
            }
            else if (action == "ChangeMyPinNew" && newPin.Length < 4)
            {
                newPin += Nine.Text;
                ScreenText.AppendText(Nine.Text);
            }
            else if (action == "ChangeMyPinConfirm" && confirmPin.Length < 4)
            {
                confirmPin += Nine.Text;
                ScreenText.AppendText(Nine.Text);
            }
            else if (action == "BillingId")
            {
                billingId += Nine.Text;
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
            else if (currentPin.Length > 0 && action == "ChangeMyPin" && currentPin.Length < 4)
            {
                currentPin += Zero.Text;
                ScreenText.AppendText(Zero.Text);
            }
            else if (newPin.Length > 0 && action == "ChangeMyPinNew" && newPin.Length < 4)
            {
                newPin += Zero.Text;
                ScreenText.AppendText(Zero.Text);
            }
            else if (confirmPin.Length > 0 && action == "ChangeMyPinConfirm" && confirmPin.Length < 4)
            {
                confirmPin += Zero.Text;
                ScreenText.AppendText(Zero.Text);
            }
            else if (billingId.Length > 0 && action == "BillingId")
            {
                billingId += Zero.Text;
                ScreenText.AppendText(Zero.Text);
            }
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (action == "Withdraw" && withdrawAmount.Length > 0)
            {
                StartClient(Serialization.SerializeWithdraw(Account, 
                    Convert.ToDouble(withdrawAmount)));
                Reset();
            }
            else if (action == "Deposit" && depositAmount.Length > 0)
            {
                StartClient(Serialization.SerializeDeposit(Account, 
                    Convert.ToDouble(depositAmount)));
                Reset();
            }
            else if (action == "Transfer" && transferAmount.Length == 0)
            {
                MessageBox.Show("Enter Amount to continue");
            }
            else if (action == "Transfer" && 
                transferAmount.Length > 0 && transferAccount.Length == 0)
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
                ScreenText.AppendText(Environment.NewLine);
                ScreenText.AppendText("Enter your new Pin" + Environment.NewLine + "--> ");
            }
            else if (action == "ChangeMyPinNew" && newPin.Length > 0)
            {
                action = "ChangeMyPinConfirm";
                ScreenText.AppendText(Environment.NewLine);
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
            else if (action == "PayService" && serviceOption.Length == 1)
            {
                action = "BillingId";
                ScreenText.AppendText(Environment.NewLine);
                ScreenText.AppendText("Enter Bill Number" + Environment.NewLine + "--> ");
            }
            else if (action == "BillingId" && billingId.Length > 0)
            {
                if (serviceOption == "1")
                {
                    StartClient(Serialization.SerializePayEnee(Account, Convert.ToInt32(billingId)));
                }
                else if (serviceOption == "2")
                {
                    StartClient(Serialization.SerializePaySanaa(Account, Convert.ToInt32(billingId)));
                }
                else
                {
                    StartClient(Serialization.SerializePayHondutel(Account, Convert.ToInt32(billingId)));
                }
                Reset();
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
            Reset();
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
            Reset();
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
            ScreenText.Text = "Enter your Current Pin" + Environment.NewLine + "-->";
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

        internal static void ShowErrorChangePin()
        {
            MessageBox.Show("Error Changing your Pin. No Action performed");
        }

        private void PayService_Click(object sender, EventArgs e)
        {
            Reset();
            action = "PayService";
            ScreenText.Text = "Select an option" + Environment.NewLine;
            ScreenText.AppendText("1 - Enee" + Environment.NewLine);
            ScreenText.AppendText("2 - Sanaa" + Environment.NewLine);
            ScreenText.AppendText("3 - Hondutel" + Environment.NewLine + "--> ");
        }

        internal static void PayEneeResult(PayEneeResponse payEnee)
        {
            Home home = new Home(payEnee.AccountId);
            home.ShowPayEnee(payEnee);
            home.Reset();
        }

        private void ShowPayEnee(PayEneeResponse payEnee)
        {
            ScreenText.Text = "";
            MessageBox.Show("Bill Payed, Your New Balance is $ " + payEnee.NewBalance);
            //Reset();
        }

        internal static void PaySanaaResult(PaySanaaResponse paySanaa)
        {
            Home home = new Home(paySanaa.AccountId);
            home.ShowPaySanaa(paySanaa);
            home.Reset();
        }

        private void ShowPaySanaa(PaySanaaResponse paySanaa)
        {
            ScreenText.Text = "";
            MessageBox.Show("Bill Payed, Your New Balance is $ " + paySanaa.NewBalance);
            //Reset();
        }

        internal static void PayHondutelResult(PayHondutelResponse payHondutel)
        {
            Home home = new Home(payHondutel.AccountId);
            home.ShowPayHondutel(payHondutel);
            home.Reset();
        }

        private void ShowPayHondutel(PayHondutelResponse payHondutel)
        {
            ScreenText.Text = "";
            MessageBox.Show("Bill Payed, Your New Balance is $ " + payHondutel.NewBalance);
            //Reset();
        }

        private void MyTransactions_Click(object sender, EventArgs e)
        {
            StartClient(Serialization.SerializeMyTransactions(Account));
        }
    }
}

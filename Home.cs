using Blackbox.Server.Prop;
using System;
using System.Windows.Forms;

namespace Blackbox.Server
{
    public partial class Home : Form
    {
        public int account;
        public static TextBox screenText;

        public Home(int accountId)
        {
            account = accountId;
            InitializeComponent();
            screenText = ScreenText;
        }

        private void Balance_Click(object sender, EventArgs e)
        {
            SocketConn.SynchronousSocketClient.StartClient(Serialization.SerializeAccountBalance(account));
        }
        public static void ShowAccountBalance(AccountBalanceResponse accountBalance)
        {
            screenText.Clear();
            screenText.AppendText("Your Balance is $" + accountBalance.Balance);
            //MessageBox.Show("Your Balance is $" + accountBalance.Balance);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        internal static void ShowBalanceErrorMessage()
        {
            MessageBox.Show("Error retrieving your current balance.");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            screenText.Clear();
        }
    }
}

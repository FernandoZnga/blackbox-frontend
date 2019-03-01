using Blackbox.Server.Prop;
using System;
using System.Windows.Forms;

namespace Blackbox.Server
{
    public partial class Home : Form
    {
        public int account;

        public Home(int accountId)
        {
            account = accountId;
            InitializeComponent();
        }

        private void Balance_Click(object sender, EventArgs e)
        {
            SocketConn.SynchronousSocketClient.StartClient(Serialization.SerializeAccountBalance(account));
        }
        public static void ShowAccountBalance(AccountBalanceResponse accountBalance)
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
            MessageBox.Show("Error retrieving your current balance.");
        }
    }
}

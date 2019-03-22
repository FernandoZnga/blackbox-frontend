using Blackbox.Client.Prop;
using Blackbox.Client.src;
using System;
using System.Windows.Forms;
using static Blackbox.Client.src.SocketConn.SynchronousSocketClient;

namespace Blackbox.Client
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            PinNumberLabel.Visible = false;
            PinNumber.Clear();
            PinNumber.Visible = false;
            CcNumber.Clear();
            CcNumber.Visible = true;
        }

        public static void ShowInvalidCcPinNumberMessage()
        {
            MessageBox.Show("Invalida Credit Card or Pin number.");
        }

        public static void ShowInvalidTokenMessage()
        {
            MessageBox.Show("String violation. No transaction performed.");
            ActiveForm.Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        public static void ShowHome(CcPinNumberResponse ccPinNumberResponse)
        {
            Home.accountId = ccPinNumberResponse.Account;
            ActiveForm.Hide();
            Home home = new Home();
            home.ShowDialog();
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                if (CcNumber.TextLength < 19)
                {
                    if (CcNumber.TextLength == 4 || CcNumber.TextLength == 9 || CcNumber.TextLength == 14)
                    {
                        CcNumber.AppendText("-" + One.Text);
                    }
                    else
                    {
                        CcNumber.AppendText(One.Text);
                    }
                }
            }
            else
            {
                if (PinNumber.TextLength < 4)
                {
                    PinNumber.AppendText(One.Text);
                }
            }
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                if (CcNumber.TextLength < 19)
                {
                    if (CcNumber.TextLength == 4 || CcNumber.TextLength == 9 || CcNumber.TextLength == 14)
                    {
                        CcNumber.AppendText("-" + Two.Text);
                    }
                    else
                    {
                        CcNumber.AppendText(Two.Text);
                    }
                }
            }
            else
            {
                if (PinNumber.TextLength < 4)
                {
                    PinNumber.AppendText(Two.Text);
                }
            }
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                if (CcNumber.TextLength < 19)
                {
                    if (CcNumber.TextLength == 4 || CcNumber.TextLength == 9 || CcNumber.TextLength == 14)
                    {
                        CcNumber.AppendText("-" + Three.Text);
                    }
                    else
                    {
                        CcNumber.AppendText(Three.Text);
                    }
                }
            }
            else
            {
                if (PinNumber.TextLength < 4)
                {
                    PinNumber.AppendText(Three.Text);
                }
            }
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                if (CcNumber.TextLength < 19)
                {
                    if (CcNumber.TextLength == 4 || CcNumber.TextLength == 9 || CcNumber.TextLength == 14)
                    {
                        CcNumber.AppendText("-" + Four.Text);
                    }
                    else
                    {
                        CcNumber.AppendText(Four.Text);
                    }
                }
            }
            else
            {
                if (PinNumber.TextLength < 4)
                {
                    PinNumber.AppendText(Four.Text);
                }
            }
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                if (CcNumber.TextLength < 19)
                {
                    if (CcNumber.TextLength == 4 || CcNumber.TextLength == 9 || CcNumber.TextLength == 14)
                    {
                        CcNumber.AppendText("-" + Five.Text);
                    }
                    else
                    {
                        CcNumber.AppendText(Five.Text);
                    }
                }
            }
            else
            {
                if (PinNumber.TextLength < 4)
                {
                    PinNumber.AppendText(Five.Text);
                }
            }
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                if (CcNumber.TextLength < 19)
                {
                    if (CcNumber.TextLength == 4 || CcNumber.TextLength == 9 || CcNumber.TextLength == 14)
                    {
                        CcNumber.AppendText("-" + Six.Text);
                    }
                    else
                    {
                        CcNumber.AppendText(Six.Text);
                    }
                }
            }
            else
            {
                if (PinNumber.TextLength < 4)
                {
                    PinNumber.AppendText(Six.Text);
                }
            }
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                if (CcNumber.TextLength < 19)
                {
                    if (CcNumber.TextLength == 4 || CcNumber.TextLength == 9 || CcNumber.TextLength == 14)
                    {
                        CcNumber.AppendText("-" + Seven.Text);
                    }
                    else
                    {
                        CcNumber.AppendText(Seven.Text);
                    }
                }
            }
            else
            {
                if (PinNumber.TextLength < 4)
                {
                    PinNumber.AppendText(Seven.Text);
                }
            }
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                if (CcNumber.TextLength < 19)
                {
                    if (CcNumber.TextLength == 4 || CcNumber.TextLength == 9 || CcNumber.TextLength == 14)
                    {
                        CcNumber.AppendText("-" + Eight.Text);
                    }
                    else
                    {
                        CcNumber.AppendText(Eight.Text);
                    }
                }
            }
            else
            {
                if (PinNumber.TextLength < 4)
                {
                    PinNumber.AppendText(Eight.Text);
                }
            }
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                if (CcNumber.TextLength < 19)
                {
                    if (CcNumber.TextLength == 4 || CcNumber.TextLength == 9 || CcNumber.TextLength == 14)
                    {
                        CcNumber.AppendText("-" + Nine.Text);
                    }
                    else
                    {
                        CcNumber.AppendText(Nine.Text);
                    }
                }
            }
            else
            {
                if (PinNumber.TextLength < 4)
                {
                    PinNumber.AppendText(Nine.Text);
                }
            }
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                if (CcNumber.TextLength < 19)
                {
                    if (CcNumber.TextLength == 4 || CcNumber.TextLength == 9 || CcNumber.TextLength == 14)
                    {
                        CcNumber.AppendText("-" + Zero.Text);
                    }
                    else
                    {
                        CcNumber.AppendText(Zero.Text);
                    }
                }
            }
            else
            {
                if (PinNumber.TextLength < 4)
                {
                    PinNumber.AppendText(Zero.Text);
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            PinNumber.Clear();
            CcNumber.Clear();
            RequestCcNumber();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                CcNumber.Clear();
            }
            else
            {
                PinNumber.Clear();
            }
        }

        private void RequestPinNumber()
        {
            CcNumber.Visible = false;
            CcNumberLabel.Visible = false;
            PinNumber.Visible = true;
            PinNumberLabel.Visible = true;
        }

        private void RequestCcNumber()
        {
            CcNumber.Visible = true;
            CcNumberLabel.Visible = true;
            PinNumber.Visible = false;
            PinNumberLabel.Visible = false;
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                if (CcNumber.TextLength < 19)
                {
                    MessageBox.Show("Enter a valid Credit Card number to continue...");
                }
                else if (CcNumber.Text != "" && CcNumber.TextLength == 19)
                {
                    RequestPinNumber();
                }
            }
            else
            {
                if (PinNumber.TextLength < 4)
                {
                    MessageBox.Show("Enter a 4-Digit Pin number to continue...");
                }
                else
                {
                    StartClient(Serialization.SerializeCcPinNumber(CcNumber.Text, PinNumber.Text));
                }
            }
        }
    }
}
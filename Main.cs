using Blackbox.Server.Prop;
using System;
using System.Windows.Forms;

namespace Blackbox.Server
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
            ActiveForm.Hide();
            Home home = new Home(ccPinNumberResponse.Account);
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
                        CcNumber.AppendText("-1");
                    }
                    else
                    {
                        CcNumber.AppendText("1");
                    }
                }
            }
            else
            {
                if (PinNumber.TextLength < 4)
                {
                    PinNumber.AppendText("1");
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
                        CcNumber.AppendText("-2");
                    }
                    else
                    {
                        CcNumber.AppendText("2");
                    }
                }
            }
            else
            {
                if (PinNumber.TextLength < 4)
                {
                    PinNumber.AppendText("2");
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
                        CcNumber.AppendText("-3");
                    }
                    else
                    {
                        CcNumber.AppendText("3");
                    }
                }
            }
            else
            {
                if (PinNumber.TextLength < 4)
                {
                    PinNumber.AppendText("3");
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
                        CcNumber.AppendText("-4");
                    }
                    else
                    {
                        CcNumber.AppendText("4");
                    }
                }
            }
            else
            {
                if (PinNumber.TextLength < 4)
                {
                    PinNumber.AppendText("4");
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
                        CcNumber.AppendText("-5");
                    }
                    else
                    {
                        CcNumber.AppendText("5");
                    }
                }
            }
            else
            {
                if (PinNumber.TextLength < 4)
                {
                    PinNumber.AppendText("5");
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
                        CcNumber.AppendText("-6");
                    }
                    else
                    {
                        CcNumber.AppendText("6");
                    }
                }
            }
            else
            {
                if (PinNumber.TextLength < 4)
                {
                    PinNumber.AppendText("6");
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
                        CcNumber.AppendText("-7");
                    }
                    else
                    {
                        CcNumber.AppendText("7");
                    }
                }
            }
            else
            {
                if (PinNumber.TextLength < 4)
                {
                    PinNumber.AppendText("7");
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
                        CcNumber.AppendText("-8");
                    }
                    else
                    {
                        CcNumber.AppendText("8");
                    }
                }
            }
            else
            {
                if (PinNumber.TextLength < 4)
                {
                    PinNumber.AppendText("8");
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
                        CcNumber.AppendText("-9");
                    }
                    else
                    {
                        CcNumber.AppendText("9");
                    }
                }
            }
            else
            {
                if (PinNumber.TextLength < 4)
                {
                    PinNumber.AppendText("9");
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
                        CcNumber.AppendText("-0");
                    }
                    else
                    {
                        CcNumber.AppendText("0");
                    }
                }
            }
            else
            {
                if (PinNumber.TextLength < 4)
                {
                    PinNumber.AppendText("0");
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
                    //Serialization.SerializeCcPinNumber(CcNumber.Text, PinNumber.Text);
                    SocketConn.SynchronousSocketClient.StartClient(Serialization.SerializeCcPinNumber(CcNumber.Text, PinNumber.Text));
                }
            }
        }
    }
}
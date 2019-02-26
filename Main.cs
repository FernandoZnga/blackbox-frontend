using System.Windows.Forms;

namespace Blackbox.Client
{
    public partial class Main : Form
    {
        public Main()
        {
            //InitializeComponent();
            SocketConn.SynchronousSocketClient.StartClient();
        }
    }
}
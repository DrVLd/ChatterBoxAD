using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChatterBoxAD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            threadReceive = new Thread(new ThreadStart(ReceivedByServer));
            threadReceive.Start();
        }
        //============================================================Receive================================================================================
        Thread threadReceive;
        void ReceivedByServer()
        {
            Socket socketReceive = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            int portReceive = 40000;
            IPEndPoint iPEndPointReceive = new IPEndPoint(IPAddress.Parse("127.0.0.1"), portReceive);
            socketReceive.Bind(iPEndPointReceive);
            socketReceive.Listen(10);
            while (true)
            {
                Socket temp = null;
                try
                {
                    temp = socketReceive.Accept();
                    byte[] messageReceivedByServer = new byte[100];
                    int sizeOfReceivedMessage = temp.Receive(messageReceivedByServer, SocketFlags.None);
                    string str = Encoding.ASCII.GetString(messageReceivedByServer);
                    MessagesLbl.Content =  "\r\nClient: " + str;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace + "\n" + ex.HelpLink + "\n" + ex.InnerException
                            + "\n" + ex.Source + "\n" + ex.TargetSite);
                }
                finally
                {
                    temp.Close();
                }
            }
        }

    }

}

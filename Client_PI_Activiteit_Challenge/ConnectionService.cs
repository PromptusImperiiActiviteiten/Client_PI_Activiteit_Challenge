using Showcase_Client_PI_Activiteit.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Showcase_Client_PI_Activiteit
{
    public class ConnectionService
    {
        public TcpClient client { get; private set; }
        public NetworkStream stream { get; private set; }
        public AbstractState currentActiveState { get; private set; }

        public ConnectionService()
        {
            currentActiveState = new LoginState(this);
        }

        public void ConnectToServer(string ipAddress, int port)
        {

            if (stream !=null && stream.CanRead)
            {
                Thread thread1 = new Thread(() => Program.client.ReadMessages());
                thread1.IsBackground = true;
                thread1.Start();
            }
        }

        public void ReadMessages()
        {

        }

        public void ChangeState(AbstractState newState) {
            currentActiveState = newState;
        }
    }
}

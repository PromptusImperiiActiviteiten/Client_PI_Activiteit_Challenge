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
            /*
             * Zorg dat er een nieuwe TCPclient wordt aangemaakt, dat deze wordt 
             * gelinked aan het "client" attribuut, en dat de Networkstream van deze client 
             * wordt opgehaald en wordt geliked aan het "stream attribuut."
             * 
             * 
             * Let op: laat de code hier onder staan,
             * dit zorgt er voor dat berichten uitgelezen kunnen worden
             * zonder dat het programma vast loopt
             */

            if (stream !=null && stream.CanRead)
            {
                Thread thread1 = new Thread(() => Program.client.ReadMessages());
                thread1.IsBackground = true;
                thread1.Start();
            }
        }

        public void ReadMessages()
        {
            byte[] buffer = new byte[1024];
            int bytesRead;

            /*
             * Zorg dat de stream continu wordt uitgelezen en berichten worden gebruikt 
             * om het juiste resultaat te krijgen
             *
             * Zorg dat het eerste bericht die hier worden afgehandeld begind met een "211:" protocol. 
             * Als dit niet zo is wordt er niets gedaan, als dit wel zo is kun je de chatroom openen, 
             * het bericht laten zien in de chatbox.
             *
             * Zorg hierna dat de alle berichten worden getoont in de chatbox
             *
             * Bonus challenge: Gebruik de Currentstate om het nog makkelijker en uitbreidbaar te maken
             */
        }

        public void ChangeState(AbstractState newState) {
            currentActiveState = newState;
        }
    }
}

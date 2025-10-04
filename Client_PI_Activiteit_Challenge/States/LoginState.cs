using Showcase_Client_PI_Activiteit.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showcase_Client_PI_Activiteit.States
{
    class LoginState(ConnectionService client) : AbstractState(client)
    {
        public override void HandleMessage(string incommingServerMessage)
        {
            /* Dit is deel van een Bonus challenge, 
             * hij is goed te doen maar niet vereist (zie ConnectionService.cs -> ReadMessages() )
             * 
             * Zorg dat de berichten die hier worden afgehandeld beginnen met een "211:" protocol. 
             * Als dit niet zo is wordt er niets gedaan, als dit wel zo is kun je de chatroom openen, 
             * het bericht laten zien in de chatbox en de client state veranderen naar de volgende state
             */
        }
    }
}

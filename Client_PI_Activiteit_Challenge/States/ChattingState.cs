using Showcase_Client_PI_Activiteit.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Showcase_Client_PI_Activiteit.States
{
    class ChattingState(ConnectionService client) : AbstractState(client)
    {

        public override void HandleMessage(string incommingServerMessage)
        {
             /* 
              * Dit is deel van een Bonus challenge, 
              * hij is goed te doen maar niet vereist (zie ConnectionService.cs -> ReadMessages() )
              * 
              * zorg dat binnenkomende berichten worden getoond in de chatbox, 
              * als je dat mooier vindt kun je kijken of je het protocol 
              * gedeelte van een bericht af kan halen voor hij wordt getoont in de chatbox.
              */
        }
    }
}

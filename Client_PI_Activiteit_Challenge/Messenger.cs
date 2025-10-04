using Showcase_Client_PI_Activiteit.WindowsForms;
using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;


namespace Showcase_Client_PI_Activiteit
{
    class Messenger
    {
        public static void SendChatMessage(string rawOutgoingChatMessage, NetworkStream clientNetworkStream)
        {
            /*
             * Zorg dat deze functie berichten kan versturen met een "101:" protocol
             * en dat het bericht getoond wordt in jou eigen chatbox
             *
             * Bonus Challenge 1: zet iets van "ik:" of "You:" in de chatbox
             * en zorg dat het protocol gedeelte niet wordt getoond.
             * 
             * Bonus Challenge 2: Zorg dat het systeem een "102:" bericht stuurt als 
             * jouw bericht begind met "/whisper:[naam];".
             * Dit stuurt namelijk het bericht alleen naar degene met die naam.
             */
        }

        public static void SendInitializingMessage(string newClientName, NetworkStream clientNetworkStream)
        {
            /*
             *  Zorg dat deze functie een bericht verstuurd met het "111:" protocol
             */
        }
    }
}

using System.Net.Sockets;


namespace Showcase_Client_PI_Activiteit
{
    class Messenger
    {
        public static void SendChatMessage(string rawOutgoingChatMessage, NetworkStream clientNetworkStream) {
            byte[] data;
            string messageToSend;
            /*
             * Zorg dat het bericht dat verstuurd gaat worden opgeslagen wordt in het "messageToSend" variabelen
             * Dit bericht bestaat uit het protocol "101:" gevolgd door het bericht (hint: dit is het rawOutgoingChatMessage parameter)
             * Zet de string die verstuurd wordt om naar een byte array en sla deze op in de "data" variabelen
             * Stuur het bericht door naar de Server en toon het bericht in jouw eigen chatbox.
             *
             * Bonus Challenge 1: zet iets van "ik:" of "You:" in de chatbox
             * en zorg dat het protocol gedeelte niet wordt getoond.
             * 
             * Bonus Challenge 2: Zorg dat het systeem een "102:" bericht stuurt als 
             * jouw bericht begind met "/whisper:[naam];".
             * Dit stuurt namelijk het bericht alleen naar degene met die naam.
             */
        }

        public static void SendInitializingMessage(string newClientName, NetworkStream clientNetworkStream) {
            byte[] data;
            string messageToSend;
            /*
             * Zorg dat het bericht dat verstuurd gaat worden opgeslagen wordt in het "messageToSend" variabelen
             * Dit bericht bestaat uit het protocol "111:" gevolgd door de opgegeven naam (hint: dit is het newClientName parameter)
             * Zet de string die verstuurd wordt om naar een byte array en sla deze op in de "data" variabelen
             * Stuur tenslotte het bericht door naar de Server
             */
        }
    }
}

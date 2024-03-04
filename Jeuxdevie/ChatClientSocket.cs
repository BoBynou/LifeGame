using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Jeuxdevie
{
    public class ChatClientSocket
    {
        private TcpClient _client;
        private readonly string _serverIp;
        private readonly int _port;
        public static TextBox swftbChat;

        public ChatClientSocket(string serverIp, int port)
        {
            _serverIp = serverIp;
            _port = port;
        }

        public async Task ConnectAsync()
        {
            _client = new TcpClient();
            await _client.ConnectAsync(_serverIp, _port);
            Debug.WriteLine("Connecté au serveur.");

            await Task.Run(() => ReceiveMessages());
        }

        private void ReceiveMessages()
        {
            try
            {
                NetworkStream stream = _client.GetStream();
                byte[] buffer = new byte[1024];
                int bytesRead;

                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    Debug.WriteLine("Message reçu client : " + message);
                    UpdateTextBoxChat(message);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Une erreur est survenue lors de la réception des messages : " + ex.Message);
            }
        }

        public async Task SendMessageAsync(string message)
        {
            try
            {
                Database db = new Database();
                string user = db.GetUserById(Services.UserId);

                message = user + " : " + message;

                NetworkStream stream = _client.GetStream();
                byte[] buffer = Encoding.ASCII.GetBytes(message);
                await stream.WriteAsync(buffer, 0, buffer.Length);
                Debug.WriteLine("Message envoyé : " + message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Une erreur est survenue lors de l'envoi du message : " + ex.Message);
            }
        }

        private void UpdateTextBoxChat(string message)
        {
            // Utilisez BeginInvoke pour mettre à jour la TextBox depuis un autre thread.
            swftbChat.BeginInvoke(new Action(() => swftbChat.AppendText(message + Environment.NewLine)));
        }
    }
}

using Microsoft.VisualBasic.Logging;
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
    internal class ChatServerSocket
    {
        private TcpListener _listener;
        private readonly int _port;
        private List<TcpClient> _clients = new List<TcpClient>();

        public ChatServerSocket(int port)
        {
            _port = port;
        }

        public async Task StartAsync()
        {
            try
            {
                _listener = new TcpListener(IPAddress.Loopback, _port);
                _listener.Start();
                Debug.WriteLine("Serveur démarré.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
           

            try
            {
                while (true)
                {
                    TcpClient client = await _listener.AcceptTcpClientAsync();
                    Debug.WriteLine("Client connecté.");
                    _clients.Add(client);

                    Task.Run(() => HandleClientAsync(client));
                }
            }
            finally
            {
                _listener.Stop();
            }
        }

        private async Task HandleClientAsync(TcpClient client)
        {
            try
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int bytesRead;

                while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    Debug.WriteLine("Message reçu serveur : " + message);

                    // Broadcast du message à tous les clients connectés
                    await BroadcastAsync(message);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Une erreur est survenue lors de la gestion du client : " + ex.Message);
            }
            finally
            {
                _clients.Remove(client);
                client.Close();
                Debug.WriteLine("Client déconnecté.");
            }
        }

        private async Task BroadcastAsync(string message)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(message);

            foreach (TcpClient client in _clients)
            {
                NetworkStream stream = client.GetStream();
                await stream.WriteAsync(buffer, 0, buffer.Length);
            }
        }
    }

}

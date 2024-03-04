using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeGame
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer gameTimer;
        private bool isGameRunning = false;
        private readonly Database dbConnection;
        IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Loopback, 80);

        public Form1()
        {
            InitializeComponent();
            dbConnection = new Database();
            InitializeEmptyGrid();
        }

        private async void swfbConnexion_Click(object sender, EventArgs e)
        {
            if (dbConnection.ValidateUser(swftbLogin.Text, swftbMDP.Text))
            {
                tabControl1.SelectedTab = tabPage2;
                InitializeTimer();
                StartClient();
                StartServer();

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbConnection.CloseConnection();
        }

        private void swfbInscription_Click(object sender, EventArgs e)
        {
        }
        #region LifeGame
        private void InitializeEmptyGrid()
        {
            // Remplacez 10 par le nombre de lignes et de colonnes souhaité
            for (int i = 0; i < 50; i++)
            {
                swfdgvDataGrid.Columns.Add(i.ToString(), string.Empty);
            }
            for (int i = 0; i < 50; i++)
            {
                swfdgvDataGrid.Rows.Add();
                for (int j = 0; j < 50; j++)
                {
                    swfdgvDataGrid.Rows[i].Cells[j].Value = string.Empty; // 0 représente une cellule morte
                }
            }
        }

        private void swfdgvDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            swfdgvDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
            swfdgvDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == string.Empty ? "0" : string.Empty;
        }

        private void InitializeTimer()
        {
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 500;
            gameTimer.Tick += GameTimer_Tick;
        }

        private void swfbStart_Click(object sender, EventArgs e)
        {
            isGameRunning = true;
            swfbStart.Enabled = false;
            swfbStop.Enabled = true;
            gameTimer.Start();
        }

        private void swfbStop_Click(object sender, EventArgs e)
        {
            isGameRunning = false;
            swfbStart.Enabled = true;
            swfbStop.Enabled = false;
            gameTimer.Stop();
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (isGameRunning)
            {
                // Ajoutez ici la logique pour mettre à jour l'état du jeu en fonction des règles du jeu de la vie
                UpdateGameState();
            }
        }

        private void UpdateGameState()
        {
            int numRows = swfdgvDataGrid.Rows.Count;
            int numCols = swfdgvDataGrid.Columns.Count;

            // Créez une copie de l'état actuel de la grille pour éviter de modifier en cours d'itération
            string[,] currentGridState = new string[numRows, numCols];

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    currentGridState[i, j] = swfdgvDataGrid.Rows[i].Cells[j].Value.ToString();
                }
            }

            // Créez une nouvelle grille pour stocker le nouvel état
            string[,] newGridState = new string[numRows, numCols];

            // Appliquez les règles du jeu de la vie à chaque cellule
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    int neighborsAlive = CountAliveNeighbors(currentGridState, i, j);

                    // Appliquez les règles du jeu de la vie
                    if (currentGridState[i, j] == "0") // Cellule vivante
                    {
                        if (neighborsAlive == 2 || neighborsAlive == 3)
                            newGridState[i, j] = "0"; // Reste vivante
                        else
                            newGridState[i, j] = string.Empty; // Meurt
                    }
                    else // Cellule morte
                    {
                        if (neighborsAlive == 3)
                            newGridState[i, j] = "0"; // Naissance
                        else
                            newGridState[i, j] = string.Empty; // Reste morte
                    }

                    // Mettez à jour la cellule correspondante dans le DataGridView
                    swfdgvDataGrid.Rows[i].Cells[j].Value = newGridState[i, j];
                }
            }
        }

        private int CountAliveNeighbors(string[,] grid, int row, int col)
        {
            int count = 0;

            int numRows = grid.GetLength(0);
            int numCols = grid.GetLength(1);

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int neighborRow = row + i;
                    int neighborCol = col + j;

                    // Vérifiez que le voisin est dans la grille
                    if (neighborRow >= 0 && neighborRow < numRows && neighborCol >= 0 && neighborCol < numCols)
                    {
                        // Excluez la cellule elle-même
                        if (!(i == 0 && j == 0))
                        {
                            int toto = 0;
                            if (grid[neighborRow, neighborCol] == string.Empty)
                                toto = 0;
                            else
                                toto = 1;
                            count += toto;
                        }
                    }
                }
            }

            return count;
        }
        #endregion

        #region Chat

        private TcpListener server;

        private async void StartServer()
        {

            Socket listener = new Socket(
                ipEndPoint.AddressFamily,
                SocketType.Stream,
                ProtocolType.Tcp);

            listener.Bind(ipEndPoint);
            listener.Listen(100);

            var handler = await listener.AcceptAsync();
            while (true)
            {
                // Receive message.
                var buffer = new byte[1_024];
                SocketAsyncEventArgs test = new SocketAsyncEventArgs();
                test.SetBuffer(buffer, 0, buffer.Length);
                var received = handler.ReceiveAsync(test);
                var response = Encoding.UTF8.GetString(buffer, 0, Convert.ToInt32(received));

                var eom = "<|EOM|>";
                if (response.IndexOf(eom) > -1 /* is end of message */)
                {
                    Console.WriteLine(
                        $"Socket server received message: \"{response.Replace(eom, "")}\"");

                    var ackMessage = "<|ACK|>";
                    var echoBytes = Encoding.UTF8.GetBytes(ackMessage);
                    //await handler.SendAsync(echoBytes, 0);
                    Console.WriteLine(
                        $"Socket server sent acknowledgment: \"{ackMessage}\"");

                    break;
                }
                // Sample output:
                //    Socket server received message: "Hi friends 👋!"
                //    Socket server sent acknowledgment: "<|ACK|>"
            }
        }


        private async void StartClient()
        {
            Socket client = new Socket(
                ipEndPoint.AddressFamily,
                SocketType.Stream,
                ProtocolType.Tcp);

            await client.ConnectAsync(ipEndPoint);
            _ = Task.Run(async () =>
            {
                while (true)
                {
                    // Send message.
                    var message = "titi";
                    var messageBytes = Encoding.UTF8.GetBytes(message);
                    SocketAsyncEventArgs test2 = new SocketAsyncEventArgs();
                    test2.SetBuffer(messageBytes, 0, messageBytes.Length);
                    //var received = client.ReceiveAsync(test2);
                    var sended = client.SendAsync(test2);
                    //Console.WriteLine($"Socket client sent message: \"{message}\"");

                    // Receive ack.
                    var buffer = new byte[1_024];
                    SocketAsyncEventArgs test = new SocketAsyncEventArgs();
                    test.SetBuffer(buffer, 0, buffer.Length);
                    var received = client.ReceiveAsync(test);
                    var response = Encoding.UTF8.GetString(buffer, 0, Convert.ToInt32(received));
                    //Console.WriteLine($"Réponse: \"{response}\"");
                    // Sample output:
                    //     Socket client sent message: "Hi friends 👋!<|EOM|>"
                    //     Socket client received acknowledgment: "<|ACK|>"
                }
                client.Shutdown(SocketShutdown.Both);
            });
        }

                
        private void ListenForMessages()
        {
            
            
            
        }



        private void DisplayMessage(string message)
        {
            // Affichez le message dans la zone de texte du chat
            if (swftbChat.InvokeRequired)
            {
                swftbChat.Invoke(new Action<string>(DisplayMessage), message);
            }
            else
            {
                swftbChat.AppendText(message + Environment.NewLine);
            }
        }

        private void SendMessage(string message)
        {
            try
            {
   
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur d'écriture sur la connexion : {ex.Message}");
                // Gérez la fermeture de la connexion ici
            }
        }


        private void swfbSendMessage_Click(object sender, EventArgs e)
        {
            // Lorsque le bouton d'envoi est cliqué, envoyez le message saisi à l'autre utilisateur
            
            string message = swftbMessage.Text;

//            SendMessage(message);

            // Effacez la zone de texte du message après l'envoi
            swftbMessage.Clear();
        }

        #endregion
    }
}

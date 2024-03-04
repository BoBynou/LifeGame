using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Jeuxdevie
{
    public partial class k : Form
    {
        private System.Windows.Forms.Timer gameTimer;
        private bool isGameRunning = false;
        private readonly Database dbConnection;
        public static ChatClientSocket client;

        public k()
        {
            InitializeComponent();
            dbConnection = new Database();
            client = new ChatClientSocket("127.0.0.1", 80);
        }

        private async void swfbConnexion_Click(object sender, EventArgs e)
        {
            if (dbConnection.ValidateUser(swftbLogin.Text, swftbMDP.Text))
            {
                tabControl1.SelectedTab = tabPage2;
                InitializeTimer();
                ChatClientSocket.swftbChat = swftbChat;
                ChatServerSocket server = new ChatServerSocket(80);
                server.StartAsync();
                Services.IniClient();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbConnection.CloseConnection();
        }

        private void swfbInscription_Click(object sender, EventArgs e)
        {
            dbConnection.CreateUser(swftbLogin.Text, swftbMDP.Text);
        }
        #region LifeGame
        private void InitializeEmptyGrid()
        {
            swfdgvDataGrid.Columns.Clear();

            // Remplacez 10 par le nombre de lignes et de colonnes souhaité
            for (int i = 0; i < swfnudGridSize.Value; i++)
            {
                swfdgvDataGrid.Columns.Add(i.ToString(), string.Empty);
                swfdgvDataGrid.Columns[i].Width = 20;
            }
            for (int i = 0; i < swfnudGridSize.Value; i++)
            {
                swfdgvDataGrid.Rows.Add();
                for (int j = 0; j < swfnudGridSize.Value; j++)
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
            InitializeEmptyGrid();
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

            for (int i = 0; i < numRows - 1; i++)
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
                    int neighborsAlive = Services.CountAliveNeighbors(currentGridState, i, j);

                    // Appliquez les règles du jeu de la vie
                    if (currentGridState[i, j] == "0") // Cellule vivante
                    {
                        //if (neighborsAlive == 2 || neighborsAlive == 3)
                        if (neighborsAlive == swfnudLive.Value)
                            newGridState[i, j] = "0"; // Reste vivante
                        else
                            newGridState[i, j] = string.Empty; // Meurt
                    }
                    else // Cellule morte
                    {
                        //if (neighborsAlive == 3)
                        if (neighborsAlive == swfnudKill.Value)
                            newGridState[i, j] = "0"; // Naissance
                        else
                            newGridState[i, j] = string.Empty; // Reste morte
                    }

                    // Mettez à jour la cellule correspondante dans le DataGridView
                    swfdgvDataGrid.Rows[i].Cells[j].Value = newGridState[i, j];
                }
            }
        }


        #endregion


        private async void swfbSendMessage_Click(object sender, EventArgs e)
        {
            // Lorsque le bouton d'envoi est cliqué, envoyez le message saisi à l'autre utilisateur

            string message = swftbMessage.Text;

            //client.ConnectAsync();
            client.SendMessageAsync(message);
            ChatServerSocket server = new ChatServerSocket(80);
            server.StartAsync();


            // Effacez la zone de texte du message après l'envoi
            swftbMessage.Clear();
        }
    }
}

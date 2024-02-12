using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeGame
{
    public partial class Form1 : Form
    {
        private Timer gameTimer;
        private bool isGameRunning = false;
        private readonly Database dbConnection;
        public Form1()
        {
            InitializeComponent();
            dbConnection = new Database();
            InitializeEmptyGrid();
        }

        private void swfbConnexion_Click(object sender, EventArgs e)
        {
            if (dbConnection.ValidateUser(swftbLogin.Text, swftbMDP.Text))
            {
                tabControl1.SelectedTab = tabPage2;
                InitializeTimer();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbConnection.CloseConnection();
        }

        private void swfbInscription_Click(object sender, EventArgs e)
        {
        }

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
            gameTimer = new Timer();
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


    }
}

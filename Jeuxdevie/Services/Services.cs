using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeuxdevie
{
    public static class Services
    {
        public static int UserId;
        public static async Task IniClient()
        {
            ChatServerSocket server = new ChatServerSocket(80);
            await MainForm.client.ConnectAsync();

            Console.WriteLine("Connecté au serveur. Vous pouvez commencer à envoyer des messages.");

            while (true)
            {
                string input = Console.ReadLine();
                await MainForm.client.SendMessageAsync(input);
            }
            //server.StartAsync();
        }

        public static int CountAliveNeighbors(string[,] grid, int row, int col)
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

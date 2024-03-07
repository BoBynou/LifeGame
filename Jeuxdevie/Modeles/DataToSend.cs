using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeuxdevie
{
    internal class DataToSend
    {
        public decimal NbCellsToKill { get; set; }
        public decimal NbCellsToLive { get; set; }

        public decimal GridSize {  get; set; }

        public DataToSend(decimal nbCellsToKill, decimal nbCellsToLive, decimal gridSize)
        {
            NbCellsToKill = nbCellsToKill;
            NbCellsToLive = nbCellsToLive;
            GridSize = gridSize;
        }
    }
}
   
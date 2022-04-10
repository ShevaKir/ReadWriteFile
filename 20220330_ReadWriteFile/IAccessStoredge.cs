using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220330_ReadWriteFile
{
    interface IAccessStoredge
    {
        void Add(Player player);

        IEnumerable<Player> GetPlayers();
    }
}

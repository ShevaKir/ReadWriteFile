using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace _20220330_ReadWriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            const string NAME_FILE = "players.csv";

            IAccessStoredge players = new FileAccessor(NAME_FILE);

            foreach (var item in players.GetPlayers())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

            //FileInfo fileInfo = new FileInfo(NAME_FILE);

            //if (fileInfo.Exists)
            //{
            //    fileInfo.Delete();
            //}
        }
    }
}

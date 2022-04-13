using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace _20220330_ReadWriteFile
{
    class FileAccessor : IAccessStoredge
    {
        public string _path;

        public FileAccessor(string path)
        {
            _path = path;
        }

        public void Add(Player player)
        {       
            File.AppendAllText(_path, player.ToString() + '\n');
        }

        IEnumerable<Player> IAccessStoredge.GetPlayers()
        {
            string[] parseDataPlayer = File.ReadAllText(_path).Split('\n');

            for (int i = 0; i < parseDataPlayer.Length - 1; i++)
            {
                string[] player = parseDataPlayer[i].Split(';');

                Player currentPlayer = new Player();

                currentPlayer.Name = player[0];
                currentPlayer.Surname = player[1];
                currentPlayer.IdTeam = int.Parse(player[2]);
                currentPlayer.NumberPlayer = int.Parse(player[3]);
                currentPlayer.Role = (Position)Enum.Parse(typeof(Position), player[4]); ;

                yield return currentPlayer;
            }
        }
    }
}

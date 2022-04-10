using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220330_ReadWriteFile
{
    static class UI
    {
        public static void ShowMenu()
        {
            Console.WriteLine("1. Show Players");
            Console.WriteLine("2. Add Player");
        }

        public static void ShowPlayers(string players)
        {
            Console.WriteLine(players);
        }

        public static Player GetPlayer()
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилия: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите команда: ");
            int idTeam = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите нумер: ");
            int numberPlayer = int.Parse(Console.ReadLine());
            Console.WriteLine("Позиция:\n 0 - нападающий\n 1 - полузащитник\n 2 - Защитник\n 3 - Вратарь\n ");
            int role = int.Parse(Console.ReadLine());

            return new Player() { Name = name, Surname = surname, IdTeam = idTeam, NumberPlayer = numberPlayer, Role = (Position)role };

        }
    }
}

using System;

namespace vn_mode_csharp_dz_38
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Виталий", 31, 100);
            player1.ShowInfo();
        }

        class Player
        {
            private string _name;
            private int _age;
            private int _health;

            public Player(string name, int age, int health)
            {
                _name = name;
                _age = age;
                _health = health;
            }

            public void ShowInfo()
            {
                Console.Write($"Имя игрока: {_name}\nВозраст игрока: {_age}\nЗдоровье игрока: {_health}");
            }
        }
    }
}


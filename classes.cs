using System;
namespace _2_laba_3_1_1
{
    class Card
    {
        public string name = "Undefined";
        public int mana;
        public int attack;
        public int protection;
        public void Print()
        {
            Console.WriteLine($"Имя карты: {name}\n Стоимость в мане: {mana}\n Урон/ХП {attack}/{protection}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Card Knight = new Card();
            Knight.name = "Рыцарь";
            Knight.mana = 5;
            Knight.attack = 5;
            Knight.protection = 5;
            Knight.Print();
            Card Mage = new Card();
            Mage.name = "Маг";
            Mage.mana = 7;
            Mage.attack = 9;
            Mage.protection = 3;
            Mage.Print();
            Card Crest = new Card();
            Crest.name = "Крестьянин";
            Crest.mana = 1;
            Crest.attack = 1;
            Crest.protection = 2;
            Crest.Print();
            Console.WriteLine("Хотите создать свою карту? Да/Нет");
            string responce = Console.ReadLine();
            if (responce == "Да")
            {
                Card PlayerCard = new Card();
                Console.WriteLine("Введите имя карты:");
                PlayerCard.name = Console.ReadLine();
                Console.WriteLine("Введите стоимость в мане:");
                PlayerCard.mana = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите силу карты (урон):");
                PlayerCard.attack = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите здоровье карты (ХП):");
                PlayerCard.protection = int.Parse(Console.ReadLine());
                PlayerCard.Print();
            }
        }
    }
}

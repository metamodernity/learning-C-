using System;
namespace _2_laba_3_1_1
{
    class Card
    {
        public string name = "Undefined";
        public string type = "Undefined";
        public string text = "Undefined";
        public int mana;
        public int attack;
        public int hp;
        public void Print()
        {
            Console.WriteLine($"Имя карты: {name}\n Стоимость в мане: {mana}\n Урон/ХП {attack}/{hp}\n Тип карты: {type}\n Описание:\n {text}\n================================================");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("Библиотека карт:");
            Console.WriteLine("================================================");
            Card Knight = new Card();
            Knight.name = "Рыцарь";
            Knight.type = "Человек";
            Knight.mana = 5;
            Knight.attack = 5;
            Knight.hp = 5;
            Knight.text = "Без храбрости рыцарей королевство падёт.";
            Knight.Print();
            Card Mage = new Card();
            Mage.name = "Маг";
            Mage.type = "Человек";
            Mage.mana = 7;
            Mage.attack = 9;
            Mage.hp = 3;
            Mage.text = "За его скромной внешностью\n скрывается настоящий талант.";
            Mage.Print();
            Card Bard = new Card();
            Bard.name = "Бард";
            Bard.type = "Человек";
            Bard.mana = 3;
            Bard.attack = 2;
            Bard.hp = 4;
            Bard.text = "Такие как он вселяют надежду в людей.";
            Bard.Print();
            Card Dragon = new Card();
            Dragon.name = "Красный дракон";
            Dragon.type = "Дракон";
            Dragon.mana = 10;
            Dragon.attack = 10;
            Dragon.hp = 15;
            Dragon.text = "Легенды не врали...";
            Dragon.Print();
            Card Crest = new Card();
            Crest.name = "Крестьянин";
            Crest.type = "Человек";
            Crest.mana = 1;
            Crest.attack = 1;
            Crest.hp = 2;
            Crest.text = "Порой при виде пешек дрожат короли.";
            Crest.Print();
            Console.WriteLine("Хотите создать свою карту? Да/Нет");
            string responce = Console.ReadLine();
            if (responce == "Да")
            {
                Card PlayerCard = new Card();
                Console.WriteLine("Введите имя карты:");
                PlayerCard.name = Console.ReadLine();
                Console.WriteLine("Введите тип карты:");
                PlayerCard.type = Console.ReadLine();
                Console.WriteLine("Введите стоимость в мане:");
                PlayerCard.mana = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите силу карты (урон):");
                PlayerCard.attack = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите здоровье карты (ХП):");
                PlayerCard.hp = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите описание карты:");
                PlayerCard.text = Console.ReadLine();
                PlayerCard.Print();
            }
            if(responce == "Нет")
            {
                Console.WriteLine("\n");
            }
        }
    }
    class Fight
    {
        public void LetsFight()
        {
            Console.WriteLine("Битва начинается!");
            Console.WriteLine("Выберите 1 карту:");
            Console.WriteLine("Выберите 2 карту:");
        }
    }
}

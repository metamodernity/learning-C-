
using System;

namespace datainput
{
    class datainput
    {
        static void Main(string[] args)
        { 
            string data;
            Console.WriteLine("Введите ваше имя:");
            data = Console.ReadLine();
            Console.WriteLine("Привет " + data + "!");
        }
    }
}

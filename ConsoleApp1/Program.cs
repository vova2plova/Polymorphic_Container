using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Conteiner conteiner = new Conteiner();
            string s;
            int x = 0;
            string name, name2;
            int num;
            int menu = 0;

            do
            {
                Console.WriteLine("1 - Принять сотрудника");
                Console.WriteLine("2 - Уволить сотрудника");
                Console.WriteLine("3 - Удалить документ");
                Console.WriteLine("4 - Вывести информацию");
                Console.WriteLine("5 - Вывести информацию о документе");
                menu = Int32.Parse(Console.ReadLine());
                if (menu == 1)
                {
                    Console.WriteLine("Введите ФИО");
                    name = Console.ReadLine();
                    Console.WriteLine("Введите должность");
                    name2 = Console.ReadLine();
                    conteiner.add(new Priem(name, name2));
                }
                if (menu == 2)
                {
                    Console.WriteLine("Введите ФИО");
                    name = Console.ReadLine();
                    Console.WriteLine("Введите должность");
                    name2 = Console.ReadLine();
                    conteiner.add(new Yvolit(name, name2));
                }
                if (menu == 3)
                {
                    conteiner.delete();
                }
                if (menu == 4)
                {
                    Console.WriteLine(conteiner.getAllData());
                }
                if (menu == 5)
                {
                    Console.WriteLine("Введите номер документа");
                    x = Int32.Parse(Console.ReadLine());
                    if (conteiner.getDocs(x) != null)
                        Console.WriteLine(conteiner.getDocs(x).print());
                    else
                        Console.WriteLine("Такого документа нет");
                }
            }   
            while (menu != 0);

        }
    }
}

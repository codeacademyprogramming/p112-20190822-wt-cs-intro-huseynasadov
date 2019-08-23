using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_WT_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adinizi daxil edin :");
            string Name = Console.ReadLine();
            Console.WriteLine("Soyadinizi daxil edin :");
            string Surname = Console.ReadLine();
            Console.WriteLine("Sexsiyyet vesiqenizin Seriya nomresini daxil edin :");
            int IDNumber = int.Parse(Console.ReadLine());
            Menu menu = new Menu();
            menu.menu();
            int n = int.Parse(Console.ReadLine());
            Account account = new Account(Name, Surname, IDNumber);

            while (n !=0)
            {
                switch (n)
                {

                    case 1:

                        Console.WriteLine($"Sizin hal-hazirki balansiniz : {account.Balans} AZN teskil edir");
                        menu.menu();
                        n = int.Parse(Console.ReadLine());

                        break;
                    case 2:
                        Console.WriteLine("Artirilacaq meblegi daxil edin");
                        Double PlusBalans = Double.Parse(Console.ReadLine());
                        account.Balans += PlusBalans;
                        Console.WriteLine($"Balansiniz {PlusBalans} AZN artirildi.");
                        menu.menu();
                        n = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Azaldilacaq meblegi daxil edin");
                        Double MinusBalans = Double.Parse(Console.ReadLine());
                        account.Balans -= MinusBalans;
                        if (account.Balans < 0)
                        {
                            Console.WriteLine("Balansinizda kifayet qeder mebleg yoxdur xahis edirik duzgun mebleg daxil edesiniz");
                            account.Balans += MinusBalans;
                        }
                        else
                        {
                            Console.WriteLine($"Balansinizdan {MinusBalans} AZN azaldildi.");
                        }
                        menu.menu();
                        n = int.Parse(Console.ReadLine());
                        break;

                }
            }
           
        }

    }
}

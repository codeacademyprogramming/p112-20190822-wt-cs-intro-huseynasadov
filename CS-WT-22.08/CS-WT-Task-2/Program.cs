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
            // Hesabin yaradilmasi
            Console.Write("Adinizi daxil edin : ");
        name: string Name = Console.ReadLine();
            if (Name == "")
            {
                Console.Write("Adinizi duzgun daxil edin : ");
                goto name;
            }
            Console.Write("Soyadinizi daxil edin : ");
        surname: string Surname = Console.ReadLine();
            if (Surname == "")
            {
                Console.Write("Soyadinizi duzgun daxil edin : ");
                goto surname;
            }
            Console.Write("Sexsiyyet vesiqenizin Seriya nomresini daxil edin: AZE N: ");
        id: string IDNumber = Console.ReadLine();
            if (IDNumber.ToString() == "")
            {
                Console.Write("Seriya nomrenizi duzgun daxil edin : ");

                goto id;
            }
            Menu menu = new Menu();
            menu.menu();
            int n = int.Parse(Console.ReadLine());
            Account account = new Account(Name, Surname, int.Parse(IDNumber));

            // Emeliyyatlarin secilmesi
            while (n != 0)
            {
                switch (n)
                {
                    // Balansin gosterilmesi
                    case 1:
                        account.Allinfo();
                        Console.WriteLine($"\nSizin hal-hazirki balansiniz : {account.Balans} AZN teskil edir");
                        menu.menu();
                        n = int.Parse(Console.ReadLine());

                        break;

                    // Balansin artirilmasi
                    case 2:
                        Console.WriteLine("\nArtirilacaq meblegi daxil edin");
                        Double PlusBalans = Double.Parse(Console.ReadLine());
                        account.Balans += PlusBalans;
                        Console.WriteLine($"\nBalansiniz {PlusBalans} AZN artirildi.");
                        menu.menu();
                        n = int.Parse(Console.ReadLine());
                        break;

                    // Balansin azaldilmasi
                    case 3:
                        Console.WriteLine("\nAzaldilacaq meblegi daxil edin");
                        Double MinusBalans = Double.Parse(Console.ReadLine());
                        account.Balans -= MinusBalans;
                        if (account.Balans < 0)
                        {
                            Console.WriteLine("\nBalansinizda kifayet qeder mebleg yoxdur xahis edirik duzgun mebleg daxil edesiniz");
                            account.Balans += MinusBalans;
                        }
                        else
                        {
                            Console.WriteLine($"\nBalansinizdan {MinusBalans} AZN azaldildi.");
                        }
                        menu.menu();
                        n = int.Parse(Console.ReadLine());
                        break;

                    // Hesabda deyisiklik edilmesi
                    case 4:
                        Console.WriteLine("\nAdinizi daxil edin :");
                        string chgName = Console.ReadLine();
                        if (chgName == "")
                        {
                            Console.WriteLine("\nHesabin deyisdirilmesi ugursuz neticelendi");
                            menu.menu();
                            n = int.Parse(Console.ReadLine());
                            break;
                        }
                        else
                        {
                            account.Name = chgName;
                            Console.WriteLine("\nSoyadinizi daxil edin :");
                            string chgSurname = Console.ReadLine();
                            if (chgSurname == "")
                            {
                                Console.WriteLine("\nHesabin deyisdirilmesi ugursuz neticelendi");
                                account.Name = Name;
                                menu.menu();
                                n = int.Parse(Console.ReadLine());
                                break;
                            }
                            else
                            {
                                account.Surname = chgSurname;
                                Console.WriteLine("\nSexsiyyet vesiqenizin Seriya nomresini daxil edin :");
                                string chgId = Console.ReadLine();
                                if (chgId == "")
                                {
                                    Console.WriteLine("\nHesabin deyisdirilmesi ugursuz neticelendi");
                                    account.Surname = Surname;
                                    account.Name = Name;
                                    menu.menu();
                                    n = int.Parse(Console.ReadLine());
                                    break;
                                }
                                else
                                {
                                    account.IDNumber = int.Parse(chgId);
                                    Console.WriteLine("\nHesabin deyisdirilmesi Ugurla Basa catdi!\n");
                                }
                            }
                        }

                        menu.menu();
                        n = int.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("\nDuzgun emeliyyat secin");
                        menu.menu();
                        n = int.Parse(Console.ReadLine());
                        break;
                }

            }

        }

    }
}

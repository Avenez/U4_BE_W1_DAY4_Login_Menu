using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            User.Nome = "Alvise";
            User.Cognome = "Veneziano";
            User.Email = "alvise@gmail.com";
            User.Password = "admin";

            bool mainStart = true;

            do
            {
                string choise;
                Console.WriteLine("Scegli l'operazione da effettuare:");
                Console.WriteLine("\n1: Login");

                Console.WriteLine("\n2: Logout");

                Console.WriteLine("\n3: Verifica ora e data di login");

                Console.WriteLine("\n4: Lista degli accessi");

                Console.WriteLine("\n5: Esci");
                choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        User.LogIn();
                        break;
                    case "2":
                        User.LogOut();
                        break;
                    case "3":
                        User.getlastLogin();
                        break;
                    case "4":
                        User.getLoginLog();
                        break;
                    case "5":
                        mainStart = false;
                        break;
                    default:
                        Console.WriteLine("Scelta non valida. Riprova.");
                        break;
                }

            } while (mainStart);





            Console.WriteLine();


        }
    }
}

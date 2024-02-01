using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Menu
{
    internal static class User
    {
        private static string nome;
        private static string cognome;
        private static string email;
        private static string password;
        private static bool isLogged;
        private static ArrayList loginLog = new ArrayList(); 

        //public User() { }

       /* public User(string nome, string cognome) {
        
            this.nome = nome;
            this.cognome = cognome;
        }*/

       public static string Nome{

            set => nome = value;
            get => nome;
        }

        public static string Cognome {
        
            get => cognome;
            set => cognome = value;
        
        }

        public static string Email { 
        
            get => email;
            set => email = value;

        }

        public static string Password {
        
            get => password; 
            set => password = value;
        }




        public static void setIsLogged () {
            if (isLogged)
            {
                isLogged = false;
            }
            else {
                isLogged = true;
            }
            //isLogged = !isLogged;
        }


        // Un metodo per il logout
        public static void LogOut() {
            Console.WriteLine("-------------------------------------------------");
            if (isLogged)
            {

                Console.WriteLine("Logout effettuato con successo !");
                
                isLogged = false;
            }
            else {
                Console.WriteLine("Prima di fare il LogOut devi Loggarti IDIOTA !");
                isLogged = false;
            }

            //per il momento ho solo un utente che andrò a inserire tramite main.

            //User.nome = null;
            //User.email = null;
            //User.password = null;

            Console.WriteLine("-------------------------------------------------");
        }


        //Un metodo per stampare il registro dei login
        public static void getLoginLog() {
            Console.WriteLine("-------------------------------------------------");

            if (isLogged) {
                Console.WriteLine("Questo è il registro dei tuoi Login");
                foreach (string log in loginLog)
                {
                    Console.WriteLine(log);
                }
            } else {

                Console.WriteLine("Devi essere loggato per conoscere queste infommazioni ! \nNon ti insulterò mai abbastanza");

            }

            Console.WriteLine("-------------------------------------------------");
        }


        //Ottengo l'ultimo loggin effettuato se sono loggato
        public static void getlastLogin() {
            Console.WriteLine("-------------------------------------------------");



            if (loginLog.Count > 0 && isLogged == true)
            {
                int lastLoginPosition = loginLog.Count - 1;
                Console.WriteLine($"Il tuo login è stato effettuato il: \n {loginLog[lastLoginPosition]}");

            }
            else if (loginLog.Count >= 0 && isLogged == false) {

                Console.WriteLine("Devi prima effettuare il login per conoscere queste informazioni");
            
            }else {
                Console.WriteLine("Non ci sono login da segnalare");
            }



            Console.WriteLine("-------------------------------------------------");
        }


        // controllo email è password che siasno qelle ottenute alla registazione.
        // In caso affermativo cambio lo stato di loggin
        public static void LogIn() 
        {
            Console.WriteLine("-------------------------------------------------");
            if (isLogged)
            {

                Console.WriteLine("Sei gia Loggato IDIOTA !");

            }
            else
            {




                bool retry = true;



                do
                {
                    string insEmail;
                    string insPassword;
                    Console.WriteLine("Se desideri effettuare il Login Inserisci la tua email:");
                    insEmail = Console.ReadLine();

                    Console.WriteLine("Ora la tua Password");
                    insPassword = Console.ReadLine();


                    if (User.email == insEmail && User.password == insPassword)
                    {

                        Console.WriteLine("login Avvenuto con successo!");
                        string dataEOraLogin = DateTime.Now.ToString();
                        loginLog.Add(dataEOraLogin);
                        isLogged = true;
                        retry = false;

                    }
                    else
                    {

                        Console.WriteLine("Errore: Email o password errate!");
                        Console.WriteLine("Vuoi riprovare ? y/n");
                        string choice = Console.ReadLine();
                        switch (choice)
                        {

                            case "y":
                                isLogged = false;
                                retry = true;
                                break;

                            case "n":
                                isLogged = false;
                                retry = false;
                                break;

                            default:
                                isLogged = false;
                                Console.WriteLine("Scelta non consentita");
                                retry = false;
                                break;
                        }


                    }

                } while (retry);

            }

          Console.WriteLine("-------------------------------------------------");
        }





    }
}

using System;
using System.Collections.Generic;

namespace Internetbanken
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Välkommen till din internetbank ! ");

            decimal Sparkonto = 12345.67M;
            decimal Lönekonto = 100.11M ;


            // Using a multi demisionell array to store my users and passwords
            string[,] users = new string[5, 2];
            
            users[0, 0] = "Tobias";
            users[0, 1] = "1234";
            
            users[1, 0] = "Anas";
            users[1, 1] = "1337";

            users[2, 0] = "Mattias";
            users[2, 1] = "1739";

            users[3, 0] = "Kalle";
            users[3, 1] = "1717";

            users[4, 0] = "Philip";
            users[4, 1] = "5678";


            bool checkLogIN = false;
            

            for (int x = 0; x < 3; x++)// Ger tre inloggsförsök.
            {
                Console.WriteLine("Vänligen ange ditt användarnamen");
                string username = Console.ReadLine();
                Console.WriteLine("Ange din pinkod");
                string password = Console.ReadLine();

                for (int i = 0; i < users.GetLength(0); i++)// Går genom alla användare.
                {

                    if (users[i, 0] == username && users[i, 1] == password)// kollar om uppgifterna stämmer överrens.
                    {
                        checkLogIN = true;
                    }

                }


                if (checkLogIN)
                {
                    Console.WriteLine("Du är inloggad " + username);
                    
                    while (checkLogIN == true)
                    {
                        Console.WriteLine("Du kan välja dessa alternativ \n 1- Se dina konton \n 2- Överföring mellan konton \n 3- Ta ut pengar \n 4 Logga ut");

                        int userInputt = int.Parse(Console.ReadLine());
                        bool W = Convert.ToBoolean(userInputt);


                        switch (userInputt)
                        {
                            case 1:
                                SeKonton();
                                Console.WriteLine("Klicka enter för att komma till huvudmenyn");
                                Console.WriteLine("Dessa är dina konton :  Sparkonto = {0} Kr  Lönekonto = {1} Kr ", Sparkonto, Lönekonto);

                                break;

                            case 2:
                                Transfer();
                                Console.WriteLine("Klicka enter för att komma till huvudmenyn");

                                break;
                            case 3:
                                Uttag();
                                Console.WriteLine("Klicka enter för att komma till huvudmenyn");

                                break;
                            case 4:

                                UtLoggning();
                                checkLogIN = false;
                                break;
                            default:
                                Console.WriteLine("Du har valt ett ogiltigt val!\n Tryck enter för att fortsätta", userInputt);
                                break;
                        }


                        Console.ReadKey();
                        
                    }
                    
                }
                else
                {
                    Console.WriteLine("Du har skrivit fel användarnamn");
                }

            }

        }// Här "stängs" programmen

        static void SeKonton()
        {
            Console.WriteLine("Välkommen till dina konton");
            
        }

        static void Transfer()
        {
            Console.WriteLine("Överföring mellan konton");
        }

        static void Uttag()
        {
            Console.WriteLine("Ta ut pengar");
        }

        static void UtLoggning()
        {
            Console.WriteLine("Logga ut");
            
            
        }


    }

}









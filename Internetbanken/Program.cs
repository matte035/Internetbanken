﻿using System;

namespace Internetbanken
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Välkommen till din internetbank ! ");
            


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


            // If the user information is true or false.
            //bool så börjar false(ej inloggad)

            //start utav loop- Tre inloggningsförsök.


            Console.WriteLine("Vänligen ange ditt användarnamen");

            string username = Console.ReadLine();
            Console.WriteLine("Ange din pinkod");
            string password = Console.ReadLine();



            for (int i = 0; i < users.GetLength(0); i++)
            {

                if (users[i, 0] == username && users[i, 1] == password)
                {
                    Console.WriteLine("Du är inloggad " + username);
                    inloggMeny();
                }
                else
                {
                    Console.WriteLine("Du har skrivit fel användarnamn");

                }
                //om den går genom, lägg den som true
            }
            // kolla om den är inloggad-true eller false
             //avslut loop
        }





                static void inloggMeny()

                {
                    Console.WriteLine("Du kan välja dessa alternativ \n 1- Se dina konton \n 2- Överföring mellan konton \n 3- Ta ut pengar \n 4 Logga ut");

                    int userInputt = int.Parse(Console.ReadLine());

                    switch (userInputt)
                    {
                        case 1:
                         SeKonton();
                            break;

                        case 2:
                    Transfer();
                            break;
                        case 3:
                    Uttag();
                            break;
                        case 4:
                    UtLoggning();
                            break;
                    }
                    Console.ReadKey();

                }
                // Bygg funktioner se rad 99
                // While loop som användaren kan stanna kvar i menyn. Tills användaren väljer att "Logga Ut"
                
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
    

    




using System;

namespace Internetbanken
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("Välkommen till din internetbank ! ");
            Console.WriteLine("Vänligen ange ditt användarnamen");

            string username = Console.ReadLine();
            Console.WriteLine("Ange din pinkod");
            string password = Console.ReadLine();
            
            
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
          
            
            for (int i = 0; i < users.GetLength(0); i++)
            {
                for (int j = 1; j < users.GetLength(1); j++)
                {
                    if (users[i,0] == username)
                    {
                        Console.WriteLine("Du är inloggad " + username);
                        inloggMeny();
                    }
                    else if (users[j,0] !=username)
                    {
                        Console.WriteLine("Du har skrivit fel användarnamn");
                        
                    }
                    if (users[i, 1] == password)
                    {
                        Console.WriteLine();
                    }
                    else if (users[j, 1] != password) 
                   
                    {
                        Console.WriteLine();

                    }
                    
                }



                static void inloggMeny()


                {
                    Console.WriteLine("Du kan välja dessa alternativ \n 1- Se dina konton \n 2- Överföring mellan konton \n 3- Ta ut pengar \n 4 Logga ut");

                    int  userInputt = int.Parse(Console.ReadLine());
                   
                    switch (userInputt)
                    {
                        case 1:
                            Console.WriteLine("Välkommen till dina konton");
                            break;

                        case 2:
                            Console.WriteLine("Överföring mellan konton");
                            break;
                        case 3:
                            Console.WriteLine("Ta ut pengar");
                            break;
                        case 4:
                            Console.WriteLine("Logga ut");
                            break;
                        }
                    Console.ReadKey();
                    
        }

    }

        }
    }
}



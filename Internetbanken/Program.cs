using System;

namespace Internetbanken
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("Välkommen till din internetbank ! ");
            Console.WriteLine("Vänligen ange ditt användarnamen och pinkod för att logga in");

            string username = Console.ReadLine();

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
                    if (users[i, 0] == username)
                    {
                        Console.WriteLine("Du är inloggad " + username);
                        inloggMeny();
                    }
                    else if (users[i, 0] != username)
                    {
                        Console.WriteLine("Du har skrivit fel användarnamn");
                        i++;
                    }
                }



                static void inloggMeny()
                {
                    Console.WriteLine("1. Se dina konton och saldo");
                    Console.WriteLine("2. Överföring mellan konton");
                    Console.WriteLine("3. Ta ut pengar");
                    Console.WriteLine("4. Logga ut");
                }

            }

        }
    }
}



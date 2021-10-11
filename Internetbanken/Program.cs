using System;

namespace Internetbanken
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Välkommen till din internetbank ! ");
                Console.WriteLine("Vänligen ange ditt användarnamen och pinkod för att logga in");
                
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

            foreach (string user in users)
            {
                Console.WriteLine(user);
            }

          
    }
}



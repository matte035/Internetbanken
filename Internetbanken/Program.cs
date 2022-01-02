using System;
using System.Collections.Generic;

namespace Internetbanken
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] Konton = { };


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





            bool checkLogIN = false;


            for (int x = 0; x < 3; x++)// Ger tre inloggsförsök.
            {
                Console.WriteLine("Vänligen ange ditt användarnamen");
                string username = Console.ReadLine();
                Console.WriteLine("Ange din pinkod");
                string password = Console.ReadLine();

                for (int UserID = 0; UserID < users.GetLength(0); UserID++)// Går genom alla användare.
                {

                    if (users[UserID, 0] == username && users[UserID, 1] == password)// kollar om uppgifterna stämmer överrens.
                    {
                        checkLogIN = true;

                        switch (UserID)//skapa en variabel som innehåller alla konton i en Array eller en lista.
                        {
                            case 0:

                                Konton = new decimal[] { 1100.3M, 20000.5M };

                                break;
                            case 1:
                                Konton = new decimal[] { 123.45M, 0M };
                                break;
                            case 2:
                                Konton = new decimal[] { 12.12M, 25.5M };
                                break;
                            case 3:
                                Konton = new decimal[] { 20.3M, 50.5M };
                                break;
                            case 4:
                                Konton = new decimal[] { 10.5M, 100.5M };
                                break;

                            default:
                                Konton = new decimal[] { };
                                break;
                        }
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
                                Console.WriteLine("Dessa är dina konton :  \nSparkonto = {0} Kr\nLönekonto = {1} Kr ", Konton[0], Konton[1]);

                                break;

                            case 2:

                                Console.WriteLine("Välj vilket konto du vill överföra pengar från 1: Sparkonto 2: Lönekonto ");

                                int transferFromAccount;
                                int.TryParse(Console.ReadLine(), out transferFromAccount);


                                Console.WriteLine("Hur mycket vill du överföra? ");
                                int transferAmount;
                                int.TryParse(Console.ReadLine(), out transferAmount);

                                switch (transferFromAccount)
                                {
                                    case 1:
                                        if (transferAmount > Konton[0])
                                        {
                                            Console.WriteLine("Det finns inte tillräckligt med pengar på kontot ");
                                        }
                                        else
                                        {
                                            Konton[0] = Konton[0] - transferAmount;
                                            //Konton[0] -= transferAmount;
                                            Konton[1] = Konton[1] + transferAmount;
                                            //Konton[1] += transferAmount;
                                            Console.WriteLine("Ditt nya saldo är :  \nSparkonto = {0} Kr\nLönekonto = {1} Kr ", Konton[0], Konton[1]);
                                        }
                                        break;
                                    case 2:
                                        if (transferAmount > Konton[1])
                                        {
                                            Console.WriteLine("Det finns inte tillräckligt med pengar på kontot ");
                                        }
                                        else
                                        {
                                            Konton[1] = Konton[1] - transferAmount;
                                            Konton[0] = Konton[0] + transferAmount;
                                            Console.WriteLine("Ditt nya saldo är :  \nSparkonto = {0} Kr\nLönekonto = {1} Kr ", Konton[0], Konton[1]);
                                        }
                                        break;

                                    default:
                                        Console.WriteLine("Ogiltigt val! ");
                                        break;

                                }
                                Console.WriteLine("Klicka enter för att komma till huvudmenyn");

                                break;
                            case 3:

                                Console.WriteLine("Välj vilket konto du vill ta ut pengar från 1: Sparkonto 2: Lönekonto ");
                                int ChoosenAccount;
                                int.TryParse(Console.ReadLine(), out ChoosenAccount);
                                Console.WriteLine("Hur mycket pengar vill du ta ut?");
                                int WithdrawMoney;
                                int.TryParse(Console.ReadLine(), out WithdrawMoney);
                                Console.WriteLine("Vänligen ange ditt lösenord för att göra ditt uttag");
                                string WithdrawPassword = Console.ReadLine();

                                if (WithdrawPassword != password)
                                {
                                    Console.WriteLine("Du har angett fel lösenord, vänligen prova igen! ");
                                    break;
                                }



                                switch (ChoosenAccount)
                                {
                                    case 1:
                                        if (WithdrawMoney > Konton[0])
                                        {
                                            Console.WriteLine("det finns inte tillräckligt på kontot");
                                        }
                                        else
                                        {
                                            Konton[0] = Konton[0] - WithdrawMoney;

                                            Console.WriteLine("Ditt nya saldo är :  \nSparkonto = {0} Kr\nLönekonto = {1} Kr ", Konton[0], Konton[1]);
                                        }
                                        break;
                                    case 2:
                                        if (WithdrawMoney > Konton[1])
                                        {
                                            Console.WriteLine("Det finns inte tillräckligt med pengar på kontot");
                                        }
                                        else
                                        {
                                            Konton[1] = Konton[1] - WithdrawMoney;
                                            Console.WriteLine("Ditt nya saldo är :  \nSparkonto = {0} Kr\nLönekonto = {1} Kr ", Konton[0], Konton[1]);
                                        }
                                        break;
                                    default:
                                        break;
                                }
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









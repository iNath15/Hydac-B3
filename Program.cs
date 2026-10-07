using System.Security.Cryptography.X509Certificates;

namespace Hydac 
{
    internal class Program {
        static void Main(string[] args) 
        {
            string[] mainMenu = {"Registrer gæsteankomst", "Udskriv gæst", "Gæstelog"};

            Menu menu = new Menu(mainMenu, "HYDAC A/S");

            bool isRunning = true;

            while (isRunning)
            {
                int selection = menu.Navigate();

                switch(selection)
                {
                    case 0:
                        HandleRegMenu();
                        break;

                    default:
                        break;
                }
            }
        }

        static void HandleRegMenu()
        {
            string[] regGuest = { "Indtast navn", "Indtast virksomhed", "Indtast ansvarlig", "Registrer ankomst" };
            bool inSubMenu = true;
            Menu menu = new Menu(regGuest, "Venlist registere dig selv");
            string name = "";
            string businessName = "";
            string responsibleName = "";
            while (inSubMenu)
            {
                int selection = menu.Navigate();
                switch (selection)
                {
                    case 0:
                        name = Input.getString("Indtast navn: ");
                        regGuest[0] = $"Indtast navn: {name}";
                        break;
                    case 1:
                        businessName = Input.getString("Indtast virksomhed: ");
                        regGuest[1] = $"Indtast virksomhed: {businessName}";
                        break;
                    case 2:
                        responsibleName = Input.getString("Indtast ansvarlig: ");
                        regGuest[2] = $"Indtast ansvarlig: {responsibleName}";
                        break;
                    case 3:
                        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(businessName) || string.IsNullOrWhiteSpace(responsibleName))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nVenligst udfyld alle felter");
                            Console.ReadKey(true);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nGæst {name} fra {businessName} er nu registeret");
                            Console.ReadKey(true);
                            Console.ResetColor();
                            LogEntry logEntry = new LogEntry(name, businessName, responsibleName);
                            DataHandler.SaveData(logEntry);
                            inSubMenu = false;
                        }
                        break;
                }                                      
            }
        }
    }
}

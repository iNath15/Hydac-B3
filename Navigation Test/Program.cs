using Navigation_Test;

namespace Navigation_Test {
    internal class Program {
        static void Main(string[] args) {

            string[] mainMenu = { "Registrer gæsteankomst", "Udskriv gæst", "Gæstelog" };
            Menu menu = new Menu(mainMenu, "HYDAC A/S");

            bool isRunning = true;
            while (isRunning) {
                int selection = menu.Navigate();

                switch (selection) {
                    case 0:
                        HandleRegMenu();
                        break;
                    default:
                        break;
                }
            }
        }


        static void HandleRegMenu() {
            string[] regGuest = { "Indtast navn", "Indtast virksomhed", "Indtast ansvarlig", "Registrer ankomst" };
            Menu menu = new Menu(regGuest, "Venligst registrer dig selv");

            string name = "";
            string businessName = "";
            string responsibleName = "";

            bool inSubMenu = true;
            while (inSubMenu) {
                int selection = menu.Navigate();
                switch (selection) {
                    case 0:
                        name = Input.GetString("Skriv dit fulde nanv: ");
                        regGuest[0] = $"Indtast navn: {name}";
                        break;
                    case 1:
                        businessName = Input.GetString("Skriv virksomheden du kommer fra: ");
                        regGuest[1] = $"Indtast virksomhed: {businessName}";
                        break;
                    case 2:
                        responsibleName = Input.GetString("Skriv den ansvarlige for din ankomst: ");
                        regGuest[2] = $"Indtast ansvarlig: {responsibleName}";
                        break;
                    case 3:
                        if (Input.IsEmpty(name) || Input.IsEmpty(businessName) || Input.IsEmpty(responsibleName)) {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"\nUdfyld venligst alle felter før du registrerer");
                            Console.ReadKey(true);
                            Console.ResetColor();
                        }
                        else {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nGæst {name} fra {businessName} er nu registreret");
                            Console.ReadKey(true);
                            Console.ResetColor();

                            inSubMenu = false;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
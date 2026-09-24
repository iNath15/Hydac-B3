namespace Navigation_Test {
    internal class Program {
        static void Main(string[] args) {

            string[] mainMenu = { "Play Game", "Settings", "Exit" };
            string[] otherThing = { "New Game", "Load Game", "Back" };

            Menu menu = new Menu(mainMenu, "This is a main menu");

            bool isRunning = true;

            while (isRunning) {
                int selection = menu.Navigate();

                switch (selection) {
                    case 0:

                        Menu menu2 = new Menu(otherThing, "This is a secondary menu");
                        int subSelection = menu2.Navigate();
                        break;
                    case 1:
                        break;
                    case 2:
                        isRunning = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
namespace Hydac 
{
    internal class Program {
        static void Main(string[] args) 
        {
            string[] mainMenu = {"Registrer gæsteankomst", "Udskriv gæst", "Gæstelog"};
            string[] regGuest = { "Indtast navn", "Indtast virksomhed", "Indtast ansvarlig", "Registrer ankomst" };

            string[] tempNames = {"Per", "Jens", "Kurt", "Mogens" };

            Menu menu = new Menu(mainMenu, "HYDAC A/S");
            int menuSelect = menu.Navigate(); 
            
            switch(menuSelect)
            {
                case 0:
                    Menu regMenu = new Menu(regGuest, "Venligst registrer dig selv");
                    regMenu.Navigate();
                    break;
                case 1:
                    Menu dissMenu = new Menu(tempNames,"Venligst udskriv dig selv");
                    dissMenu.Navigate();
                    break;
                case 2:
                    Menu guestLogMenu = new Menu(tempNames, "Overblik over gæster");
                    guestLogMenu.Navigate();
                    break;

            }
                        
        }
    }
}

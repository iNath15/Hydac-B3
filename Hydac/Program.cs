namespace Hydac 
{
    internal class Program {
        static void Main(string[] args) 
        {
            string[] arraytest = {"Registrer gæsteankomst", "Udskriv gæst", "Gæstelog"};

            Menu menu = new Menu(arraytest, "HYDAC A/S");
            menu.test();
        }
    }
}

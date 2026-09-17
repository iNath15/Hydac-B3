namespace Navigation_Test {
    internal class Program {
        static void Main(string[] args) {
            // Vi initialiserer et array og en cursorIndex variabel (der holder styr på hvor cursoren er)
            string[] menu = { "First Item", "Second Item", "Third Item", "Fourth Item" };
            int cursorIndex = 0;

            // Et loop køres så programmet bliver ved med at køre
            while (true) {
                // Console.Clear() sletter alt i konsollen så tekst ikke gentages efter hinanden
                Console.Clear();

                // Et for loop bruges til at udskrive hvert menupunkt i arrayet
                for (int i = 0; i < menu.Length; i++) {
                    // Her tjekker vi om cursorens index matcher elementets position for at markere det aktuelt valgte punkt
                    if (i == cursorIndex) {
                        Console.WriteLine($"* {menu[i]}");
                    }
                    else {
                        Console.WriteLine($"  {menu[i]}");
                    }
                }

                // I stedet for ReadLine bruger vi ReadKey til at registrere tastetryk med det samme
                // 'true' gør at det indtastede tegn ikke vises i konsollen
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                // En switch case bruges til at ændre cursorIndex ud fra den tast der trykkes på
                switch (keyInfo.Key) {
                    case ConsoleKey.DownArrow:
                        cursorIndex++;
                        break;
                    case ConsoleKey.UpArrow:
                        cursorIndex--;
                        break;
                    default:
                        break;
                }

                // Hvis indekset når under 0, sætter vi det til det sidste element så menuen looper rundt
                if (cursorIndex < 0) {
                    // - 1 fordi indekser starter ved 0, så det sidste element har indekset menu.Length - 1
                    cursorIndex = menu.Length - 1;
                }
                // Det samme gøres hvis indekset overstiger det sidste element i arrayet
                else if (cursorIndex > menu.Length - 1) {
                    cursorIndex = 0;
                }
            }
        }
    }
}
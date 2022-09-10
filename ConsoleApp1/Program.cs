// -----------------------------------------------------------
// Number game
// Vytvoril Matej Matejka
// -----------------------------------------------------------

while (true)
{
    int pick;
    string? pickIn;
    // Zakladni menu
    Console.WriteLine("1. Hádej číselo"); 
    Console.WriteLine("2. AI Hádá číselo"); 
    Console.WriteLine("3. Konec");
    Console.WriteLine("Zadej možnost: ");
    pickIn = Console.ReadLine();
    // Zkousi zda je pickin int
    bool result = int.TryParse(pickIn, out _);
    Console.WriteLine(result);
    Console.Clear();
    // Pokud je pickin cislo
    if (result)
    {
        // Zapise do pick prevedene pickin na int
        pick = Convert.ToInt32(pickIn);
// Pokud je pick 1, zapne se hra "Hadej cislo"        
            if (pick == 1) 
            {
                Random rnd = new Random(); 
                // Nahodne cislo od 1 do 100
                int nr = rnd.Next(100); 
                while (true) 
                {
                    string? nin;
                    int n;
                    Console.WriteLine("Hádej číslo od 1 do 100");
                    nin = Console.ReadLine();
                    // Zkousi zda je nin int
                    bool resultGuess = int.TryParse(nin, out _);
                    // nin je int
                    if (resultGuess)
                    {
                        // Zapise do n prevedene nin na int
                        n = Convert.ToInt32(nin);
                        // Pokud n se rovna nr
                        if (n == nr) 
                        {
                            Console.Clear();
                            Console.WriteLine("Správně"); 
                            break;
                        } 
                        // pokud n je mensi nez nr
                        if (n < nr)
                        {
                            Console.WriteLine("Zadané číslo je menší");
                        } 
                        // pokud n je vetsi nez nr
                        if (n > nr) 
                        {
                               Console.WriteLine("Zadané číslo je větší"); 
                        }
                    }
                    // nin neni int
                    else
                    {
                        Console.WriteLine("Špatný input.");
                    }
                }
                
            }
// Pokud je pick 2 zapne se hra "AI hada cislo"            
            if (pick == 2) 
            { 
                int x = 1; 
                int y = 101; 
                int nrepeat = 0; 
                Random rnd2 = new Random(); 
                // Cislo nr2 je nahodne v rozmezi 1 az 100
                int nr2 = rnd2.Next(x,y); 
                Console.WriteLine("Usmysli jsi číslo od 1 do 100.");
                while (true) 
                {
                    string? playerIn;
                    Console.WriteLine($"Je číslo " + nr2 + " menší, větší nebo se shoduje s Vaším číslem? Zadejte (-) jestli je číslo menší, (+) pro vetší a (=) jestli se shoduje ");
                    Console.WriteLine("Zadejte +, - nebo =");
                    playerIn = Console.ReadLine();
                    // Pokud se cislo neopakuje
                    if (nrepeat != nr2) 
                    {
                        // pokud je cislo vets
                        if (playerIn == "+") 
                        { 
                            Console.WriteLine("Větší"); 
                            y = nr2;
                            nrepeat = nr2;
                            // nr2 je uprostred rozmezi x a y
                            nr2 = (x + y)/2;
                        } 
                        // Pokud je cislo mensi
                        if (playerIn == "-") 
                        { 
                            Console.WriteLine("Menší"); 
                            x = nr2;
                            nrepeat = nr2;
                            // nr2 je uprostred rozmezi x a y
                            nr2 = (x + y)/2;
                        } 
                        // Pokud AI cislo uhodlo
                        if (playerIn == "=") 
                        {
                            Console.Clear();
                            Console.WriteLine("Správně");
                            break;
                        }
                        
                    }
                    // Pokud je uzivatel, tak troufalej, ze behem hry zmeni cislo, tak se zacnou drive nebo pozdeji nr2 opakovat
                    if (nrepeat == nr2)
                    {
                        Console.WriteLine("Během hry jsi změnil číslo, s povodníkama nehraji! :(");
                        Environment.Exit(0); 
                    }
                }
            }
// Pokud je pick 3 program se vypne            
            if (pick == 3) 
            {
                Console.WriteLine("Bye...");
                Environment.Exit(0); 
            }
    }
// Pokud uzivatel zada do pick neco jineho nez cislo    
    else
    {
        Console.WriteLine("Špatný input.");
    }
}

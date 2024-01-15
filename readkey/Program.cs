//Console.WriteLine("Billentyűzet kezelés!");

ConsoleKeyInfo cki;

//do
//{
//    cki = Console.ReadKey(true);

//    if (cki.Modifiers!=0) Console.Write(cki.Modifiers+"+");
//    Console.WriteLine("Key: " + cki.Key);

//    if (cki.Modifiers != 0) Console.Write(cki.Modifiers + "+");
//    Console.WriteLine("KeyChar: " + cki.KeyChar);

//} while (cki.Key != ConsoleKey.Escape);

static void pozKiir( int oszlop, int sor, char[] szoveg) {
    Console.SetCursorPosition(oszlop, sor);
    Console.WriteLine(szoveg);
}

Console.SetWindowSize(110, 25);
Console.SetBufferSize(110, 25);
Console.ForegroundColor = ConsoleColor.Magenta;
Console.CursorVisible = false;

string szo = "alma";
char[] kitalalt = new char[szo.Length];
for (int i = 0; i < kitalalt.Length; i++) { kitalalt[i] = 'X'; }
pozKiir(0, 1, szo.ToCharArray());
pozKiir(0,2, kitalalt);

pozKiir(50, 0, "Szókitaláló".ToCharArray());
pozKiir(0, 4, "Tippelj!".ToCharArray());
do
{
    cki = Console.ReadKey(true);
    for (int i = 0; i < szo.Length; i++)
    {
        if (szo[i] == cki.KeyChar) {
            kitalalt[i] = szo[i];
            pozKiir(0, 2, kitalalt);
        }

    }
   

} while (cki.Key != ConsoleKey.Escape && !kitalalt.SequenceEqual(szo));

if (kitalalt.SequenceEqual(szo)) {
    Console.WriteLine("Nagyon ügyers vagy! Gratulálok!!!");
}

Console.ReadKey();

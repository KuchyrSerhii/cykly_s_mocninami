// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vitejte v našem mocninátorovi");
Console.WriteLine("Zadejte základ mocnin");
string z_klavesnice = Console.ReadLine();
double zaklad = Convert.ToDouble(z_klavesnice);
Console.WriteLine("Zadejte exponent");
string z_klavesnice2 = Console.ReadLine();
int exponent = Convert.ToInt16(z_klavesnice2);
double umocneni;
umocneni = zaklad;
for (int i = 0; i<(exponent - 1); i++)
    umocneni = umocneni * zaklad;
Console.WriteLine("Výsledek: {0}", umocneni);
Console.WriteLine("Děkujeme za pužití našeho programu");
Console.ReadKey();


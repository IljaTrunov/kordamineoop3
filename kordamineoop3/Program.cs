
using kordamineoop3;

Console.WriteLine("\n---------------------------------------------------------");
Opilane opilane = new Opilane("mahmud", 1994, isik.sugus.Emane, "tmrg", "12kmsh", "2 grupp");
opilane.print_Info();
Console.WriteLine("\n---------------------------------------------------------");
tootaja tootaja = new tootaja("abobus", 2004, isik.sugus.Isane, "prügikast", "kodutu", 2);
tootaja.print_Info();
Console.WriteLine("\n---------------------------------------------------------");
Kutsekooliopilane kutsekooliopilane = new Kutsekooliopilane("Ilja", 2004, isik.sugus.Isane, "TTHK", "TARpv21", true);
kutsekooliopilane.print_Info();
Console.WriteLine("\n---------------------------------------------------------");

List<isik> people = new List<isik>();
Kutsekooliopilane kutsekooliopilane2 = new Kutsekooliopilane("Edik", 2000, isik.sugus.Isane, "TTHK", "MEHpv21", true);

Kutsekooliopilane kutsekooliopilane3 = new Kutsekooliopilane("Arab", 2009, isik.sugus.Isane, "Tallinna Humanitaariumi Gümnasiuum", "7Klass", false);

tootaja tootaja2 = new tootaja("Petya", 2004, isik.sugus.Isane, "Klienditeenindaja", "sööklase töötaja", 1020);

tootaja tootaja3 = new tootaja("Tatyana", 1986, isik.sugus.Isane, "Mcdonalds manadžer", "töötaja", 890);

people.Add(kutsekooliopilane2);
people.Add(kutsekooliopilane3);
people.Add(tootaja);
people.Add(tootaja2);
people.Add(tootaja3);
people.Add(opilane);
StreamWriter to_file = new StreamWriter(@"...\...\people.txt", false);
foreach (isik p in people)
{
    p.print_Info();
    to_file.WriteLine(p.nimi + "," + p.sugu + ";");

}
to_file.Close();
StreamReader from_file = new StreamReader(@"...\...\people.txt");
string text = from_file.ReadToEnd();
Console.WriteLine(text);
from_file.Close();





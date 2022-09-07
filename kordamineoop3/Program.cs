
using kordamineoop3;


using kordamineoop3;
using Microsoft.VisualBasic.FileIO;

internal class Program
{
    private static void Main(string[] args)
    {
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
        StreamWriter viilima = new StreamWriter(@"..\..\..\people.txt", false);
        foreach (isik p in people)
        {
            p.print_Info();
            viilima.WriteLine(p.nimi + ", " + p.arvutaVanus() + ", " + p.sugu + ";");
        }
        viilima.Close();
        List<isik> LoetudFailist = new List<isik>();
        StreamReader sr = new StreamReader(@"..\..\..\people.txt");
        List<string> lines = new List<string>();
        int n = sr.ReadToEnd().Split(new char[] { '\n' }).Length;
        Console.WriteLine("-----" + n + "-------");
        StreamReader failist = new StreamReader(@"..\..\..\people.txt");
        string tekst = failist.ReadToEnd();
        Console.WriteLine(tekst);
        Console.ReadKey();
        List<tootaja> tootajad = new List<tootaja>();
        StreamReader sr = new StreamReader(@"..\..\..\people.txt");
        string text;
        while ((text = sr.ReadLine()) != null) ;
        {
            string[] rida = text.Split(',');
            tootajad.Add(new tootaja(rida[0], TextfileEnumSugu(rida[1], int.Parse rida[2], int.Parse rida[3], int.Parse rida[4], int.Parse rida[5], int.Parse rida[6])));
            //TextFilistEnumSugu(rida[1] = rida[1])
        }
        sr.Close();
        foreach (var tootaja in tootajad) ;
        {
            Console.WriteLine(tootaja.nimi + " " + tootaja.sugu + " " + tootaja.synniAasta + " ");
        }
        Console.ReadLine();
        isik.sugus TextFailistEnumSugu(string andmed)
        {
            switch (andmed)
            {
                case "naine"
                    return isik.sugus.naine;
                default:
                    return isik.sugus.mees;
            }
        }
    }
}

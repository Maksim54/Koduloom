// See https://aka.ms/new-console-template for more information
using Kordamine_OOP;
Console.WriteLine("-----Koer----\n");
Koer koer = new Koer(Koer.toug.Taksa, "Sobaka1", "punane", Koduloom.sugu.isane, 35.5, 7, true);
Koer bobik = new Koer(Koer.toug.Mastif, "Sobaka2", "Haal", Koduloom.sugu.isane, 30, 4, true);
koer.print_Info();
koer.print_Haal();
//public void a = koer.print_Info();

Koer veelkoer = new Koer(koer);
veelkoer.muudaNimi("Sobaka2");
veelkoer.muudaVarv("Kolane");
veelkoer.muudaKaal(28);
veelkoer.muudaVanus(3);
veelkoer.print_Info();


List<Koduloom> Kooduloomut = new List<Koduloom>();
Kooduloomut.Add(koer);
Kooduloomut.Add(bobik);
Console.WriteLine("\n");

StreamWriter text = new StreamWriter(@"..\..\..\Info_Koduloom.txt", false);
foreach (Koduloom x in Kooduloomut)
{
    text.WriteLine(x.nimi + "," + x.varv + "," + x.vanus);
}
text.Close();

List<Koer> koera = new List<Koer>();
StreamReader lugeda = new StreamReader(@"..\..\..\Info_Koduloom.txt");
string texta;
while ((texta = lugeda.ReadLine()) != null)
{
    string[] rida = texta.Split(',');
    koera.Add(new Koer(rida[0], rida[1]));
}
lugeda.Close();

foreach (var item in koera)
{
    Console.WriteLine(item.nimi + " " + item.varv);
}
Console.ReadLine();


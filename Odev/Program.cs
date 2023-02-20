// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


DepremYardim gida1 = new DepremYardim();

gida1.UrunAdi = "Makarna";
gida1.UrunGramaji = 500;
gida1.Fiyati = 12.5;
gida1.OlumluYorumSayisi = 25;

DepremYardim gida2 = new DepremYardim();

gida2.UrunAdi = "Ton Balığı";
gida2.UrunGramaji = 150;
gida2.Fiyati = 25;
gida2.OlumluYorumSayisi = 13;

DepremYardim gida3 = new DepremYardim();

gida3.UrunAdi = "Pirinç";
gida3.UrunGramaji = 1000;
gida3.Fiyati = 39.9;
gida3.OlumluYorumSayisi = 7;

DepremYardim gida4 = new DepremYardim();

gida4.UrunAdi = "Un";
gida4.UrunGramaji = 1000;
gida4.Fiyati = 11.9;
gida4.OlumluYorumSayisi = 56;


DepremYardim[] diziadi = new DepremYardim[] { gida1, gida2, gida3, gida4 };

for (int i = 0; i < diziadi.Length; i++)
{
    Console.WriteLine(diziadi[i].UrunAdi + "--->" + diziadi[i].UrunGramaji + "--->" + diziadi[i].Fiyati + "--->" + diziadi[i].OlumluYorumSayisi);
}

Console.WriteLine("-------------------------Sayfa Sonu---------------------------------------------------------------");

foreach (var donguadi in diziadi)
{
    Console.WriteLine(donguadi.UrunAdi + "-->" + donguadi.UrunGramaji + "-->" + donguadi.Fiyati + "--->" + donguadi.OlumluYorumSayisi);
}

Console.WriteLine("-------------------------Sayfa Sonu---------------------------------------------------------------");


int j = 0;

while (j< diziadi.Length)
{
    Console.WriteLine(diziadi[j].UrunAdi + "->" + diziadi[j].UrunGramaji + "->" + diziadi[j].Fiyati + "--->" + diziadi[j].OlumluYorumSayisi); j++;
}
class DepremYardim
{
    public string UrunAdi { get; set; }
    public int UrunGramaji { get; set; }
    public double Fiyati { get; set; }
    public int OlumluYorumSayisi { get; set; }
}
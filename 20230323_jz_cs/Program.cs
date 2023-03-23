using System.Text;
using System.IO;
using _20230323_jz_cs;

List<versenyzok> versenyzok = new();

using StreamReader sr = new(@"Eredmenyek.txt", Encoding.Latin1);
while (!sr.EndOfStream)
{
    versenyzok.Add(new versenyzok(sr.ReadLine()));
}

//2. Feladat
Console.WriteLine($"A versenyt {versenyzok.Count} versenyző fejezte be.");


//3. Feladat
int noej = 0;

foreach (var v in versenyzok)
{
	if (v.Kategoria == "elit junior")
	{
		noej++;
	}
}

Console.WriteLine($"{noej}");

//4. Feladat
int esum = 0;

foreach (var v in versenyzok)
{
	esum += (2014 - v.Szulev);
}
Console.WriteLine($"A versenyzők átlag életkora: {esum/(float)versenyzok.Count:0.0}");

//5. Feladat
Console.Write("Írj be egy kategórianevet: ");
string kk = Console.ReadLine();
string rszok = string.Empty;

foreach (var v in versenyzok)
{
	if (v.Kategoria == kk)
	{
		rszok += $"{v.Rajtszam} ";
	}
}
if (string.IsNullOrEmpty(rszok))
{
	Console.WriteLine("Nincs ilyen kategória");
}

else
{
	Console.WriteLine($"Rajtszám(ok): {rszok}");
}

//6. Feladat
List<versenyzok> Nok = new();
foreach (var v in versenyzok)
{
	if (!v.Nem)
	{
		Nok.Add(v);
	}
}
int mini = 0;
for (int i = 1; i < Nok.Count; i++)
{
	if (Nok[i].Osszido < Nok[mini].Osszido)
	{
		mini = i;
	}
}
Console.WriteLine($"A nők között a győztes: {Nok[mini].Nev}");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EU
{
  class Program
  {
    static List<Orszagok> lista = new List<Orszagok>();
    static void Main(string[] args)
    {
      MasodikFeladat();
      HarmadikFeladat();
      NegyedikFeladat();
      OtodikFeladat();
      HatodikFeladat();
      HetedikFeladat();
      NyolcadikFeladat();
      Console.ReadKey();
    }

    private static void NyolcadikFeladat()
    {
      Console.WriteLine("8.feladat: Statisztika");
      Dictionary<int, int> dic = new Dictionary<int, int>();
      foreach (var l in lista)
      {
        if (!dic.ContainsKey(l.Datum.Year))
        {
          dic.Add(l.Datum.Year,1);
        }
        else
        {
          dic[l.Datum.Year]++;
        }
      }
      foreach (var l in dic)
      {
        Console.WriteLine($"\t{l.Key} - {l.Value} ország");
      }
    }

    private static void HetedikFeladat()
    {
      DateTime legnagyobb = lista[0].Datum;
      int index=0;
      for (int i = 0; i < lista.Count; i++)
      {
        if (lista[i].Datum > legnagyobb)
        {
          index = i;
          legnagyobb = lista[i].Datum;
        }
      }
      Console.WriteLine($"7.feladat: Legutoljára csatlakozott ország: {lista[index].Orszag}");

    }

    private static void HatodikFeladat()
    {
      bool volte = false;
      foreach (var l in lista)
      {
        if (Convert.ToInt32(l.Datum.Month)==05)
        {
          volte = true;
        }
      }
      if (volte)
      {
        Console.WriteLine("6.feladat: Májusban volt csatlakozás");
      }
      else
      {
        Console.WriteLine("6.feladat: Májusban nem volt csatlakozás");
      }
    }

    private static void OtodikFeladat()
    {
      foreach (var l in lista)
      {
        if (l.Orszag=="Magyarország")
        {
          Console.WriteLine($"5.feladat: Magyarország csatlakozásának dátuma: {l.Datum.ToShortDateString()}");
        }
      }
    }

    private static void NegyedikFeladat()
    {
      int szamlalo = 0;
      foreach (var l in lista)
      {
        
        if (l.Datum.Year==2007)
        {
          szamlalo++;
        }
      }
      Console.WriteLine($"4.feladat: 2007-ben {szamlalo} ország csatlakozott.");
    }

    private static void HarmadikFeladat()
    {
      Console.WriteLine($"3.feladat: EU tagállamainak száma: {lista.Count} db");
    }

    private static void MasodikFeladat()
    {
      Console.WriteLine("2.feladat: adatok beolvasása");
      StreamReader olvaso = new StreamReader("EUcsatlakozas.txt");
      while (!olvaso.EndOfStream)
      {
        string[] atmeneti = olvaso.ReadLine().Split(';');
        lista.Add(new Orszagok(atmeneti[0],Convert.ToDateTime(atmeneti[1])));
      }
    }
  }
}

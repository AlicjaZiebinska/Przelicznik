using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przelicznik
{
    internal class Umowa
    {
        public Pracownik daneUmowy()
        {
            Pracownik pracownik = new Pracownik();
            Console.WriteLine("Podaj Nazwisko oraz Imię pracownika");
            pracownik.nazwiskoImie = Console.ReadLine();
            Console.WriteLine("Podaj wiek pracownika");
            pracownik.wiek = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj kwotę brutto umowy");
            pracownik.brutto = double.Parse(Console.ReadLine());
            Console.WriteLine("Jaki rodzaj umowy?");
            Console.WriteLine("Umowa o pracę - wpisz 1");
            Console.WriteLine("Umowa zlecenie - wpisz 2");
            pracownik.uopCzyZlecenie = Console.ReadLine();
            Console.WriteLine("Czy to jedyna umowa?");
            Console.WriteLine("TAK - wpisz 1");
            Console.WriteLine("NIE - wpisz 2");
            pracownik.czyUlga = Console.ReadLine();
            return pracownik;
        }
    }
}

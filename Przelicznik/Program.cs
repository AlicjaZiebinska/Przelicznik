using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przelicznik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w programie liczącym wynagrodzenie");
            Umowa umowa = new Umowa();
            Pracownik mojPracownik = umowa.daneUmowy();

            Kalkulator kalkulator = new Kalkulator();
            Console.WriteLine("Składka społeczna wynosi:" + kalkulator.spoleczna(mojPracownik));
            Console.WriteLine("Składka zdrowotna wynosi:" + kalkulator.zdrowotna(mojPracownik));
            if (mojPracownik.uopCzyZlecenie == "1")
            {
                Console.WriteLine("Podatek wynosi:" + (kalkulator.podatek(mojPracownik) - kalkulator.ulgaUoP(mojPracownik)));
            }
            else
            {
                Console.WriteLine("Podatek wynosi:" + (kalkulator.podatekZlecenie(mojPracownik) - kalkulator.ulgaZlecenie(mojPracownik)));
            }
            Console.WriteLine("Netto wynosi:" + kalkulator.obliczNetto(mojPracownik));
            Console.ReadLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przelicznik
{
    internal class Kalkulator
    {
        
        public double spoleczna(Pracownik pracownik)
        {
            double przedZaokragSpol = (pracownik.brutto * (1371.0/10000.0));
            return Math.Round(przedZaokragSpol, 2, MidpointRounding.ToEven);
        }

        public double zdrowotna(Pracownik pracownik)
        {
            double przedZaokragZdrow = ((pracownik.brutto - spoleczna(pracownik)) * (9.0 / 100.0));
            return Math.Round(przedZaokragZdrow, 2, MidpointRounding.ToEven);
        }
        public double podatek(Pracownik pracownik)
        {
            if (pracownik.wiek <= 26)
            {
                return 0;
            }
            else
            {
                return Math.Round((pracownik.brutto - spoleczna(pracownik) - 250.0) * (12.0 / 100.0));
            }
        }
        
        public double podatekZlecenie(Pracownik pracownik)
        {
            double spol = spoleczna(pracownik);
            double maleBrutto = pracownik.brutto - spol;
            return Math.Round((maleBrutto * 0.8) * 0.12);
        }

        public double ulgaUoP(Pracownik pracownik)
        {
            if (pracownik.czyUlga == "1")
            {
                if (podatek(pracownik) > 300)
                {
                    return 300;
                }
                else
                {
                    return podatek(pracownik);
                }
            }
            else
            {
                return 0;
            }
        }


        public double ulgaZlecenie(Pracownik pracownik)
        {
            if (pracownik.czyUlga == "1")
            {
                if (podatekZlecenie(pracownik) > 300)
                {
                    return 300;
                }
                else
                {
                    return podatekZlecenie(pracownik);
                }
            }
            else
            {
                return 0;
                }
        }

        public double obliczNetto(Pracownik pracownik)
        {
            if (pracownik.uopCzyZlecenie == "1")
            {
                return pracownik.brutto - spoleczna(pracownik) - zdrowotna(pracownik) - podatek(pracownik) + ulgaUoP(pracownik);
            }
            else 
            {
                return pracownik.brutto - spoleczna(pracownik) - zdrowotna(pracownik) - podatekZlecenie(pracownik) + ulgaZlecenie(pracownik);
            }
        }

        
        
    }
}

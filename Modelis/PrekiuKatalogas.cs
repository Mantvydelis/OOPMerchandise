using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektinis_Programavimas.Modelis
{
    internal class PrekiuKatalogas
    {
        public Preke[] Prekes { get; set; }
        int PaskutinePrideta = 0;
        int PrekiuKiekis = 0;
        


        public PrekiuKatalogas()
        {
            Prekes = new Preke[100];
        }

        public void addPreke(Preke preke)
        {
            Prekes[PaskutinePrideta] = preke;
            PaskutinePrideta++;
            PrekiuKiekis++;
        }

        public void removePreke(string pavadinimas)
        {
            for (int i = 0; i < PrekiuKiekis; i++)

            {
                if (Prekes[i].Pavadinimas == pavadinimas)
                {
                    for (int j = i; j < PrekiuKiekis-1; j++)
                    {
                        Prekes[j] = Prekes[j + 1];
                    }
                    Prekes[PrekiuKiekis - 1] = null;
                    PrekiuKiekis--;
                    break;
                  

                }
            }
        }

        public double totalKaina()
        {
            double BendraKaina = 0;

            for (int i = 0; i < PrekiuKiekis; i++)
            {

                BendraKaina += Prekes[i].Kaina * Prekes[i].Kiekis;
               
            }
            return BendraKaina;
        }

        public Preke findPreke(string pavadinimas)
        {
            for (int i = 0; i < PrekiuKiekis; i++)
            {

                if (Prekes[i].Pavadinimas == pavadinimas)
                return Prekes[i];

            }
            return null;
            
        }

    }
}

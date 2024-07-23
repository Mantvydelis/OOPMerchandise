
using Objektinis_Programavimas.Modelis;

namespace ManoPrograma
{
    public class ObjektinisProgramavimas
    {
        public static void Main(String[] args)
        {
            PrekiuKatalogas katalogas = new PrekiuKatalogas();

            katalogas.addPreke(new Preke("Bulve", 6, 6));
            katalogas.addPreke(new Preke("Morka", 8, 8));
            katalogas.addPreke(new Preke("Kopustas", 7, 6));
            katalogas.addPreke(new Preke("alus", 7, 6));
            katalogas.addPreke(new Preke("kompotas", 7, 6));

            katalogas.removePreke("kompotas");

            katalogas = katalogas;
        }
        



    }


}


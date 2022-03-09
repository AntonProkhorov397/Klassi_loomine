using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_loomine
{
    class Program
    {
        static void Main(string[] args)
        {
            Inimene i = new Opilane("Maksim", "Bomþ", "BOMÞ");
            i.Kes_ma_olen();
            i.Tervitamine();
            Inimene[] inim = new Inimene[4];

            inim[0] = new Opetaja();
            inim[0].Kes_ma_olen();
            inim[1] = new Opilane();
            inim[1].Kes_ma_olen();
            inim[2] = new Opetaja();
            inim[2].Kes_ma_olen();
            inim[3] = new Opilane();
            inim[3].Kes_ma_olen();


            Opilane o = new Opilane();
            Console.WriteLine("Mis on sinu hind? ");
            Inimene.Hinne = double.Parse(Console.ReadLine());
            Inimene naine = new Inimene();
            Console.WriteLine("Kui vana sa oled? ");
            naine.Vanus = int.Parse(Console.ReadLine());
            Console.WriteLine("Missugune on sinu palk? ");
            naine.Palk = int.Parse(Console.ReadLine());
            double s = naine.SotsialMaks();
            Console.WriteLine("Sinu sotsialMaks on " + s);
            naine.Tervitamine();

            //inimene mees = new inimene();
            //mees.Perenimi = "Anton";
            //mees.Vanus = 17;
            //Console.WriteLine(mees.Perenimi + " on " + mees.Vanus + " aastane mees ");
            //mees.Tervitamine();

            Inimene[] inimesed = new Inimene[3];
            for (int i = 0; i < 3; i++)
            {
                inimesed[i] = new Inimene();
                Console.WriteLine("Mis on sinu nimi? ");
                inimesed[i]. Perenimi=Console.ReadLine();
                Console.WriteLine("Kui vana sa oled? ");
                inimesed[i]. Vanus = int.Parse(Console.ReadLine());
            }
            foreach (Inimene inimene in inimesed)
            {
                inimene.Tervitamine();
            }

            Console.ReadKey();

        }
    }
}

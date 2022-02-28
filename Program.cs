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
            inimene naine = new inimene("Kask");
            Console.WriteLine("Kui vana sa oled? ");
            naine.Vanus = int.Parse(Console.ReadLine());
            naine.Tervitamine();

            inimene mees = new inimene();
            mees.Perenimi = "Anton";
            mees.Vanus = 17;
            Console.WriteLine(mees.Perenimi + " on " + mees.Vanus + " aastane mees ");
            mees.Tervitamine();

            inimene[] inimesed = new inimene[3];
            for (int i = 0; i < 3; i++)
            {
                inimesed[i] = new inimene();
                Console.WriteLine("Mis on sinu nimi? ");
                inimesed[i]. Perenimi=Console.ReadLine();
                Console.WriteLine("Kui vana sa oled? ");
                inimesed[i]. Vanus = int.Parse(Console.ReadLine());
            }
            foreach (inimene inimene in inimesed)
            {
                inimene.Tervitamine();
            }

            Console.ReadKey();

        }
    }
}

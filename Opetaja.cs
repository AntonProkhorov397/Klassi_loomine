using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_loomine
{
    class Opetaja : Inimene
    {
        string aine;

        public Opetaja() { }
        public string Aine
        {
            set { aine = value; }
            get { return aine; }
        }
        public override void Kes_ma_olen()
        {
            Console.WriteLine("Ma olen õpetaja!");
        }
    }
}

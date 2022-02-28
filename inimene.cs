using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_loomine
{
    class inimene
    {
        string perenimi;
        public string status;
        public int vanus;
        public int palk;
        public inimene() { }
        public inimene(string Perenimi)
        {
            perenimi = Perenimi;
        }
        public string Perenimi 
        {
            set { if (perenimi == null) perenimi = value; }
            get { return perenimi; }
        }
        public int Vanus
        {
            set 
            {
                vanus = value;
                if (vanus < 7)
                {
                    status = "laps";
                }
                else if (vanus<17)
                {
                    status = "koolilaps";
                }
                else if (vanus<24)
                {
                    status = "ülikoolilaps";
                }
                else
                {
                    status = "tööline";
                }
            }
            get { return vanus; }
        }
        public string Status
        {
            get { return status; }
        }
        public void Tervitamine()
        {
            Console.WriteLine("Tere! Minu perenimi on "+ perenimi);
            Console.WriteLine("Ma olen {0} aastat vana, olen {1}", vanus, status);
        }
    }
}

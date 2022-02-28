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
        public string nimi;
        public string status1;
        public int Palk
        {
            set
            {
                palk = value;
                if (palk < 400)
                {
                    status1 = "õpilane";
                }
                else if (palk < 800)
                {
                    status1 = "ülikoolilaps";
                }
                else if (palk < 1500)
                {
                    status1 = "tavaline inimene";
                }
                else
                {
                    status1 = "tagatud inimene";
                }
            }
            get { return palk; }

        }
        public inimene() { }
        public inimene(string Perenimi)
        {
            perenimi = Perenimi;
        }
        public inimene(string Nimi, string Perenimi)
        {
            nimi = Nimi;
            perenimi = Perenimi;
        }
        public string Nimi
        {
            set { nimi = value; }
            get { return nimi; }

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
            Console.WriteLine("Ma olen {0} aastat vana, olen {1}, ma olen {2} ", vanus, status, status1);
        }
    }
}

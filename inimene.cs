using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_loomine
{
    public abstract class Inimene
    {
        string perenimi;
        public string status;
        public int vanus;
        public int palk;
        public string eesnimi;
        public string status1;
        //Emakeel emakeel;
        //public Emakeel Emakeel
        //{
        //    get { return emakeel;  }
        //}
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
        public Inimene() { }
        //public Inimene(string Perenimi, Emakeel emakeel)
        //{
        //    perenimi = Perenimi;
        //    this.emakeel = emakeel;
        //}
        public Inimene(string Nimi, string Perenimi)
        {
            eesnimi = Nimi;
            perenimi = Perenimi;
        }
        public string Nimi
        {
            set { eesnimi = value; }
            get { return eesnimi; }

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
                
            }
            get { return vanus; }
        }
        public string Status
        {
            get {
            
                 if (vanus < 7)
                 {
                     status = "laps";
                 }
                 else if (vanus < 17)
                 {
                     status = "koolilaps";
                 }
                 else if (vanus < 24)
                 {
                     status = "ülikoolilaps";
                 }
                 else
                 {
                     status = "tööline";
                 }
                 return status; }
        }
        public void Tervitamine()
        {
            if (perenimi!=null && eesnimi!=null)
            {
                Console.WriteLine("Tere! Minu nimi on {0} {1}",eesnimi, perenimi);
            }
            else if (perenimi == null && perenimi != null)
            {
                Console.WriteLine("Tere! Minu eesnimi on " + eesnimi);
            }
            else if (eesnimi==null && eesnimi != null)
            {
                Console.WriteLine("Tere! Minu perenimi on " + perenimi);
            }
            else
            {
                Console.WriteLine("Tere!");
            }
            Console.WriteLine("Ma olen {0} aastat vana, olen {1}, ma olen {2} ", vanus, Status, status1);
        }
        public double SotsialMaks()
        {
            double SotsialMaks = 0;
            SotsialMaks = palk * 0.33;
            return SotsialMaks;
        }
        public abstract void Kes_ma_olen();
    }
}

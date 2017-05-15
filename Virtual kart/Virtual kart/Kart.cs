using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_kart_ns
{
    class Kart
    {
        private string name;
        private int hesab_nomresi;
        private DateTime bitme_vaxti;
        private int istifade_muddeti;
        private int cvc;
        private double mebleg;
        public string Name
        {
            set
            {
                this.name=value;
            }
            get
            {
                return name;
            }
        }
        public int HesabNomresi
        {
            set
            {
                this.hesab_nomresi = value;
            }
            get
            {
                return hesab_nomresi;
            }
        }
    public int IstifadeMuddeti
        {
            set
            {
                this.istifade_muddeti = value;
            }
            get
            {
                return istifade_muddeti;
            }
        }
    public int Cvc
        {
            set
            {
                this.cvc = value;
            }
            get
            {
                return cvc;
            }
        }
     public double Mebleg
        {
            set
            {
                this.mebleg = value;
            }
            get
            {
                return mebleg;
            }
        }
        public string CreateName(string name)
        {
            this.Name = name;
            return name;
        }
        public int CreatHesabNomresi()
        {
            Random a = new Random();
            this.HesabNomresi = a.Next(1, 1000000);
            return this.HesabNomresi;
        }
        public int CreateIstifadeMuddeti(int x)
        {
            this.istifade_muddeti = x;
            return x;
        }
        public int CreateCvc()
        {
            Random cv = new Random();
            this.Cvc = cv.Next(1, 3);
            return this.Cvc;
        }
        public DateTime CreateBitmeMuddeti(int mounth,int year)
        {
            bitme_vaxti = new DateTime(year, mounth, 1);
           
            return bitme_vaxti;
        }
    }
}

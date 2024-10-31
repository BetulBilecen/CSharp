using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    internal class Class1
    {
        public string renk;
        public int hiz, fiyat;
        public double motor;
        public char durum;

        private int yil;
        private string marka;


        //PRİVATE TANIMLANMIŞ DEĞİŞKENLERİ KULLANMA:
        public int YIL
        {
            get { return yil; } // yıl değerini geri döndürdü
            set { yil = Math.Abs(value); }
        }

        public string MARKA
        {
            get { return marka; }
            set { marka = value.ToUpper(); }//Marka ismini bütün harfleriyle büyük yazdırma
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    class RehberIslemleri


    {
        public List<Kisi> kisiler = new List<Kisi>();
        
        public RehberIslemleri(List<Kisi> kisiler)
        {
           
            this.kisiler = kisiler;
        }


      
        
        public bool isimVeyaSoyIsimArama (string gelenDeger)
        {
            
            bool kayitVarmi = false;
            for (int i = 0; i < kisiler.Count() ; i++)
            {
                if (gelenDeger == kisiler[i].Ad || gelenDeger==kisiler[i].SoyAd)
                {
                    kisileriGoster(kisiler[i]);
                    kayitVarmi = true;
                }
                
            }
            if (!kayitVarmi)
            {
                kayitVarmi = false;
            }

            return kayitVarmi;
        }



        public void kisileriGoster(Kisi kisi)
        {
            Console.WriteLine("İsim            : " + kisi.Ad);
            Console.WriteLine("Soyisim         : " + kisi.SoyAd);
            Console.WriteLine("Telefon numarası: " + kisi.TelefonNumarası);
            Console.WriteLine();
        }

        public void listele(int siralamaTuru)
        {
           
            if (siralamaTuru==1)
            {
                kisiler.Sort((u1, u2) => u1.Ad.CompareTo(u2.Ad));
            }
            else if (siralamaTuru==2)
            {
                kisiler.Reverse();
                
            }
            
            for (int i = 0; i < kisiler.Count; i++)
            {
                kisileriGoster(kisiler[i]);
            }


        }

        public void telNoGuncelle(string gelenAdSoyad,int yeniTelNo)
        {
            for (int i = 0; i < kisiler.Count(); i++)
            {
                if (gelenAdSoyad == kisiler[i].Ad || gelenAdSoyad == kisiler[i].SoyAd)
                {
                    kisiler[i].TelefonNumarası = yeniTelNo;
                }

            }
        }
        public void telNoSil(int gelenIndex)
        {
            kisiler.RemoveAt(gelenIndex);
        }
        public int telefonNumarasıArama(int gelenNo)
        {
            int donecekDeger = 0;
            Console.WriteLine();
            bool kayitVarmi = false;

            for (int i = 0; i < kisiler.Count; i++)
            {
                if (gelenNo ==Convert.ToInt32( kisiler[i].TelefonNumarası))
                {
                    kisileriGoster(kisiler[i]);
                    kayitVarmi = true;
                    donecekDeger = 1;
                }
            }
            if (!kayitVarmi)
            {
                donecekDeger = -1;
            }
            return donecekDeger;
        }
        public string adSoyadDondur(string gelenAdSoyAd)

        {
            string deger="";
            for (int i = 0; i < kisiler.Count(); i++)
            {
                if (gelenAdSoyAd == kisiler[i].Ad )
                {
                    deger = kisiler[i].Ad+" "+ kisiler[i].SoyAd;
                    
                }
                else 
                {
                    deger = kisiler[i].Ad + " " + kisiler[i].SoyAd;
                    
                }
               
            }
            return deger;
        }

        
            public int numaraIndexi(string gelenAdSoyAd)
        {
            for (int i = 0; i < kisiler.Count(); i++)
            {
                if (gelenAdSoyAd==kisiler[i].Ad||gelenAdSoyAd==kisiler[i].SoyAd)
                {
                    return i;
                }

            }
            return -1;
        }
    }
}

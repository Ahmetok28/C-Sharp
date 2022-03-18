using System;
using System.Collections;
using System.Collections.Generic;

namespace TelefonRehberi
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            
            

            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(new Kisi("Ahmet", "ÖK", 12345));
            kisiler.Add(new Kisi("Cemal", "Süreyya", 582568));
            kisiler.Add(new Kisi("Namık", "Kemal", 76534));
            kisiler.Add(new Kisi("Hüseyin Nihal", "Atsız", 86352));
            kisiler.Add(new Kisi("Ziya", "Gökalp", 53696));


            RehberIslemleri rehberIslem = new RehberIslemleri(kisiler);
            Etiket:
            Console.WriteLine("Lütfen Yapmak istediğiniz işlemi seçinin:");
            Console.WriteLine("#############################################");
            Console.WriteLine("(1) Yeni Numara Ekle");
            Console.WriteLine("(2) Varolan Numarayı Sil" );
            Console.WriteLine("(3) Var olan numarayı güncelle");
            Console.WriteLine("(4) Rehberi listele");
            Console.WriteLine("(5) Reherde arama yap");

            int gelenDeger = Convert.ToInt32(Console.ReadLine());
            if (gelenDeger==1)
            {
                Console.WriteLine("Lütfen isim giriniz             :");
                string ad = Console.ReadLine();
                Console.WriteLine("Lütfen soyisim giriniz          :");
                string soyAd = Console.ReadLine();
                Console.WriteLine("Lütfen telefon numarası giriniz :");
                int telNo =Convert.ToInt32( Console.ReadLine());
                kisiler.Add(new Kisi(ad,soyAd,telNo));
                goto Etiket;

            }
            else if (gelenDeger == 2)
            {
                NumaraSilEtiket:
                Console.WriteLine(" Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                string isimVeyaSoyisim = Console.ReadLine();
                if (rehberIslem.numaraIndexi(isimVeyaSoyisim)!=-1)
                {
                    HataliSecimEtiketi:
                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", rehberIslem.adSoyadDondur(isimVeyaSoyisim));
                    string onay = Console.ReadLine();
                    if (onay == "y") 
                    {
                        rehberIslem.telNoSil(rehberIslem.numaraIndexi(isimVeyaSoyisim));
                        Console.WriteLine("İşlem Başarılı");
                        goto Etiket;
                    }
                    else if (onay == "n")
                    {
                        Console.WriteLine("İşlem İptal Edildi");
                        goto Etiket;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı şeçim yaptınız lütfen tekrar deneyiniz");
                        goto HataliSecimEtiketi;
                    }

                }
                
                else
                {
                    VeriYokEtiketi:
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("Yeniden denemek için      : (2)");
                    int deger =Convert.ToInt32( Console.ReadLine());
                    if (deger == 1)
                    {
                        goto Etiket;
                    }
                    else if (deger==2)
                    {
                        goto NumaraSilEtiket;
                    }
                    else
                    {    
                        Console.WriteLine("Hatalı şeçim yaptınız lütfen tekrar deneyiniz");
                        goto VeriYokEtiketi;
                        
                    }

                }
            }
            else if (gelenDeger == 3)
            {
                VeriYokEtiketi:
                Console.WriteLine(" Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                string isimVeyaSoyisim = Console.ReadLine();
                if (rehberIslem.numaraIndexi(isimVeyaSoyisim) != -1)
                {
                    Console.WriteLine("Lütfen yeni telefon numarasını giriniz:");
                    int yeniTeL = Convert.ToInt32(Console.ReadLine());
                    HataliSecimEtiketi:
                    Console.WriteLine("{0} isimli kişinin numarası güncellenmek üzere, onaylıyor musunuz ?(y/n)",rehberIslem.adSoyadDondur(isimVeyaSoyisim));
                    string onay = Console.ReadLine();
                    if (onay == "y")
                    {
                        rehberIslem.telNoGuncelle(isimVeyaSoyisim,yeniTeL);
                        goto Etiket;
                    }
                    else if (onay == "n")
                    {
                        goto Etiket;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı şeçim yaptınız lütfen tekrar deneyiniz");
                        goto HataliSecimEtiketi;
                    }

                }

                else
                {
                    HataliSecimEtiketi2:
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("Güncellemeyi sonlandırmak için : (1)");
                    Console.WriteLine("Yeniden denemek için      : (2)");
                    int deger = Convert.ToInt32(Console.ReadLine());
                    if (deger == 1)
                    {
                        goto Etiket;
                    }
                    else if (deger == 2)
                    {
                        goto VeriYokEtiketi;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı şeçim yaptınız lütfen tekrar deneyiniz");
                        goto HataliSecimEtiketi2;

                    }

                }
            }
            else if (gelenDeger == 4)
            {
                Siralamaetiketi:
                Console.WriteLine("Lütfen sıralama tipini seçiniz.");
                Console.WriteLine(" **********************************************");
                Console.WriteLine("A-Z için: (1)");
                Console.WriteLine("Z-A için: (2)");

                int deger = Convert.ToInt32(Console.ReadLine());
                if (deger == 1)
                {
                    rehberIslem.listele(1);
                    Console.WriteLine("Devam etmek için tuşa basın");
                    Console.ReadKey();
                    Console.WriteLine();
                    goto Etiket;
                }
                else if (deger == 2)
                {
                    rehberIslem.listele(2);
                    Console.WriteLine("Devam etmek için tuşa basın");
                    Console.ReadKey();
                    Console.WriteLine();
                    goto Etiket;
                }
                else
                {
                    Console.WriteLine("Hatalı şeçim yaptınız lütfen tekrar deneyiniz");
                    goto Siralamaetiketi;

                }

            }
            else if (gelenDeger == 5)
            {
                Etiket5:

                Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
                Console.WriteLine(" **********************************************");
                Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
                Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

                int deger = Convert.ToInt32(Console.ReadLine());
                if (deger == 1)
                {
                    IsimSoyisimEtiketi:
                    Console.WriteLine("Aramak İsteğiniz Kişinin İsmini Veya Soyismini Giriniz:");
                    string gelenIsim = Console.ReadLine();

                   

                    if (rehberIslem.isimVeyaSoyIsimArama(gelenIsim))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("Aramayı sonlandırmak için : (1)");
                        Console.WriteLine("Yeniden denemek için      : (2)");
                        int girilenDeger = Convert.ToInt32(Console.ReadLine());
                        if (girilenDeger == 1)
                        {
                            goto Etiket;
                        }
                        else
                        {
                            goto IsimSoyisimEtiketi;
                        }
                    }

                    Console.WriteLine("Devam etmek için tuşa basın");
                    Console.ReadKey();
                    Console.WriteLine();
                    goto Etiket;
                }
                else if (deger == 2)
                { 
                    NumaraAramaEtiketi:
                    Console.WriteLine("Aramak İsteğiniz Kişinin Numarasını Giriniz:");
                    int girilenTelNo = Convert.ToInt32(Console.ReadLine());
                    
                    if (rehberIslem.telefonNumarasıArama(girilenTelNo)==1)
                    {
                        
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("Aramayı sonlandırmak için : (1)");
                        Console.WriteLine("Yeniden denemek için      : (2)");
                        int girilenDeger = Convert.ToInt32(Console.ReadLine());
                        if (girilenDeger==1)
                        {
                            goto Etiket; 
                        }
                        else
                        {
                            goto NumaraAramaEtiketi;
                        }

                    }

                    Console.WriteLine("Devam etmek için tuşa basın");
                    Console.ReadKey();
                    Console.WriteLine();
                    goto Etiket;
                }
                else
                {
                    Console.WriteLine("Hatalı şeçim yaptınız lütfen tekrar deneyiniz");
                    goto Etiket5;

                }
            }
            Console.ReadKey();
        }
        
    }
}

using System;
using System.Collections.Generic;

namespace TelefonRehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Members> kisiler = new List<Members>();
            List<Card> TODO = new List<Card>();
            List<Card> INPROGRESS = new List<Card>();
            List<Card> DONE = new List<Card>();

            kisiler.Add(new Members(1, "Fırat", "Alçın"));
            kisiler.Add(new Members(2, "Ali", "Yılmaz"));
            kisiler.Add(new Members(3, "Orhun", "Yamaç"));
            kisiler.Add(new Members(4, "Kenan", "Koper"));
            kisiler.Add(new Members(5, "Selim", "Serez"));

            TODO.Add(new Card("Spor", "Top Oyna", "Kenan Koper", Card.Buyukluk.XS));
            TODO.Add(new Card("Müzik", "Gitar Çal", "Ali Yılmaz", Card.Buyukluk.S));
            INPROGRESS.Add(new Card("Yazılım", "C# Çalış", "Fırat Alçın", Card.Buyukluk.M));
            INPROGRESS.Add(new Card("Film", "DUNE izle", "Orhun Yamaç", Card.Buyukluk.L));
            DONE.Add(new Card("Hukuk", "Davaya Bak", "Selim Serez", Card.Buyukluk.XL));

            BoardManager boardManager = new BoardManager();
            int number = 0;

            while (number != 5)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
                Console.WriteLine("******************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                Console.WriteLine("(5) Çıkış yapın");
                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        boardManager.ListCard(TODO, INPROGRESS, DONE);
                        break;
                    case 2:
                        boardManager.AddCard(TODO, kisiler);
                        break;
                    case 3:
                        boardManager.DeleteCard(TODO, INPROGRESS, DONE);
                        break;
                    case 4:
                        boardManager.ChangeCard(TODO, INPROGRESS, DONE);
                        break;
                    case 5:
                        number = 5;
                        break;
                }
            }





        }
    }
    class Card
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string AtananKisi { get; set; }
        public Buyukluk Boyut { get; set; }

        public enum Buyukluk
        {
            XS,
            S,
            M,
            L,
            XL
        }

        public Card(string Baslik, string Icerik, string AtananKisi, Buyukluk Boyut)
        {
            this.Baslik = Baslik;
            this.Icerik = Icerik;
            this.AtananKisi = AtananKisi;
            this.Boyut = Boyut;
        }
    }

    class Members
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Members(int Id, string FirstName, string LastName)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
    class BoardManager
    {

        public void ListCard(List<Card> TODO, List<Card> INPROGRESS, List<Card> DONE)
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("****************************");
            if (TODO != null)
            {
                foreach (var item in TODO)
                {
                    Console.WriteLine("Başlık        : " + item.Baslik);
                    Console.WriteLine("İçerik        : " + item.Icerik);
                    Console.WriteLine("Atanan Kişi   : " + item.AtananKisi);
                    Console.WriteLine("Büyüklük      : " + item.Boyut);
                    Console.WriteLine("-");
                }
            }
            else
            {
                Console.WriteLine("~ BOŞ ~");
            }

            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("****************************");
            if (INPROGRESS != null)
            {
                foreach (var item in INPROGRESS)
                {
                    Console.WriteLine("Başlık        : " + item.Baslik);
                    Console.WriteLine("İçerik        : " + item.Icerik);
                    Console.WriteLine("Atanan Kişi   : " + item.AtananKisi);
                    Console.WriteLine("Büyüklük      : " + item.Boyut);
                    Console.WriteLine("-");
                }
            }
            else
            {
                Console.WriteLine("~ BOŞ ~");
            }


            Console.WriteLine("DONE Line");
            Console.WriteLine("****************************");
            if (DONE != null)
            {
                foreach (var item in DONE)
                {
                    Console.WriteLine("Başlık        : " + item.Baslik);
                    Console.WriteLine("İçerik        : " + item.Icerik);
                    Console.WriteLine("Atanan Kişi   : " + item.AtananKisi);
                    Console.WriteLine("Büyüklük      : " + item.Boyut);
                    Console.WriteLine("-");
                }
            }
            else
            {
                Console.WriteLine("~ BOŞ ~");
            }
        }

        public void AddCard(List<Card> TODO, List<Members> kisiler)
        {
            Console.WriteLine("Başlık Giriniz: ");
            string baslik = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz: ");
            string icerik = Console.ReadLine();
            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5):");
            int boyut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kişi Giriniz: ");
            string kisi = Console.ReadLine();

            if (boyut > 0 && boyut <= 5)
            {
                TODO.Add(new Card(baslik, icerik, kisi, (Card.Buyukluk)boyut));

            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız.");
            }
        }

        public void DeleteCard(List<Card> TODO, List<Card> INPROGRESS, List<Card> DONE)
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            string baslik = Console.ReadLine();
            List<Card> temp = new List<Card>();
            temp.AddRange(TODO);
            temp.AddRange(INPROGRESS);
            temp.AddRange(DONE);
            int count = 0;
            foreach (var item in temp)
            {
                if (item.Baslik == baslik)
                {
                    count++;
                    TODO.Remove(item);
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için: (2)");
                int choose = Convert.ToInt32(Console.ReadLine());

                if (choose == 1)
                {
                    Console.WriteLine("Silme işlemi sona ermiştir.");
                }
                else
                {
                    DeleteCard(TODO, INPROGRESS, DONE);
                }

            }
        }

        public void ChangeCard(List<Card> TODO, List<Card> INPROGRESS, List<Card> DONE)
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            string baslik = Console.ReadLine();
            List<Card> temp = new List<Card>();
            temp.AddRange(TODO);
            temp.AddRange(INPROGRESS);
            temp.AddRange(DONE);
            int count = 0;
            string line = "";
            foreach (var item in temp)
            {
                if (item.Baslik == baslik)
                {
                    count++;
                    Console.WriteLine("Bulunan Kart Bilgileri: ");
                    Console.WriteLine("******************************");
                    Console.WriteLine("Başlık        : " + item.Baslik);
                    Console.WriteLine("İçerik        : " + item.Icerik);
                    Console.WriteLine("Atanan Kişi   : " + item.AtananKisi);
                    Console.WriteLine("Büyüklük      : " + item.Boyut);
                    foreach (var item1 in TODO)
                    {
                        if (baslik == item1.Baslik)
                        {
                            line = "TODO";
                            Console.WriteLine("Line          : " + line);
                        }
                    }

                    foreach (var item1 in INPROGRESS)
                    {
                        if (baslik == item1.Baslik)
                        {
                            line = "IN PROGRESS";
                            Console.WriteLine("Line          : " + line);
                        }
                    }

                    foreach (var item1 in DONE)
                    {
                        if (baslik == item1.Baslik)
                        {
                            line = "DONE";
                            Console.WriteLine("Line          : " + line);
                        }
                    }

                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) IN PROGRESS");
                    Console.WriteLine("(3) DONE");
                    int chooseLine = Convert.ToInt32(Console.ReadLine());
                    if (chooseLine == 1)
                    {
                        for (int i = 0; i < DONE.Count; i++)
                        {
                            if (DONE[i] == item)
                            {
                                DONE.Remove(item);
                            }
                        }

                        for (int i = 0; i < INPROGRESS.Count; i++)
                        {
                            if (INPROGRESS[i] == item)
                            {
                                INPROGRESS.Remove(item);
                            }
                        }
                        TODO.Add(item);
                    }
                    else if (chooseLine == 2)
                    {
                        for (int i = 0; i < TODO.Count; i++)
                        {
                            if (TODO[i] == item)
                            {
                                TODO.Remove(item);
                            }
                        }

                        for (int i = 0; i < DONE.Count; i++)
                        {
                            if (DONE[i] == item)
                            {
                                DONE.Remove(item);
                            }
                        }
                        INPROGRESS.Add(item);
                    }
                    else
                    {
                        for (int i = 0; i < TODO.Count; i++)
                        {
                            if (TODO[i] == item)
                            {
                                TODO.Remove(item);
                            }
                        }

                        for (int i = 0; i < INPROGRESS.Count; i++)
                        {
                            if (INPROGRESS[i] == item)
                            {
                                INPROGRESS.Remove(item);
                            }
                        }
                        DONE.Add(item);
                    }
                }


            }


            if (count == 0)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için: (2)");
                int choose = Convert.ToInt32(Console.ReadLine());

                if (choose == 1)
                {
                    Console.WriteLine("Silme işlemi sona ermiştir.");
                }
                else
                {
                    ChangeCard(TODO, INPROGRESS, DONE);
                }

            }
        }
    }
}
using System;

namespace Generic_list // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // list<T>
           //System.Collection.List
           // T-->Object türündedir.

           List<int> sayiListesi=new  List<int>();
           sayiListesi.Add(23);
           sayiListesi.Add(10);
           sayiListesi.Add(4);
           sayiListesi.Add(5);
           sayiListesi.Add(92);
           sayiListesi.Add(34);
           
           List<string> renkListesi=new  List<string>();

           renkListesi.Add("Kırmızı");
           renkListesi.Add("Mavi");
           renkListesi.Add("Turuncu");           
           renkListesi.Add("Sarı");
           renkListesi.Add("Yesil");
           

           //count

           Console.WriteLine(renkListesi.Count);

           //foreach ve List.foreach ile elemanlara erişim
           foreach (int sayi in sayiListesi)
           {
            Console.WriteLine(sayi);
           }
           foreach (string renk in renkListesi)
           {
            Console.WriteLine(renk);
           }
           sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
           renkListesi.ForEach(renk=>Console.WriteLine(renk));

           //Listeden eleman çıkarma
           sayiListesi.Remove(4);
           renkListesi.Remove("Yesil");

           sayiListesi.RemoveAt(4);
           renkListesi.RemoveAt(1);
           sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
           renkListesi.ForEach(renk=>Console.WriteLine(renk));

           //Liste içerisinde arama
           if (sayiListesi.Contains(10))
           {
            Console.WriteLine("10 liste içerisinde bulundu.");
           }

           //Eleman ile index e erişim
           Console.WriteLine(renkListesi.BinarySearch("Sarı"));

           //Diziyi liste çevirme

           string[] hayvanlar={"kedi","köpek","kus"};
           List<string> hayvanListesi=new List<string>(hayvanlar);
           hayvanListesi.ForEach(hayvan=>Console.WriteLine(hayvan));

           //listeyi nasıl temizleriz.
           hayvanListesi.Clear();

           // list içerisinde nesne tutmak
           List<Kullanicilar> kullaniciListesi=new List<Kullanicilar>();
           Kullanicilar kullanici1=new Kullanicilar();
           kullanici1.Isim="Ayşe";
           kullanici1.Soyisim="Yılaz";
           kullanici1.Yas=26;

           Kullanicilar kullanici2=new Kullanicilar();
           kullanici2.Isim="Özcan";
           kullanici2.Soyisim="Çalışkan";
           kullanici2.Yas=26;

           kullaniciListesi.Add(kullanici1);
           kullaniciListesi.Add(kullanici2);

           List<Kullanicilar> yeniListe=new List<Kullanicilar>();
           yeniListe.Add(new Kullanicilar(){ Isim="Deniz",Soyisim="Arda",Yas=24});

           foreach (var kullanici in kullaniciListesi)
           {
            Console.WriteLine("Kullanıci Adı:"+kullanici.Isim);
            Console.WriteLine("Kullanıci Soyadı:"+kullanici.Soyisim);
            Console.WriteLine("Kullanıci Yas:"+kullanici.Yas);
           }
           yeniListe.Clear();
        }
    }

    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;
        public string Isim{ get=>isim;set =>isim=value;}
        public string Soyisim{ get=>soyisim;set =>soyisim=value;}
        public int Yas{ get=>yas;set =>yas=value;}
    }
}

using System;

namespace ClassDemo
{
    class Program
    {//Projeniz şunu yapacak.

        //Bir bankada müşteri takibi yapmak istiyorsunuz.
        //Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
        //MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme, silme gibi metotları simule ediniz.
        static void Main(string[] args)
        {
            MusteriManeger musteriManager = new MusteriManeger() ;
            double secim = 0;
            while (secim == 0)
            {
                Müsteri x = new Müsteri();
                Menu();
                Console.WriteLine("Hoşgeldiniz hangi işlemi yapmak istersiniz ? ");
                secim = Convert.ToInt16(Console.ReadLine());
                if (secim == 1) musteriManager.Add(x);
                else if (secim == 2) musteriManager.Delete(x);
                else if (secim == 3) musteriManager.Update(x);
                else if (secim == 4) musteriManager.List();
                else Console.WriteLine("Yanlış bir tuşlama yaptınız");
                Console.WriteLine("İşleme devam etmek için 0'ı çıkmak için 1'i tuşlayınız :");
                secim = Convert.ToDouble(Console.ReadLine());

            }
        }
        static void Menu() 
        {
           
            Console.WriteLine("Müşteri eklemek için 1'i tuşlayınız ");
            Console.WriteLine("Müşteri silmek için 2'yi tuşlayınız ");
            Console.WriteLine("Müşteri güncellemek için 3'ü tuşlayınız ");
            Console.WriteLine("Müşterileri listelemek için 4'ü tuşlayınız ");
        }

    }
    
}

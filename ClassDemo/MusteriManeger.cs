using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    public class MusteriManeger
    {
       
        int _ıd = 0;
        List<Müsteri> müsteri = new List<Müsteri>();
        public void Add(Müsteri a) 
        {
            a.Id = _ıd;
            Console.WriteLine("Lütfen müşterinin adını giriniz : ");
            a.firstName = Console.ReadLine();
            Console.WriteLine("Lütfen müşterinin soyadını giriniz : ");
            a.lastName = Console.ReadLine();
            Console.WriteLine("Lütfen müşterinin TC'sini giriniz : ");
            a.TC = Console.ReadLine();
            Console.WriteLine("Lütfen müşterinin bakiyesini giriniz : ");
            a.bakiye = Convert.ToInt32(Console.ReadLine());
            müsteri.Add(a);
            _ıd++;
        }
        public void Delete(Müsteri b) 
        {
            Console.WriteLine("Lütfen silinecek müşterinin Id'sini giriniz : ");
            b.Id = Convert.ToInt32(Console.ReadLine());
            Müsteri silinecekMüsteri = new Müsteri();
            foreach (Müsteri item in müsteri)
            {
                if(b.Id == item.Id) 
                {
                    silinecekMüsteri = item;
                }
            }
            müsteri.Remove(silinecekMüsteri);
            Console.WriteLine(silinecekMüsteri.firstName +" "+ silinecekMüsteri.lastName+ " başarıyla silindi");
        }
        public void Update( Müsteri c) 
        {
            Console.WriteLine("Not bilgileri güncellenecek müşterinin ıd'si değiştirilemez");
            Console.WriteLine("Güncellenecek Müşterinin Id'sini giriniz : ");
            c.Id = Convert.ToInt32(Console.ReadLine());
            Müsteri tmp = new Müsteri();
            tmp = c;
            foreach (Müsteri item in müsteri)
            {
                if(c.Id == item.Id ) 
                {
                    item.Id= c.Id;
                    Console.WriteLine("Güncel ismi giriniz : ");
                    c.firstName = Console.ReadLine();
                    Console.WriteLine("Güncel soyismi giriniz : ");
                    c.lastName = Console.ReadLine();
                    Console.WriteLine("Güncel TC'yi giriniz : ");
                    c.TC = Console.ReadLine();
                    Console.WriteLine("Güncel bakiyeyi giriniz : ");
                    c.bakiye = Convert.ToInt32(Console.ReadLine());
                }
            }
            müsteri[c.Id] = c;
            Console.WriteLine(" Müşteri başarıyla "+c.firstName +" "+ c.lastName + " olarak güncellendi");
        }
        public void List() 
        {
            foreach (Müsteri item in müsteri)
            {
                Console.WriteLine("ID :  "+ item.Id );
                Console.WriteLine("İsim :  "+ item.firstName);
                Console.WriteLine("Soyisim :  "+item.lastName);
                Console.WriteLine("TC :  "+ item.TC);
                Console.WriteLine("Bakiye : "+ item.bakiye);
            }
        }
    }
}

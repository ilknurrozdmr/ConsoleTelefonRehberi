using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiUygulaması
{
    class AddContact
    {
        public void kisiEkle(List<Contact> kisiler)
        {
            Console.WriteLine("*****Yeni Numara Kaydet*****");
            Console.WriteLine("\nLütfen isim giriniz: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz: ");
            string phone = Console.ReadLine();
            Contact newContact = new Contact(firstname, lastname, phone);
            kisiler.Add(newContact);
            Console.WriteLine("Kişi rehbere eklendi.");
        }
    }
}

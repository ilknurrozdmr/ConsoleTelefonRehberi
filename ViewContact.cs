using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiUygulaması
{
    class ViewContact
    {
        public void kisiGoruntule(List<Contact> kisiler)
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("*********************************");
            foreach (var item in kisiler)
            {
                Console.WriteLine("İsim: " + item.FirstName);
                Console.WriteLine("Soyisim: " + item.LastName);
                Console.WriteLine("Telefon Numarası: " + item.Phone);
            }
        }
    }
}

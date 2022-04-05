using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiUygulaması
{
    class SearchContact
    {
        public void kisiAra(List<Contact> kisiler)
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**************************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                Console.WriteLine("Lütfen isim giriniz: ");
                string firtName = Console.ReadLine();
                Console.WriteLine("Lütfen soyisim giriniz: ");
                string lastName = Console.ReadLine();
                foreach (var item in kisiler)
                {
                    if (item.FirstName == firtName || item.LastName == lastName)
                    {
                        Console.WriteLine("İsim: " + item.FirstName);
                        Console.WriteLine("Soyisim: " + item.LastName);
                        Console.WriteLine("Telefon Numarası: " + item.Phone);
                        Console.WriteLine("-");
                    }
                }
            }
            else
            {
                Console.WriteLine("Lütfen telefon numarası giriniz: ");
                string phone = Console.ReadLine();
                foreach (var item in kisiler)
                {
                    if (item.Phone == phone)
                    {
                        Console.WriteLine("İsim: " + item.FirstName);
                        Console.WriteLine("Soyisim: " + item.LastName);
                        Console.WriteLine("Telefon Numarası: " + item.Phone);
                        Console.WriteLine("-");
                    }
                }
            }
        }
    }
}

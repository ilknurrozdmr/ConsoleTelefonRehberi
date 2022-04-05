using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> kisiler = new List<Contact>();
            AddContact addContact = new AddContact();
            DeleteContact deleteContact = new DeleteContact();
            SearchContact searchContact = new SearchContact();
            UpdateContact updateContact = new UpdateContact();
            ViewContact viewContact = new ViewContact();
            kisiler.Add(new Contact("İlknur", "Özdemir", "12345"));
            kisiler.Add(new Contact("Zehra", "Kara", "678910"));
            kisiler.Add(new Contact("Mahmut", "Dağlı", "111213"));
            kisiler.Add(new Contact("Burhan", "Tepe", "141516"));
            kisiler.Add(new Contact("Ceren", "Çakır", "171819"));

            int number = 0;
            while (number != 6)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
                Console.WriteLine("******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetme");
                Console.WriteLine("(2) Varolan Numarayı Silme");
                Console.WriteLine("(3) Rehberde Arama Yapma");
                Console.WriteLine("(4) Varolan Numarayı Güncelleme");
                Console.WriteLine("(5) Rehberi Listeleme");
                Console.WriteLine("(6) İşlemden çıkış");
                number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        addContact.kisiEkle(kisiler);
                        break;
                    case 2:
                        deleteContact.kisiSil(kisiler);
                        break;
                    case 3:
                        searchContact.kisiAra(kisiler);
                        break;
                    case 4:
                        updateContact.kisiGuncelle(kisiler);
                        break;
                    case 5:
                        viewContact.kisiGoruntule(kisiler);
                        break;
                    case 6:
                        Console.WriteLine("İşlem sonlandırılıyor.");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}

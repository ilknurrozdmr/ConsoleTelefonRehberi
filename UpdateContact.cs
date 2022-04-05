using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiUygulaması
{
    class UpdateContact
    {
        public void kisiGuncelle(List<Contact> kisiler)
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ve soyadını giriniz:  ");
            Console.WriteLine("Lütfen isim giriniz: ");
            string firtName = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz: ");
            string lastName = Console.ReadLine();
            int count = 0;
            foreach (var item in kisiler)
            {
                if (item.FirstName == firtName || item.LastName == lastName)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                Console.WriteLine(firtName + " " + lastName + " isimli kişinin numarasını güncellemeyi, onaylıyor musunuz ?(y/n)");
                char choose = Convert.ToChar(Console.ReadLine());
                if (choose == 'y')
                {
                    foreach (var item in kisiler)
                    {
                        if (item.FirstName == firtName || item.LastName == lastName)
                        {
                            Console.WriteLine("Lütfen yeni telefon numarası giriniz: ");
                            string phone = Console.ReadLine();
                            item.Phone = phone;
                            Console.WriteLine("Güncelleme işlemi tamamlandı.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Güncelleme işlemi sonlandırıldı.");
                }
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 2)
                {
                    kisiGuncelle(kisiler);
                }
                else
                {
                    Console.WriteLine("Güncelleme işlemi sonlandırıldı.");
                }

            }
        }
    }
}

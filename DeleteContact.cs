using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiUygulaması
{
    class DeleteContact
    {
        public void kisiSil(List<Contact> kisiler)
        {
            Console.WriteLine("Silmek istediğiniz kişinin adını ve soyadını giriniz");
            Console.WriteLine("Lütfen isim giriniz");
            string firstName = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz");
            string lastName = Console.ReadLine();
            int count = 0;
            foreach (var item in kisiler)
            {
                if(item.FirstName==firstName || item.LastName==lastName)
                {
                    count++;
                }
            }
            if(count>0)
            {
                Console.WriteLine(firstName+" "+lastName+ " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                char choose = Convert.ToChar(Console.ReadLine());
                if(choose=='y')
                {
                    foreach (var item in kisiler)
                    {
                        if(item.FirstName == firstName || item.LastName == lastName)
                        {
                            kisiler.Remove(item);
                            Console.WriteLine(item.FirstName + " isimli kişi rehberden silinmiştir.");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Silme işlemi sonlandırıldı");
                }
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 2)
                {
                    kisiSil(kisiler); 
                }
                else
                {
                    Console.WriteLine("Silme işlemi sonlandırıldı.");
                }

            }
        }
    }
}


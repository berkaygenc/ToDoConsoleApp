using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Business
{
    public class DeleteCard:Data.Database
    {
        public void Delete()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:  ");
            var deleteinput = Console.ReadLine().ToLower();

            var bulunan = cardList.Find(i => i.Baslik.ToLower() == deleteinput);

            if (cardList.Contains(bulunan))
                    cardList.Remove(bulunan);
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * Silmeyi sonlandırmak için : (1)\n" +
                                  " * Yeniden denemek için      : (2)");
                int secim = int.Parse(Console.ReadLine());
                if (secim == 1)
                    Program.Menu();
                else if (secim == 2)
                    Delete();
            }


        }
    }
}

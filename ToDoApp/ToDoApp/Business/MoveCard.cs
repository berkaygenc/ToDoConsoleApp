using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Database;

namespace ToDoApp.Business
{
    public class MoveCard : Data.Database
    {
        public void Move()
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:  ");
            var moveinput = Console.ReadLine().ToLower();
            var bulunan = cardList.Find(i => i.Baslik.ToLower() == moveinput);

            if (cardList.Contains(bulunan))
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin :" +
                              "\n****************************************" +
                              "\n(1) TODO" +
                              "\n(2) IN PROGRESS" +
                              "\n(3) DONE");
                int inputswitch = int.Parse(Console.ReadLine());
                switch (inputswitch)
                {
                    case 1:
                        bulunan.Kolon = Card.CardColumn.TODO; break;
                    case 2:
                        bulunan.Kolon = Card.CardColumn.INPROGRESS; break;
                    case 3:
                        bulunan.Kolon = Card.CardColumn.DONE; break;
                    default:
                        Console.WriteLine("Hatalı Seçim Yaptınız!");
                        break;
                }
            }
                
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * Taşımayı sonlandırmak için : (1)\n" +
                                  " * Yeniden denemek için       : (2)");
                int secim = int.Parse(Console.ReadLine());
                if (secim == 1)
                    Program.Menu();
                else if (secim == 2)
                    Move();
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Database;

namespace ToDoApp.Business
{
    public class AddCard:Data.Database
    {
        public void Add()
        {
            Card newCard = new Card();

            Console.Write("Başlık Giriniz                                  : ");
            newCard.Baslik=Console.ReadLine();
            Console.Write("İçerik Giriniz                                  : ");
            newCard.Icerik = Console.ReadLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ");
            newCard.Buyukluk = Enum.Parse<Card.CardSize>(Console.ReadLine());
            Console.Write("Kişi Id Giriniz                                  : ");
            newCard.MemberID = int.Parse(Console.ReadLine());
            
            newCard.Kolon=Card.CardColumn.TODO;
            cardList.Add(newCard);

            Console.WriteLine("Görev başarıyla eklendi.");
            Console.WriteLine(" * Ana menüye dönmek için         : (1)\n" +
                               " * Yeni biri kaydetmek için      : (2)");
            int secim = int.Parse(Console.ReadLine());
            if (secim == 1)
                Program.Menu();
            else if (secim == 2)
                Add();
        }
    }
}

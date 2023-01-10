using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Database;

namespace ToDoApp.Business
{
    public class ListBoard : Data.Database
    {
        public void List()
        {
            List<Card> ToDoLine = new List<Card>();
            List<Card> InProgressLine = new List<Card>();
            List<Card> DoneLine = new List<Card>();

            foreach (var item in cardList)
            {
                if (item.Kolon == Card.CardColumn.TODO)
                    ToDoLine.Add(item);
                else if (item.Kolon == Card.CardColumn.INPROGRESS)
                    InProgressLine.Add(item);
                else
                    DoneLine.Add(item);
            }

            ShowCard("TODO Line", ToDoLine);
            ShowCard("IN PROGRESS Line", InProgressLine);
            ShowCard("DONE Line", DoneLine);

            ChooseFromMenu();

        }

        private void ShowCard(string boardType, List<Card> listName)
        {
            Console.WriteLine(boardType);
            Console.WriteLine("*******************************************");
            if (listName.Count > 0)
            {
                foreach (var item in listName)
                {
                    Console.WriteLine("Başlık      :  {0}", item.Baslik);
                    Console.WriteLine("İçerik      :  {0}", item.Icerik);
                    Console.WriteLine("Atanan Kişi :  {0}", item.MemberID);
                    Console.WriteLine("Büyüklük    :  {0}", item.Buyukluk);
                    Console.WriteLine("-");
                }
            }
            else if (listName.Count == 0)
                Console.WriteLine("~ BOŞ ~");
        }

        public void ChooseFromMenu()
        {
            Console.WriteLine(" * Ana menüye dönmek için : (1)\n" +
                               " * bitir      : (2)");
            int secim = int.Parse(Console.ReadLine());
            if (secim == 1)
                Program.Menu();
            else if (secim == 2)
                Environment.Exit(0);
        }
    }
}

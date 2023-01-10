using System;
using System.Collections.Generic;
using ToDoApp.Business;
using ToDoApp.Database;

namespace ToDoApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            ListBoard listBoard = new ListBoard();
            DeleteCard deleteCard = new DeleteCard();
            AddCard addCard = new AddCard();
            MoveCard moveCard = new MoveCard();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin :" +
                              "\n****************************************" +
                              "\n(1) Board Listelemek" +
                              "\n(2) Board'a Kart Eklemek" +
                              "\n(3) Board'dan Kart Silmek" +
                              "\n(4) Kart Taşımak");

            int islem = Int32.Parse(Console.ReadLine());
            switch (islem)
            {
                case 1:
                    listBoard.List();
                    break;
                case 2:
                    addCard.Add();
                    listBoard.List();
                    break;
                case 3:
                    deleteCard.Delete();
                    listBoard.List();
                    break;
                case 4:
                    moveCard.Move();
                    listBoard.List();
                    break;
                case 5:
                    break;
            }
        }
    }
}

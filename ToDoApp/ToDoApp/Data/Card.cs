using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Database
{
    public class Card
    {
        private string baslik;
        private string icerik;
        private int memberID;
        private CardSize buyukluk;
        private CardColumn kolon;

        public string Baslik { get => baslik; set => baslik = value; }
        public string Icerik { get => icerik; set => icerik = value; }
        public int MemberID { get => memberID; set => memberID = value; }
        public CardSize Buyukluk { get => buyukluk; set => buyukluk = value; }
        public CardColumn Kolon { get => kolon; set => kolon = value; }

        public enum CardSize
        {
            XS=1,
            S,
            M,
            L,
            XL
        }

        public enum CardColumn
        {
            TODO,
            INPROGRESS,
            DONE
        }


    }
}

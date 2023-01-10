using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ToDoApp.Database;

namespace ToDoApp.Data
{
    public class Database
    {

        public static List<Card> cardList = new List<Card>()
            {
                new Card(){ Baslik="Odev1",Icerik="Icerik1",MemberID=1,Buyukluk=Card.CardSize.XS,Kolon=Card.CardColumn.TODO},
                new Card(){ Baslik="Odev2",Icerik="Icerik2",MemberID=2,Buyukluk=Card.CardSize.L,Kolon=Card.CardColumn.INPROGRESS},
                new Card(){ Baslik="Odev3",Icerik="Icerik3",MemberID=1,Buyukluk=Card.CardSize.M,Kolon=Card.CardColumn.TODO},
                new Card(){ Baslik="Odev4",Icerik="Icerik4",MemberID=3,Buyukluk=Card.CardSize.XL,Kolon=Card.CardColumn.INPROGRESS},
                new Card(){ Baslik="Odev5",Icerik="Icerik5",MemberID=3,Buyukluk=Card.CardSize.S,Kolon=Card.CardColumn.INPROGRESS},
                new Card(){ Baslik="Odev6",Icerik="Icerik6",MemberID=2,Buyukluk=Card.CardSize.XS,Kolon=Card.CardColumn.DONE},
             };

        public static List<Member> memberList = new List<Member>()
            {
                new Member(){Id=1,Isim="Berkay",Takimid=1},
                new Member(){Id=2,Isim="Baha",Takimid=2},
                new Member(){Id=3,Isim="İlkay",Takimid=3},

             };

        public static List<Team> teamList = new List<Team>()
            {
                new Team(){Id=1,Isim="A"},
                new Team(){Id=2,Isim="B"},
                new Team(){Id=3,Isim="C"},
             };


    }
}

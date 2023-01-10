using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Database
{
    public class Member
    {
        private int id;
        private string isim;
        private int takimid;

        public int Id { get => id; set => id = value; }
        public string Isim { get => isim; set => isim = value; }
        public int Takimid { get => takimid; set => takimid = value; }
    }
}

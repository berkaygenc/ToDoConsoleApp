using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Data
{
    public class Team
    {
        private int id;
        private string isim;

        public int Id { get => id; set => id = value; }
        public string Isim { get => isim; set => isim = value; }
    }
}

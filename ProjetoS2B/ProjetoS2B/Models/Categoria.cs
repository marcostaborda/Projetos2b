using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoS2B.Models
{
    public class Categoria
    {
        public int IdCat { get; set; }
        public String Name { get; set; }
        public String Desc { get; set; }

        public override string ToString()
        {
            return String.Format("{0}: {1}, {2}", IdCat , Name, Desc);
        }
    }
}
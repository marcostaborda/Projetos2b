using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoS2B.Models
{
    public class FakeRepositorio
    {
        private static List<Categoria> categorias;

        static FakeRepositorio()
        {
            categorias = new List<Categoria>()
            {
                new Categoria { IdCat = 1, Name = "Limpeza", Desc = "Problemas relacionados a Limpeza"},
                new Categoria { IdCat = 2, Name = "Calçadas", Desc = "Má conservação de Calçadas"},
                new Categoria { IdCat = 3, Name = "Transito", Desc = "Problemas relacionados ao Transito"}
            };
        }
    }
}
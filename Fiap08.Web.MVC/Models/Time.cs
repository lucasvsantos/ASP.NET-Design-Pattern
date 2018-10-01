using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap08.Web.MVC.Models
{
    public class Time
    {
        public int TimeId { get; set; }
        public string Nome { get; set; }
        public bool Estadio { get; set; }

        //Relacionamento
        public IList<Jogador> Jogadores { get; set; }
    }
}
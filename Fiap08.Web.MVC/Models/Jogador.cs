using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap08.Web.MVC.Models
{
    public class Jogador
    {
        public int JogadorId { get; set; }
        public string Nome { get; set; }
        public int Numero { get; set; }

        //Relacionamento
        public Time Time { get; set; }
        public int TimeId { get; set; }
    }
}
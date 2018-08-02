using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploMVC_01.Models
{
    public class Balao
    {
        public string Marca { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public string Cor { get; set; }
        public int Tamanho { get; set; }
        public bool Cheio { get; set; }
    }
}
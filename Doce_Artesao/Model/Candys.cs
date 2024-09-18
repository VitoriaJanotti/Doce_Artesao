using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doce_Artesao
{
    internal class Candys
    {
        public int CodDoces { get; set; }
        public string NomeDoce { get; set; }
        public float Preco { get; set; }

        public Candys(int coddoces, string nomedoce, float preco)
       
        {
        CodDoces = coddoces;
        NomeDoce = nomedoce;
        Preco = preco;
        }
      
    }
}

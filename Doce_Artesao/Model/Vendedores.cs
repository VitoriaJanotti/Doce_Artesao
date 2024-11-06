using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doce_Artesao.Model
{
    internal class Vendedores
    {
        private object codvendedor;

        public int Id { get; set; }
        public string NomeVendedor { get; set; }
        public string SenhaVendedor { get; set; }
        
        public Vendedores(int id, string nomevendedor, string senhavendedor) : this( nomevendedor, senhavendedor)

        {
            Id = id;
        }

        public Vendedores(string nomevendedor, string senhavendedor)
 
        {
            NomeVendedor = nomevendedor;
            SenhaVendedor = senhavendedor;
        }

    }
}

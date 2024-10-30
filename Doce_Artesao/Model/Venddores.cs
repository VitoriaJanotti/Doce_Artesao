using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doce_Artesao.Model
{
    internal class Venddores
    {
        private object codvendedor;

        public int CodVendedores { get; set; }
        public string NomeVendedor { get; set; }
        public float SenhaVendedor { get; set; }
        public object CodVendedor { get; }

        public Venddores(int codvendedores, string nomevendedor, 
            float senhavendedor) : this(codvendedores, nomevendedor, senhavendedor)

        {
            CodVendedor = codvendedor;
        }

        {
            CodVendedores = codvendedores;
            NomeVendedor = nomevendedor;
            SenhaVendedor = senhavendedor;
            
        }

    public Vendedores()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUber
{
    public abstract class Pagamento
    {
        //atributos
        protected float Valor;
        public string Escolha;

        //metoso quase haja cancelamemto
        public string Cancelar()
        {
            return "Pagamento Cancelado";

        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUber
{
    public class Dinheiro:Pagamento
    {
        //metodo instruindo o usuario a como pagar com dinheiro
        public string PagarDinheiro(float valor)
        {
           return $"\nSeu pagamento sera realizado no inicio da viagem";
            
        }
        
    }
}

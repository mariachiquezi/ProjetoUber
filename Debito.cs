using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUber
{
    public class Debito : Cartao
    {
        //atributo
        public float Saldo;

        //construtor feito para pegar as informacoes do debito
        public Debito(string titular, string bandeira, int cvv, int numero)
        {
          
            Titular=titular;
            Bandeira = bandeira;
            Cvv=cvv;
            Numero=numero;
        }
 

        //calcular o saldo atual do usuario e mostrar 
      public string MostrarSaldo(float saldo)
        {
            
                Saldo =Saldo-saldo;
            return $"\nSeu saldo no cartao de debito eh {Saldo} reais";

           
        }
    }
}


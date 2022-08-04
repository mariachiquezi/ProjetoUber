using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUber
{
    public class Credito : Cartao
    {
        //atributo
        public float Limite;
       
        //construtor para coletar os dados do credito
        public Credito (string titular, string bandeira, int cvv, int numero)
        {

            Titular = titular;
            Bandeira = bandeira;
            Cvv = cvv;
            Numero = numero;
        }

        //metodo para calcular o limite restante e mostrar para o usuario
        public string MostrarLimite(float valor)
        {
            Limite = Limite - valor;
            return $"\nSeu limite no cartao de credito eh {Limite} reais";
        }

        
    }
}

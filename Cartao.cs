using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUber
{
    public class Cartao : Pagamento
    {

        //atributos do cartao (que vao ser herdados por debito e credito)
        public string Titular;
        public string Bandeira;
        protected int Cvv;
        protected int Numero;
     
        //metodo para mostrar pro usuario que o cartao foi salvo
        public string SalvarCartao()
        {
           return $"\nDados do cartao cadastrados. Parabens {Titular} seu cartao foi salvo com sucesso!";
            
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUber
{
    public class Pix:Pagamento
    {
        //atributos
        public int ChaveDoPix;
        public string Titular;
     

        //construtor para guardar os dados do pix
        public Pix(int chaveDoPix, string titular)
        {
            ChaveDoPix = chaveDoPix;
            Titular = titular;
        }

        //metodo para ser mostrado caso o usuario escolha pix
        public string PagarPix(float valor)
        {

            return $"\nSeu pagamento de {valor} reais foi efetudo com sucesso";

        }
        
    }
}

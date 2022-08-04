using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUber
{
    public class EntregaouViagem
    {
        //atributo 
        public float Valor;

        //enum criado para o usuario escolher viagem ou entrega
        public enum Escolhendo
        {
            Viagem,
            Entrega
        }
        public Escolhendo Escolhido;

        //metodo para mostrar o escolhido e o valor 
        public string MostrarPedido()
        {
            return $"\nUma {Escolhido} no valor de {Valor} reais";
        }
    }
}

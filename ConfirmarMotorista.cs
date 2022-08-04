using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUber
{
    public class ConfirmarMotorista
    {
        //enum criado para colocar as opcoes de escolha do motorista 
        public enum Confirmar
        {
            Aceitou,
            Finalizado,
            Recusado
        }
        public Confirmar StatusAtual;

        //metodo para mostar a decisao do motorista pro usuario
        public string Mostrar()
        {
            return $"19h35min:O motorista {Confirmar.Aceitou} seu pedido";
        }

    }
}

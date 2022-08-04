using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUber
{
    public class Automovel
    {
        //declaracao de atributos do carro
        public string Cor;
        public string Marca;
        public string Placa;

        //metodo construtor 
        public Automovel(string cor, string marca,string placa)
        {
            //recebendo valores
            Cor = cor;  
            Marca = marca;
            Placa = placa;
          
         }

        //mensagem para o usuario, mostrando as informacoes do automovel
        public string MostrarVeiculo()
        {
            return $"O motorista ja esta a caminho, o veiculo eh um {Marca} de cor {Cor} e com a placa {Placa}";
        }
    }
}

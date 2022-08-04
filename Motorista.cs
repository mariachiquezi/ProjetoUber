using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUber
{
    public class Motorista:Cadastro
    {
        //atributos
        public string Automovel;
        private int NumeroDaCarteira;


        //construtor para pegar os dados do motoristas (dados fixos)
        public Motorista(string nome, float avaliacao, int idade, int telefone, string email, int numerocarteira)
        {

            Nome = nome;
            Avaliacao = avaliacao;
            Idade = idade;
            Telefone = telefone;
            Email = email;
           NumeroDaCarteira = numerocarteira;
        }

      
     
        
    }
}

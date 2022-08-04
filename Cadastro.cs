using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUber
{
    public class Cadastro
    {
        //atributos do cadastro (que vao ser herdados por motorista e passageiro)
        public string Nome;
        public float Avaliacao;
        protected int Idade;
        protected int Telefone;
        protected string Email;


     
        // metodo para mostrar para o usuario que foi cadastrado 
        public string SalvarCadastro()
        {
            return "\nCadastro Salvo com Sucesso";
        }
    }
}

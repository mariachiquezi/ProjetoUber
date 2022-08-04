using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUber
{
    public class Passageiro : Cadastro
    {
        //atributos
        public string formaDePagamento;
        public string enderecoAtual;
        public string enderecoDestino;



        //metodo para coletar os dados do usuario
       public void Dados()
        {

            Console.WriteLine("\nInsira sua Idade:"); Idade = int.Parse(Console.ReadLine());
            do
            {
                while (Idade <= 1 || Idade >= 150)
                {
                    Console.WriteLine("Valor invalido, digite novamente:");
                    int.TryParse(Console.ReadLine(), out Idade);
                }
                break;
            } while (Idade >= 1);
           
                Console.WriteLine("\nInsira seu Email:"); Email = Console.ReadLine();
       
                Console.WriteLine("\nInsira seu Telefone:"); Telefone = int.Parse(Console.ReadLine());
         


        }
        //metodo para o usuario inserir os enderecos
        public void Enderecos()
        {
            Console.WriteLine("\nDigite sua localizacao atual:"); enderecoAtual = Console.ReadLine();
            Console.WriteLine("\nDigite o endereco do seu destino:"); enderecoDestino = Console.ReadLine();

            Console.WriteLine("\nSalvo com sucesso");
        }

        //metodo para mostrar para o usuario
        public string ProcurarMotorista()
        {
            return "Estamos procurando um motorista para voce!"; 
        }
    }
}

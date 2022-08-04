using System;
using System.Collections.Generic;

namespace ProjetoUber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //valores dos argumentos do motorista
            Motorista cadastroMotorista = new Motorista("Marcio", 4.7f, 58, 1899856478, "marcio@gmail.com",856478);


            //PASSAGEIRO
            //instanciando passageiro
            Passageiro passageiro = new Passageiro();


            //determinando um nome fixo
            passageiro.Nome = "Luana Silva";

            Console.WriteLine($"OLA,{passageiro.Nome} VAMOS COMECAR SEU CADASTRO!\n");


            //determinando uma avaliacao fixa
            passageiro.Avaliacao = 3.9f;

            //pegando o metodo dados do passageiro
            passageiro.Dados();

            //mostrando que o cadastro foi salvo
            Console.WriteLine($"{passageiro.SalvarCadastro()}");

            //pedindo os enderecos
            passageiro.Enderecos();





            //ENTREGAOUVIAGEM
            //instanciando entrega ou viagem
            EntregaouViagem entregaouViagem=new EntregaouViagem();

            //determinando o valor 
            entregaouViagem.Valor = 25;

            //chamando o enum, com a escolha "viagem"
            entregaouViagem.Escolhido = EntregaouViagem.Escolhendo.Viagem;

            //mostrar a escolha e a mensagem 
            Console.WriteLine($"\n{entregaouViagem.MostrarPedido()}. {passageiro.ProcurarMotorista()} ");




            //CONFIRMARMOTORISTA
            //instanciando confirmar motorista
            ConfirmarMotorista confirmar = new ConfirmarMotorista();

            //chamando o enum, com a escolha "aceitou"
            confirmar.StatusAtual = ConfirmarMotorista.Confirmar.Aceitou;

            //mostrar a escolha do motorista 
            Console.WriteLine($"\n{confirmar.Mostrar()}");



           
            
            //DEBITO(resolvi fazer como se ela tivesse escolhido debito, por isso so ele vai mostrar no console
            //chamando o construdor e ja inserindo os dados
            Debito debito= new Debito("Luana Silva", "Visa" ,852, 00089515195);

            //determinando um saldo 
            debito.Saldo = 2555;

            //pegando o metodo "Mostrar saldo" e usando o valor como argumento 
            debito.MostrarSaldo(entregaouViagem.Valor);

            //metodo que mostra a mensagem de cartao salvo
            Console.WriteLine(debito.SalvarCartao());

            //mostrando o saldo atual
            Console.WriteLine(debito.MostrarSaldo(entregaouViagem.Valor));


           
            



            //CREDITO
            //chamando o construtor e ja inserindo os dados
            Credito credito = new Credito("Luana Silva", "MasterCard", 589, 0005987546);

            //determinando um limite 
            credito.Limite = 600;

            //metodo cancelar
            credito.Cancelar();

            //pegando o metodo e usando valor como argumento
            credito.MostrarLimite(entregaouViagem.Valor);

            //mensagem de salvar o cartao
            credito.SalvarCartao();



            //PIX
            //chamando o construtor e ja inserindo os dados
            Pix pix = new Pix(526859742,"Luana Silva");

            //pegando o metodo e usando valor como argumento
            pix.PagarPix(entregaouViagem.Valor);


            //DINHEIRO
            //instaciando dinheiro
            Dinheiro dinheiro = new Dinheiro();

            //pegango metodo e usando valor como argumento
            dinheiro.PagarDinheiro(entregaouViagem.Valor);



            //AUTOMOVEL
            //pegando o construtor e ja inserindo os dados
            Automovel automovel = new Automovel("Prata", "Jeep", "ABI-5897");

            //mostrando para o usuario o veiculo e a mensagem para o passageiro
            automovel.MostrarVeiculo();

            //mostrando "finalizado" para quando acabar a viagem ou entrega
            Console.WriteLine($"\n20h:30min:Status da sua viagem:{confirmar.StatusAtual = ConfirmarMotorista.Confirmar.Finalizado}");
















        }
    }
}

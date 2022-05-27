using System;
using System.Collections.Generic;

namespace Aula_tipos_dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroidade;
            
            
            Console.WriteLine("Seja Bem vindo ao Mercado de Bebidas São João");
            Console.WriteLine("Para Entrar é necessário ter mais de 18 anos");
            Console.WriteLine("Qual é a sua idade ?");
            string respostaidade = Console.ReadLine();
            numeroidade = int.Parse(respostaidade);

            if (numeroidade >= 18)


            {

                List<string> listaBebidas = new List<string>();
                Console.WriteLine("Para Iniciar é necessário Cadastrar uma Bebida");
                
                int numeroescolha = 1;
               
                do
                {

                    switch (numeroescolha)
                    {
                        case 1:
                            Console.WriteLine("TELA DE CADASTRO DE BEBIDA");
                            Console.WriteLine("Cadastro de Bebida");
                            Console.WriteLine("Qual o nome da Bebida ?");
                            string cadastrobebida = Console.ReadLine();
                            listaBebidas.Add(cadastrobebida);
                            Console.WriteLine("Bebida cadastrada com Sucesso !!!");
                            Console.WriteLine("O que Deseja fazer agora ?");
                            Console.WriteLine("0 - Sair");
                            Console.WriteLine("1 - Cadastrar uma nova Bebida");
                            Console.WriteLine("2 - Visualizar Bebidas Cadastradas");
                            Console.WriteLine("3 - Excluir Bebidas");
                            numeroescolha = int.Parse(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("TELA PARA VISUALIZAR BEBIDAS QUE POSSUEM NO MERCADO SÃO JOÃO");
                            Console.WriteLine("Visualização das Bebidas");
                            if (listaBebidas.Count > 0)
                            {
                                foreach (string i in listaBebidas)
                                {
                                    Console.WriteLine(i);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Não Possui nenhuma bebida cadastrada no mercado, Por gentileza cadastrar uma nova Bebida");
                            }
                            Console.WriteLine("O que Deseja fazer agora ?");
                            Console.WriteLine("0 - Sair");
                            Console.WriteLine("1 - Cadastrar Bebida");
                            if (listaBebidas.Count > 0)
                                Console.WriteLine("3 - Excluir Bebidas");
                            numeroescolha = int.Parse(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("TELA PARA REMOVER BEBIDA CADASTRADA NO MERCADO");
                            Console.WriteLine("Qual o nome da bebida que deseja excluir ?");
                            string removerbebida = Console.ReadLine();
                            if (listaBebidas.Contains(removerbebida))
                            {
                                listaBebidas.Remove(removerbebida);
                                Console.WriteLine("Bebida removida com Sucesso!!!");
                            }
                            else
                            {
                                Console.WriteLine("Bebida não existe na lista de cadastro, por gentileza escrever o nome correto");
                                Console.WriteLine("Essas são as bebidas Cadatradas (Lembrando que Diferencia Maiúsculo e Minúsculo");
                                foreach (string i in listaBebidas)
                                {
                                    Console.WriteLine(i);
                                }
                                Console.WriteLine("Qual deseja remover ?");
                                string removerbebida2 = Console.ReadLine();
                                listaBebidas.Remove(removerbebida2);
                                Console.WriteLine("Bebida removida com sucesso");
                            }
                            Console.WriteLine("O que Deseja fazer agora ?");
                            Console.WriteLine("0 - Sair");
                            Console.WriteLine("1 - Cadastrar Bebida");
                            if (listaBebidas.Count > 0)
                            {
                                Console.WriteLine("2 - Visualizar Bebidas Cadastradas");
                                Console.WriteLine("3 - Excluir uma nova Bebidas");
                            }
                            numeroescolha = int.Parse(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("Opção Inválida");
                            Console.WriteLine("Escolha entre:");
                            Console.WriteLine("1 - Cadastrar Bebida");
                            Console.WriteLine("0 - Sair");
                            Console.WriteLine("2 - Visualizar Bebidas Cadastradas");
                            Console.WriteLine("3 - Excluir Bebidas");
                            numeroescolha = int.Parse(Console.ReadLine());
                            break;

                    }
                } while (numeroescolha > 0 && numeroescolha <= 3);

                Console.WriteLine("Obrigado por utilizar o Mercado São João");
                Console.WriteLine("Volte Sempre!!!");
            }
            else
            {
                Console.WriteLine("Não é permitida a presença de menores no Mercado São João !!!!!!");
            }
        }
    }
}

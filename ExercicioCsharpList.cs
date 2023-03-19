using System;
using System.Collections.Generic;

namespace CRUDPessoas
{
    class ListaDePessoas
    {
        static List<Pessoa> listaPessoas = new List<Pessoa>();
        static void CRUD(){
            string selecionado = 0;
            string senha = senha;
            do {
            Console.WriteLine("Insira a senha para continuar:");
            senha =(Console.ReadLine());
             if (senha == ""){
                senha = "senha";
             }
             else if (senha == null ){
                Console.WriteLine("Sem senha : encerrando o programa...");
                Application.Exit();
             }
             else{
                Console.WriteLine("Senha errada: encerrando o programa...");
                Application.Exit();
             }

            } while(senha!="senha");

            while(selecionado!="5"){
            Console.WriteLine("O que voce quer fazer?:");
                Console.WriteLine("\n 1 - Inserir pessoa");
                Console.WriteLine("\n 2 - Mostrar a lista de pessoas");
                Console.WriteLine("\n 3 - Alterar uma pessoa");
                Console.WriteLine("\n 4 - Apagar pessoa");
                Console.WriteLine("\n 5 - Encerrar o programa");
                selecionado = (Console.ReadLine());
            
            switch (selecionado)
                {
                    case "1":
                        AdicionarPessoa();
                        break;
                    case "2":
                        ListarPessoas();
                        break;
                    case "3":
                        AtualizarPessoa();
                        break;
                    case "4":
                        RemoverPessoa();
                        break;
                    case "5":
                        Console.WriteLine("Encerrando programa...");
                        Application.Exit;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("\n Pressione uma tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            }

            static void AdicionarPessoa()
        {
            Console.WriteLine("Qual o nome da pessoa?:");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o  telefone da pessoa?:");
            string telefone = Console.ReadLine();

            int id = listaPessoas.Count + 1;

            Pessoa pessoa = new Pessoa(id, nome, telefone);
            listaPessoas.Add(pessoa);

            Console.WriteLine("\n Pessoa adicionada com sucesso!");
        }

         static void ListarPessoas()
        {
            if (listaPessoas.Count == 0)
            {
                Console.WriteLine("\n Nenhuma pessoa cadastrada.");
            }
            else
            {
                Console.WriteLine("\n Lista de pessoas cadastradas:");
                foreach (Pessoa pessoa in listaPessoas)
                {
                    Console.WriteLine($"ID: {pessoa.Id} | Nome: {pessoa.Nome} | Telefone: {pessoa.Telefone}");
                }
            }
        }

        static void AtualizarPessoa()
        {
            Console.WriteLine(" \n Qual o ID da pessoa que voce deseja atualizar?:");
            int id = int.Parse(Console.ReadLine());

            Pessoa pessoa = listaPessoas.Find(p => p.Id == id);

            if (pessoa == null || pessoa == "")
            {
                Console.WriteLine("\n Pessoa não encontrada.");
            }
            else
            {
                Console.WriteLine("\n O que voce precisa atualizar?.");
                Console.WriteLine("\n 1 - O nome da pessoa");
                Console.WriteLine("\n 2 - o telefone da pessoa");
                
                selecionado = (Console.ReadLine());

                switch (selecionado){

                case "1":
                Console.WriteLine($"Nome atual: {pessoa.Nome}");
                Console.WriteLine("Informe o novo nome da pessoa:");
                pessoa.Nome = Console.ReadLine();
                break;
                 
                case "2": 
                Console.WriteLine($"Telefone atual: {pessoa.Telefone}");
                Console.WriteLine("Informe o novo número de telefone da pessoa:");
                pessoa.Telefone = Console.ReadLine();
                 
                case default:
                break;

                Console.WriteLine("\n Pessoa atualizada com sucesso!");
                }
            }
            }
        }

        static void RemoverPessoa()
        {
            Console.WriteLine("Informe o ID da pessoa que deseja remover:");
            int id = int.Parse(Console.ReadLine());

            Pessoa pessoa = listaPessoas.Find(p => p.Id == id);

            if (pessoa == null)
            {
                Console.WriteLine("Pessoa não encontrada.");
            }
            else
            {
                listaPessoas.Remove(pessoa);
                Console.WriteLine("\n Pessoa removida com sucesso!");
            }
        }
    }

    class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Telefone { get; set; }
    }
}       
    

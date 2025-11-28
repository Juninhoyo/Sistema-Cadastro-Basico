using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastroPessoa.Models
{
    public class SistemaCadastro
    {
        private List<Pessoa> pessoas = new List<Pessoa>();
    
    private string LerTexto(string menssagem)
        {
            string valor;

            do
            {
                Console.WriteLine(menssagem);
                valor = Console.ReadLine()!;

                if (string.IsNullOrEmpty(valor))
                    Console.WriteLine("Entrada inválida! Tente novamente.");
            } 
            while (string.IsNullOrEmpty(valor));
            return valor;
        }
    private int LerInteiro(string menssagem)
        {
         int numero;
         
         while (true)
         {
            Console.WriteLine(menssagem);

            if (int.TryParse(Console.ReadLine(), out numero) && numero > 0)
                return numero;
            
            Console.WriteLine("Entrada inválida! Tente novamente.");     
         }   
        }
    private string LerEmail(string menssagem)
        {
            string email;

            do
            {
                Console.WriteLine(menssagem);
                email = Console.ReadLine()!;

                if (string.IsNullOrEmpty(email) || !email.Contains("@") && !email.Contains("."))
                    Console.WriteLine("Entrada inválida! Tente novamente.");
            } 
            while (string.IsNullOrEmpty(email) || !email.Contains("@"));
            return email;
        }
    public void CadastrarPessoa()
        {
            Pessoa p = new Pessoa();

            p.Id = LerInteiro("Digite o seu Id: ");

            p.Nome = LerTexto("Digite o seu Nome: ");

            p.Idade = LerInteiro("Digite a sua Idade: ");

            p.Email = LerEmail("Digite o seu Email: ");

            pessoas.Add(p);
            Console.WriteLine("Pessoa cadastrada com sucesso! Pressione Enter para continuar...");
            Console.ReadLine();
        }
    public void RemoverPessoa()
        {
            Console.WriteLine("Digite o Id da Pessoa a ser removida: ");
            int id = int.Parse(Console.ReadLine()!);

            Pessoa? pessoaParaRemover = pessoas.FirstOrDefault(p => p.Id == id);
            if (pessoaParaRemover == null)
            {
                Console.WriteLine("Pessoa não encontrada! Pressione Enter para continuar...");
                Console.ReadLine();
            }
            else
            {
                pessoas.Remove(pessoaParaRemover);
                Console.WriteLine("Pessoa removida com sucesso! Pressione Enter para continuar...");
                Console.ReadLine();
            }
        }
    public void ListarPessoa()
        {
            if (pessoas.Any())
            {
                foreach (var pessoa in pessoas)
                {
                    Console.WriteLine($"Id: {pessoa.Id}, Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Email: {pessoa.Email}");
                }
                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Nenhuma pessoa cadastrada! Pressione Enter para continuar...");
                Console.ReadLine();

            }
        }
    public void EditarPessoa()
        {
            int id = LerInteiro("Digite o Id da pessoa cadastrada para que possa ser editado: ");
            Pessoa? p = pessoas.FirstOrDefault(p => p.Id == id);

            if (p == null)
            {
                Console.WriteLine("Pessoa não encontrada! Pressione Enter para continuar...");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Digite o novo Nome (Enter para manter o atual): ");
            string novoNome = Console.ReadLine()!;
            if (!string.IsNullOrEmpty(novoNome))
            {
                p.Nome = novoNome;
            }

            Console.WriteLine("Digite a nova Idade (Enter para manter a atual): ");
            string entrada = Console.ReadLine()!;
            if (!string.IsNullOrEmpty(entrada))
            {
                if (int.TryParse(entrada, out int novaIdade) && novaIdade > 0)
                {
                    p.Idade = novaIdade;
                }
                else
                {
                    Console.WriteLine("Idade inválida! Mantendo a idade atual.");
                }
            }
            
            Console.WriteLine("Digite o novo Email (Enter para manter o atual): ");
            string novoEmail = Console.ReadLine()!;
            if (!string.IsNullOrEmpty(novoEmail))
            {
                p.Email = novoEmail;
            }

            Console.WriteLine("Pessoa editada com sucesso! Pressione Enter para continuar...");
            Console.ReadLine();
        }  
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastroPessoa.Models
{
    public class SistemaCadastro
    {
        private List<Pessoa> pessoas = new List<Pessoa>();
    
    public void CadastrarPessoa()
        {
            Pessoa p = new Pessoa();

            Console.WriteLine("Digite o Id da Pessoa: ");
            p.Id = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Digite o Nome da Pessoa: ");
            p.Nome = Console.ReadLine()!;

            Console.WriteLine("Digite a Idade da Pessoa: ");
            p.Idade = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Digite o Email da Pessoa: ");
            p.Email = Console.ReadLine()!;

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
    public void ListarPessoas()
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
    }
}
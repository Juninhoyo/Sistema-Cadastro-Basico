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
    public void CadastrarPessoa()
        {
            Pessoa p = new Pessoa();

            p.Id = LerInteiro("Digite o seu Id: ");

            p.Nome = LerTexto("Digite o seu Nome: ");

            p.Idade = LerInteiro("Digite a sua Idade: ");

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
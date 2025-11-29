using SistemaCadastroPessoa.Models;

SistemaCadastro sistema = new SistemaCadastro();

bool exebirMenu = true;


while (exebirMenu)
{

Console.Clear();
Console.WriteLine(@"
        Menu
1 - Cadastrar Pessoa
2 - Remover Pessoa
3 - Editar Pessoa
4 - Listar Pessoas
0 - Sair
Escolha uma opção: ");
string? opcao = Console.ReadLine();

switch (opcao)
    {
        case "1":
        sistema.CadastrarPessoa();
        break;

        case "2":
        sistema.RemoverPessoa();
        break;

        case "3":
        sistema.EditarPessoa();
        break;

        case "4":
        sistema.ListarPessoa();
        break;

        case "0":
        Console.WriteLine("Encerrando o programa");
        return;

        default:
        Console.WriteLine("Opção inválida! Pressione Enter para continuar...");
        break;
    }
}
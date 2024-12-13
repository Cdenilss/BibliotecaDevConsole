using System.Net.Sockets;
using BibliotecaDevv;
using BibliotecaDevv.Services;
LivrosService livrosService = new LivrosService();
Usuarioservice usuarioservice = new Usuarioservice();
EmprestimosService emprestimosService = new EmprestimosService(usuarioservice,livrosService);
Console.WriteLine("Bem vindo, a biblioteca do futuro:");




while (true)
{
    Console.WriteLine("Digite 1 para Cadastrar um Novo Livro");
    Console.WriteLine("Digite 2 para ver livros cadastrados");
    Console.WriteLine("Digite 3 para exibir detalhes de um livro especifico");
    Console.WriteLine("Digite 4 para cadastrar um novo usuario");
    Console.WriteLine("Digite 5 para ver usuarios cadastrados");
    Console.WriteLine("Digite 6 para registrar um emprestimo");
    Console.WriteLine("Digite 7 para excluir um livro");

    var opcao = Console.ReadLine();
  


    switch (opcao)
    {
        case "1":
            livrosService.Cadastrarlivro();
            break;
        case "2":
            livrosService.ExibirLivrosCadastrados();

            break;
        case "3":
            livrosService.BuscarLivroPorId();
            

            break;
        case "4":
            usuarioservice.CadastrarUsuario();

            break;
        case "5":
            usuarioservice.ExibirUserCadastrados();
            break;
        case "6":
            emprestimosService.NovoEmprestimo();
            break;
        case "7":
            livrosService.RemoverLivro(); 
            break;
        default:
            Console.WriteLine("Ate logo");
            break;

    }
}


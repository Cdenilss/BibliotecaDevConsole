using System.Runtime.InteropServices.JavaScript;

namespace BibliotecaDevv.Services;

public class EmprestimosService
{
    private List<Emprestimo> emprestimosAtivos = new List<Emprestimo>();
    private Usuarioservice _usuarioservice;
    private LivrosService _livrosService;

    public EmprestimosService(Usuarioservice usuarioservice, LivrosService livrosService)
    {
        _usuarioservice = usuarioservice;
        _livrosService = livrosService;
    }
    public void NovoEmprestimo()
    {
        Console.WriteLine("Seja bem vindo, vamos realizar seu emprestimo");
        Console.WriteLine("Qual o seu id?");
        var userId = int.Parse(Console.ReadLine());
        if (_usuarioservice.UsarioExiste(userId))
        {
            Console.WriteLine("Qual livro deseja alugar?");
            var nomeLivro = Console.ReadLine();
            var livro = _livrosService.livrosCadastrados
                .FirstOrDefault(l => l.Titulo.Equals(nomeLivro, StringComparison.OrdinalIgnoreCase));

            if (livro != null)
            {
                Console.WriteLine("Quanto tempo em meses de emprestimo ?");
                int meses = int.Parse(Console.ReadLine());
                var inicioEmprestimo = DateTime.Now;
                DateTime limiteFinal = inicioEmprestimo.AddMonths(meses);
                Emprestimo emprestimoNovo = new Emprestimo( userId, nomeLivro, inicioEmprestimo, limiteFinal);
                emprestimosAtivos.Add(emprestimoNovo);
                Console.WriteLine($"Emprestimo realizado com sucesso, data para devolução de emprestimo é: {limiteFinal}");
                Console.WriteLine("digite qualquer tecla para retornar ao menu");
                Console.ReadKey();
                Console.Clear();

            }
            else
            {
                Console.WriteLine("Livro nao encontrado, tente novamente");
            }
        }
        else
        {
            Console.WriteLine("User Id nao encontrado");
        }
    }
    
}
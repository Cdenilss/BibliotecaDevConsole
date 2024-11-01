using System.Runtime.InteropServices.JavaScript;

namespace BibliotecaDevv.Services;

public class EmprestimosService
{
    private List<Emprestimos> emprestimosAtivos = new List<Emprestimos>();
    private UserService _userService;
    private LivrosService _livrosService;

    public EmprestimosService(UserService userService, LivrosService livrosService)
    {
        _userService = userService;
        _livrosService = livrosService;
    }


    public void NovoEmprestimo()
    {
        Console.WriteLine("Seja bem vindo, vamos realizar seu emprestimo");
        Console.WriteLine("Qual o seu id?");
        var userId = int.Parse(Console.ReadLine());
        if (_userService.UsarioExiste(userId))
        {
            Console.WriteLine("Qual livro Deseja Alugar? ");
            var nome = Console.ReadLine();
            if (_livrosService.livrosCadastrados.Any(l=>l.Titulo==nome))
            {
                Console.WriteLine("Quanto tempo em meses de emprestimo ?");
                int meses = int.Parse(Console.ReadLine());
                var inicioEmprestimo = DateTime.Now;
                DateTime limiteFinal = inicioEmprestimo.AddMonths(meses);
                Emprestimos emprestimoNovo = new Emprestimos( userId, nome, inicioEmprestimo);
                emprestimosAtivos.Add(emprestimoNovo);
                Console.WriteLine($"Emprestimo realizado com sucesso, data para devolução de emprestimo é: {limiteFinal}");
                Console.WriteLine("digite qualquer tecla para retornar ao menu");
                Console.ReadKey();

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
        
        //Realizar uma maneira de aparecer um warning para o user para aparecer quando esta atrasado.

        void AtrasoDeDevolucao()
        {
           
            
                
            
        }
        
    }
    
}
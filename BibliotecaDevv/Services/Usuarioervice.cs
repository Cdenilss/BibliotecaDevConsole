using System.Text.RegularExpressions;

namespace BibliotecaDevv.Services;

public class Usuarioervice
{
    public List<Usuario> userCadastrados = new List<Usuario>();
    //private User denil1 = new User("carlos","jj234");
    
    
    
    
    public void CadastrarUsuario()
    {
        Console.WriteLine("Seja bem vindo, vamos realizar seu cadastro");
        Console.WriteLine("Qual o seu nome?");
        string nome = Console.ReadLine();
        Console.WriteLine("Por ultimo, digite seu melhor email");
        string email = Console.ReadLine();
        string padraoEmail = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
        // por um while
        if (Regex.IsMatch(email,padraoEmail))
        {
            Usuario usuarioNovo = new Usuario( nome, email);
            userCadastrados.Add(usuarioNovo);
            usuarioNovo.ExibirId();
            Console.WriteLine("User cadastrado com sucesso");

            Console.WriteLine("digite qualquer tecla para retornar");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("email invalido");
            
        }
    }

   public bool UsarioExiste(int userId)
    {
        return userCadastrados.Any(u => u.Id == userId);
    }

    public void ExibirUserCadastrados()
    {
        if (userCadastrados.Count== 0)
        {
            Console.WriteLine("Sem usuarios cadastrados");
        }
        else
        {
            Console.WriteLine("Esses são os usuários cadastrados : \n ");
            foreach (var user in userCadastrados)
            {
                user.ExibirDadosUsuer();
            }
        }
    }
}
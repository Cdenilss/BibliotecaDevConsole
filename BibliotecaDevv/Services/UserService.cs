using System.Text.RegularExpressions;

namespace BibliotecaDevv.Services;

public class UserService
{
    public List<User> userCadastrados = new List<User>();
    //private User denil1 = new User("carlos","jj234");
    
    
    
    
    public void CadastroUsuario()
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
            User userNovo = new User( nome, email);
            userCadastrados.Add(userNovo);
            userNovo.ExibirId();
            Console.WriteLine("User cadastrado com sucesso");

            Console.WriteLine("digite qualquer tecla para retornar");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("email invalido");
            
        }
        // usar regex
       

    }

   public bool UsarioExiste(int userId)
    {
        return userCadastrados.Any(u => u.IdUser == userId);
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
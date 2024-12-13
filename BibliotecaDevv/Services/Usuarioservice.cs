using System.Text.RegularExpressions;

namespace BibliotecaDevv.Services;

public class Usuarioservice
{
    public List<Usuario> userCadastrados = new List<Usuario>();
    public void CadastrarUsuario()
    {
        Console.WriteLine("Seja bem-vindo, vamos realizar seu cadastro");
        Console.WriteLine("Qual o seu nome?");
        string nome = Console.ReadLine();
        string email;
        string padraoEmail = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
        Console.WriteLine("Por último, digite seu melhor email:");
        while (true)
        {
            email = Console.ReadLine();
            if (Regex.IsMatch(email, padraoEmail))
            {
                break; 
            }
            else
            {
                Console.WriteLine("Email inválido. Por favor, tente novamente.");
            }
        }
        
        Usuario usuarioNovo = new Usuario(nome, email);
        userCadastrados.Add(usuarioNovo);
        usuarioNovo.ExibirId();
        Console.WriteLine("Usuário cadastrado com sucesso!");
    
        Console.WriteLine("Digite qualquer tecla para retornar");
        Console.ReadKey();
        Console.Clear();
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
            Console.WriteLine("Clique em qualquer tecla para retornar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Esses são os usuários cadastrados : \n ");
            foreach (var user in userCadastrados)
            {
                user.ExibirDadosUsuer();
                Console.WriteLine("Pressione qualquer tecla para retornar ao menu");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
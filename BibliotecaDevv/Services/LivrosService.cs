using System.Net.Sockets;

namespace BibliotecaDevv.Services;

public class LivrosService
{
    public List<Livro> livrosCadastrados = new List<Livro>();

    public void Cadastrarlivro()
    {
        Console.WriteLine("qual o id do livro?");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("qual o nome do livro?");
        string titulo = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(titulo))
            {
                Console.WriteLine("nome invalido, por favor digite novamente");
                titulo = Console.ReadLine();
            }
        Console.WriteLine("Autor do Livro");
        string autor = Console.ReadLine();
        Console.WriteLine("Ano de publicaçao ?");
        int anoDePublicacao = int.Parse(Console.ReadLine());
        
            while (anoDePublicacao > DateTime.Today.Year)
            {
                
                Console.WriteLine("Ano invalido, favor digite novamente");
                anoDePublicacao = int.Parse(Console.ReadLine());
            }
            
        Livro livro = new Livro(id, titulo, autor, anoDePublicacao);
        
        livrosCadastrados.Add(livro);
        Console.WriteLine("Livro cadastrado com sucesso");

        Console.WriteLine("Pressione qualquer tecla para retornar");
        Console.ReadKey();
        Console.Clear();
    }

    public void ExibirLivrosCadastrados()
    {
            if (livrosCadastrados.Count== 0)
            {
                Console.WriteLine("Lista vazia");
                Console.WriteLine("Para retornar, pressione qualquer tecla");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Esse sao os livros cadastrados:");
                foreach (var livro in livrosCadastrados)
                {
                    livro.ExibirDetalheLivro();
                   
                }
                Console.WriteLine("Para retornar, pressione qualquer tecla");
                Console.ReadKey();
                Console.Clear();
            }
        
    }

    public void BuscarLivroPorId()
    {
        Console.WriteLine("Digite o id do livro que busca:");
        var resposta = int.Parse(Console.ReadLine());
       var livroEncontrada= livrosCadastrados.FirstOrDefault(l => l.Id == resposta);
        
        if (livroEncontrada!= null)
        {
            livroEncontrada.ExibirDetalheLivro();
            
        }
        else
        {
            Console.WriteLine("não há nenhum livro com esse id");
        }

        Console.WriteLine("digite qualquer tecla para retornar ao menu");
        Console.ReadKey();
        Console.Clear();
    }


    public void RemoverLivro()
    {
        if (!livrosCadastrados.Any())
        {
            Console.WriteLine("Não há livros cadastrados no sistema.");
            Console.WriteLine("Pressione qualquer tecla para retornar ao menu.");
            Console.ReadKey();
            Console.Clear();
            return;
        }

        Console.WriteLine("Qual livro deseja remover?");
        var livroBuscado = Console.ReadLine();

        var livroASerRemovido = livrosCadastrados.FirstOrDefault(l => 
            l.Titulo.Equals(livroBuscado, StringComparison.OrdinalIgnoreCase));

        if (livroASerRemovido == null)
        {
            Console.WriteLine("Livro não encontrado.");
            Console.WriteLine("Pressione qualquer tecla para retornar ao menu.");
            Console.ReadKey();
            Console.Clear();
            return;
        }
        
        livroASerRemovido.ExibirDetalheLivro();

        Console.WriteLine($"Deseja continuar com a remoção do livro '{livroASerRemovido.Titulo}'?");
        Console.WriteLine("Digite 1 para confirmar ou qualquer outro número para cancelar.");

        if (int.TryParse(Console.ReadLine(), out int resposta) && resposta == 1)
        {
            livrosCadastrados.Remove(livroASerRemovido);
            Console.WriteLine("Livro removido com sucesso.");
        }
        else
        {
            Console.WriteLine("Operação cancelada.");
        }

        Console.WriteLine("Pressione qualquer tecla para retornar ao menu.");
        Console.ReadKey();
        Console.Clear();
    }

    }

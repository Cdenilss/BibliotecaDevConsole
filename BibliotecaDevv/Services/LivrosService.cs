using System.Net.Sockets;

namespace BibliotecaDevv.Services;

public class LivrosService
{
    public List<Livros> livrosCadastrados = new List<Livros>();

    public void Cadastrarlivro()
    {
        Console.WriteLine("qual o id do livro?");

        int id = int.Parse(Console.ReadLine());
        
        Console.WriteLine("qual o nome do livro?");
        string titulo = Console.ReadLine();
        if (string.IsNullOrEmpty(titulo))
        {
            while (string.IsNullOrEmpty(titulo))
            {
                Console.WriteLine("nome invalido, por favor digite novamente");
                titulo = Console.ReadLine();
            }
        }

        Console.WriteLine("Autor do Livro");
        string autor = Console.ReadLine();

        Console.WriteLine("Ano de publicaçao ?");
        int anoDePublicacao = int.Parse(Console.ReadLine());
        
            while (anoDePublicacao >= 2025)
            {
                
                Console.WriteLine("Ano invalido, favor digite novamente");
                anoDePublicacao = int.Parse(Console.ReadLine());
            }
            
        Livros livro = new Livros(id, titulo, autor, anoDePublicacao);
        
        livrosCadastrados.Add(livro);
        Console.WriteLine("Livro cadastrado com sucesso");

        Console.WriteLine("precisione qualquer tecla para retornar");
        
        Console.ReadKey();



    }

    public void ExibirLivrosCadastrados()
    {
       
            if (livrosCadastrados.Count== 0)
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                Console.WriteLine("esse sao os livros cadastrados:\n");
                foreach (var livro in livrosCadastrados)
                {
                    livro.ExibirDetalheLivro();
                }
                

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
        
    }


    public void RemoverLivro()
    {
        Console.WriteLine("Qual livro deseja remover ?");
        var livroBuscado = Console.ReadLine();
        var livroASerRemovido = livrosCadastrados.FirstOrDefault(l => l.Titulo == livroBuscado);
        if (livroASerRemovido != null)
        {
            livroASerRemovido.ExibirDetalheLivro();
            Console.WriteLine($"Deseja continuar com a remoção do livro {livroASerRemovido.Titulo}?\n digite 1 para continuar ou qualquer outro numero para cancelar");
            var respota = int.Parse(Console.ReadLine());
            if (respota==1)
            {
                livrosCadastrados.Remove(livroASerRemovido);
                Console.WriteLine("livro removido com sucesso.");
                Console.WriteLine("digite qualquer tecla para retornar ao menu");
                Console.ReadKey();
                
            }
            else
            {
                Console.WriteLine("Operação Cancelada");
                Console.WriteLine("digite qualquer tecla para retornar ao menu");
                Console.ReadKey();

                
            }
        }
        else
        {
            Console.WriteLine("Livro nao encontrado");
        }
        
    }
}
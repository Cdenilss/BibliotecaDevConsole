namespace BibliotecaDevv;

public class Livros
{
    public Livros(int id, string titulo,string autor,int anodDePublicacao)
    {
        Id = id;
        Titulo = titulo;
        Autor = autor;
        AnoDePublicacao = anodDePublicacao;
    }

   
    public int Id { get; set; }
    
    //ISBN add
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoDePublicacao { get; set; }


    public void ExibirDetalheLivro()
    {
        Console.WriteLine($"Livro:{Titulo}, escrito por: {Autor}, publicado em: {AnoDePublicacao} ");
    }
    
    
}


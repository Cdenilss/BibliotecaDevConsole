namespace BibliotecaDevv;

public class Usuario
{

    public Usuario( string nome, string email)
    {
        
        Id = Random.Shared.Next(1, 1000);
        Nome = nome;
        Email = email;
    }
        
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }

    public void ExibirId()
    {
        Console.WriteLine($"Seu id é : {Id}, favor guardar informação ");
    }

    public void ExibirDadosUsuer()
    {
        Console.WriteLine($"Id user: {Id}, nome: {Nome}, email: {Email}");
        
    }
    
}
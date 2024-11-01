namespace BibliotecaDevv;

public class User
{

    public User( string nome, string email)
    {
        //Random random = new Random();
        IdUser = Random.Shared.Next(1, 1000);
            //random.Next(1, 1000);
        Nome = nome;
        Email = email;
    }
        
    public int IdUser { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }

    public void ExibirId()
    {
        Console.WriteLine($"Seu id é : {IdUser}, favor guardar informação ");
    }

    public void ExibirDadosUsuer()
    {
        Console.WriteLine($"Id user: {IdUser}, nome: {Nome}, email: {Email}");
        // add aopcao de mostrar se há um emprestimo ou n ativo
    }
    
}
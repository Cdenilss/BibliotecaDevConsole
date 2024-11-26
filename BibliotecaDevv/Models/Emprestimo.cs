namespace BibliotecaDevv;

public class Emprestimo
{

    public Emprestimo( int userId, string nome, DateTime inicioEmprestimo, DateTime limiteFinal)
    {
        Id = Random.Shared.Next(1, 10000);
        UserId = userId;
        NomeLivro = nome;
        InicioEmprestimo = inicioEmprestimo;
        LimiteFinal = limiteFinal;


    }

    public int  Id { get; set; }
    public int UserId { get; set; }
    public string NomeLivro { get; set; }
    public DateTime InicioEmprestimo { get; set; }
    
    public DateTime LimiteFinal { get; set; }
    
    
}

namespace BibliotecaDevv;

public class Emprestimo
{

    public Emprestimo( int userId, string nome, DateTime inicioEmprestimo) : base()
    {
        Id = Random.Shared.Next(1, 10000);
        UserId = userId;
        Nome = nome;
        InicioEmprestimo = inicioEmprestimo;



    }

    public int  Id { get; set; }
    public int UserId { get; set; }
    public string Nome { get; set; }
    public DateTime InicioEmprestimo { get; set; }
    
    
}

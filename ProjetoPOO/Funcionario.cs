public abstract class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }

    public Funcionario(string nome, string cargo)
    {
        Nome = nome;
        Cargo = cargo;
    }

    public abstract double CalcularCustoHora();
}

public abstract class Funcionario
{
    public string Nome { get; set; }
    public int Id { get; set; }
    public double HorasTrabalhadas { get; set; }

    public Funcionario(string nome, int id)
    {
        Nome = nome;
        Id = id;
        HorasTrabalhadas = 0;
    }

    public void RegistrarHoras(double horas)
    {
        HorasTrabalhadas += horas;
    }

    public abstract double CalcularCustoHora();
}

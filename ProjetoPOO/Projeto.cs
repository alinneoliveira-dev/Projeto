public class Projeto
{
    public string Nome { get; set; }
    public List<Alocacao> Alocacoes { get; set; } = new List<Alocacao>();

    public Projeto(string nome)
    {
        Nome = nome;
    }

    public void AdicionarAlocacao(Funcionario funcionario, int horas)
    {
        Alocacoes.Add(new Alocacao(funcionario, horas));
    }

    public double CalcularCustoTotal()
    {
        return Alocacoes.Sum(a => a.Horas * a.Funcionario.CalcularCustoHora());
    }
}

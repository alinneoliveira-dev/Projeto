public class Alocacao
{
    public Funcionario Funcionario { get; set; }
    public int Horas { get; set; }

    public Alocacao(Funcionario funcionario, int horas)
    {
        Funcionario = funcionario;
        Horas = horas;
    }
}

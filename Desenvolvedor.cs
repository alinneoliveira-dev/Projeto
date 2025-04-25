public class Desenvolvedor : Funcionario
{
    public Desenvolvedor(string nome, int id) : base(nome, id) {}

    public override double CalcularCustoHora()
    {
        return HorasTrabalhadas * 50.0; // Valor fixo de R$50 por hora
    }
}

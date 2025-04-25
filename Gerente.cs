public class Gerente : Funcionario
{
    public Gerente(string nome, int id) : base(nome, id) {}

    public override double CalcularCustoHora()
    {
        return HorasTrabalhadas * 80.0; // Valor fixo de R$80 por hora
    }
}

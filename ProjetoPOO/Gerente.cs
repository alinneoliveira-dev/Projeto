public class Gerente : Funcionario
{
    public Gerente(string nome) : base(nome, "Gerente") {}

    public override double CalcularCustoHora()
    {
        return 150.0; // valor fixo só como exemplo
    }
}

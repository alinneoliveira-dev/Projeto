public class Desenvolvedor : Funcionario
{
    public Desenvolvedor(string nome) : base(nome, "Desenvolvedor") {}

    public override double CalcularCustoHora()
    {
        return 100.0; // valor fixo só como exemplo
    }
}

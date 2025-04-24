internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario dev = new Desenvolvedor("Alice");
        Funcionario gerente = new Gerente("Carlos");

        Projeto projeto = new Projeto("Sistema ERP");

        projeto.AdicionarAlocacao(dev, 20);
        projeto.AdicionarAlocacao(gerente, 10);

        Console.WriteLine($"Projeto: {projeto.Nome}");
        Console.WriteLine($"Custo total: R${projeto.CalcularCustoTotal()}");

        Console.ReadLine();
    }
}


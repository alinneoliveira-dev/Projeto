using System;
using System.Collections.Generic;

public class Projeto
{
    public string Nome { get; set; }
    public List<Funcionario> Funcionarios { get; set; }

    public Projeto(string nome)
    {
        Nome = nome;
        Funcionarios = new List<Funcionario>();
    }

    public void AdicionarFuncionario(Funcionario funcionario)
    {
        Funcionarios.Add(funcionario);
    }

    public double CalcularTotalHoras()
    {
        double total = 0;
        foreach (var f in Funcionarios)
        {
            total += f.HorasTrabalhadas;
        }
        return total;
    }

    public double CalcularCustoTotal()
    {
        double total = 0;
        foreach (var f in Funcionarios)
        {
            total += f.CalcularCustoHora();
        }
        return total;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"\nProjeto: {Nome}");
        Console.WriteLine("Funcionários:");

        foreach (var f in Funcionarios)
        {
            Console.WriteLine($"- {f.Nome} | Horas: {f.HorasTrabalhadas} | Custo: R${f.CalcularCustoHora():F2}");
        }

        Console.WriteLine($"Total de Horas: {CalcularTotalHoras()}");
        Console.WriteLine($"Custo Total do Projeto: R${CalcularCustoTotal():F2}");
    }
}

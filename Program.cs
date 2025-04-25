using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> funcionarios = new List<Funcionario>();
        List<Projeto> projetos = new List<Projeto>();

        // Criando funcionários
        var dev1 = new Desenvolvedor("Gustavo", 1);
        dev1.RegistrarHoras(20);
        var gerente1 = new Gerente("Alinne", 2);
        gerente1.RegistrarHoras(10);

        funcionarios.Add(dev1);
        funcionarios.Add(gerente1);

        // Criando projeto
        var projeto1 = new Projeto("Sistema de Gestão de Funcionários e Projetos");
        projeto1.AdicionarFuncionario(dev1);
        projeto1.AdicionarFuncionario(gerente1);
        projetos.Add(projeto1);

        // Exibir informações
        foreach (var p in projetos)
        {
            p.ExibirInformacoes();
        }
    }
}

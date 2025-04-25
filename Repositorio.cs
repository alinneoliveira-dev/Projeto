public class Repositorio {
    public List<Funcionario> Funcionarios { get; } = new List<Funcionario>();
    public List<Projeto> Projetos { get; } = new List<Projeto>();

    public void AdicionarFuncionario(Funcionario funcionario) => Funcionarios.Add(funcionario);
    public void AdicionarProjeto(Projeto projeto) => Projetos.Add(projeto);
    public Funcionario BuscarFuncionario(string nome) => Funcionarios.FirstOrDefault(f => f.Nome == nome);
    public Projeto BuscarProjeto(string nome) => Projetos.FirstOrDefault(p => p.Nome == nome);
}

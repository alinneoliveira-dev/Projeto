# Projeto - Sistema de Gestão de Funcionários e Projetos 

## 💡 Descrição

Este projeto é um sistema desktop simples desenvolvido em C#, com foco em Programação Orientada a Objetos (POO). O objetivo é automatizar o controle de funcionários, projetos e alocações de equipe, substituindo o uso de planilhas e melhorando a rastreabilidade e segurança dos dados.


## 🧱 Conceitos de POO Aplicados com Clareza

| Conceito POO       | Onde foi usado                                              | Justificativa prática                                               |
|--------------------|-------------------------------------------------------------|----------------------------------------------------------------------|
| **Abstração**       | `Funcionario`, `Projeto`, `Alocacao`                         | Refletem entidades reais com comportamentos próprios                 |
| **Encapsulamento** | Propriedades privadas com métodos públicos                   | Protege a integridade dos dados                                      |
| **Herança**        | `Desenvolvedor` e `Gerente` herdam de `Funcionario`          | Reutilização de código e modelagem hierárquica                       |
| **Polimorfismo**   | Método `CalcularCustoHora()` sobrescrito                     | Permite comportamentos diferentes para diferentes cargos             |
| **Composição**     | `Projeto` contém `Alocacao`, que contém `Funcionario`        | Relações entre objetos simulando vínculos reais                      |


## 🛠️ Tecnologias utilizadas

- C#
- .NET 6
- VSCode ou outro editor compatível com .NET
- Programação Orientada a Objetos (POO)


## 🚀 Como executar

1. Clone o repositório:
```bash
git clone https://github.com/seu-usuario/Projeto.git

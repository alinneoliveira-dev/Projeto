# ProjetoPOO

🧩 Sistema de Gestão de Funcionários e Projetos
📋 Descrição
Este projeto é um sistema desktop simples desenvolvido em C#, com foco em Programação Orientada a Objetos (POO). O objetivo é automatizar o controle de funcionários, projetos e alocações de equipe, substituindo o uso de planilhas e melhorando a rastreabilidade e segurança dos dados.

💡 Nota: Este projeto não utiliza banco de dados no momento; todos os dados são manipulados em memória e o sistema é executado via console.

🎯 Funcionalidades
✅ Cadastro de funcionários com cargos distintos (Desenvolvedor, Gerente, etc.)

✅ Criação de projetos com nome e equipe alocada

✅ Alocação de horas trabalhadas por funcionário

✅ Cálculo automático do custo total por projeto

✅ Exibição de informações detalhadas dos projetos e funcionários

✅ Menu interativo no console

✅ Validações básicas (como impedir alocação com horas inválidas)

🧠 Conceitos Aplicados de POO
Abstração: Representação de entidades do mundo real como classes (Funcionario, Projeto, etc.)

Encapsulamento: Controle de acesso às propriedades por meio de construtores e métodos

Herança: Subclasses como Desenvolvedor e Gerente derivam de Funcionario

Polimorfismo: Método CalcularCustoHora() implementado de forma diferente para cada tipo de funcionário

💻 Como Executar
Clone o repositório:

bash
Copiar
Editar
git clone https://github.com/alinneoliveira-dev/ProjetoPOO.git
Abra o projeto em uma IDE como Visual Studio ou Visual Studio Code com o .NET SDK instalado.

Compile e execute o projeto.

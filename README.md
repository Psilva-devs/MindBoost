🧠 MindBoost
Sobre o Projeto
O MindBoost é um sistema desenvolvido em C# com Windows Forms e MySQL, criado com o objetivo de realizar uma triagem inicial relacionada ao bem-estar emocional dos usuários.
O sistema aplica um questionário estruturado, analisa as respostas fornecidas e gera relatórios com base em diferentes espectros emocionais, auxiliando na identificação de possíveis necessidades de acompanhamento.

Este projeto foi desenvolvido como atividade acadêmica do curso de Análise e Desenvolvimento de Sistemas.


Funcionalidades

* Geração de código único para cada atendimento
* Cadastro do posto/graduação do usuário
* Questionário com 25 perguntas objetivas
* Perguntas dissertativas complementares
* Cálculo automático dos espectros emocionais
* Geração de relatórios individuais
* Área administrativa para consulta de atendimentos
* Consulta de administradores e psicólogos cadastrados
* Integração com banco de dados MySQL

Tecnologias Utilizadas

* C#
* Windows Forms (WinForms)
* MySQL
* Visual Studio
* Git e GitHub


 Estrutura do Sistema

 Usuário

1. Inicia um atendimento.
2. Recebe um código único de identificação.
3. Informa seu posto ou graduação.
4. Responde ao questionário.
5. Responde às perguntas dissertativas.
6. Os dados são armazenados no banco de dados.
7. Um relatório é gerado com base nas respostas.

Administrador

* Realiza login administrativo.
* Consulta atendimentos registrados.
* Visualiza administradores cadastrados.
* Visualiza psicólogos cadastrados.
* Gera relatórios através do código do atendimento.

 Banco de Dados

O sistema utiliza MySQL para armazenar:

* Dados dos atendimentos
* Respostas do questionário
* Administradores
* Psicólogos
* Relatórios gerados


Como Executar

Pré-requisitos

* Visual Studio
* MySQL Server
* .NET Framework compatível com o projeto

 Passos

1. Clone o repositório:

```bash
git clone https://github.com/SEU-USUARIO/MindBoost.git
```

2. Abra o arquivo `.sln` no Visual Studio.

3. Configure a conexão com o banco MySQL.

4. Execute o script SQL do banco de dados.

5. Compile e execute o projeto.


 Objetivo Acadêmico

O projeto foi desenvolvido com a finalidade de aplicar conhecimentos adquiridos durante o curso de Análise e Desenvolvimento de Sistemas, envolvendo:

* Programação Orientada a Objetos
* Desenvolvimento Desktop
* Banco de Dados
* Integração com MySQL
* Estruturação de Sistemas
* Trabalho em Equipe


Integrantes

* Pedro Silva dos Santos
* Júlia Caldas Corisco
* Ryan Gouveia Bezerra


Instituição

Instituto Federal de Educação, Ciência e Tecnologia de São Paulo – Campus Campinas


 Licença

Projeto desenvolvido para fins acadêmicos.

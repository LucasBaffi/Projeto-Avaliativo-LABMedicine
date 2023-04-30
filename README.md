Projeto Avaliativo LABMedicine

O Projeto Avaliativo LABMedicine é uma solução criada para gerenciar atendimentos médicos em uma clínica. Ele permite cadastrar pacientes e médicos, agendar atendimentos, registrar informações sobre os atendimentos realizados e consultar histórico de atendimentos dos pacientes.

Tecnologias Utilizadas

C# ASP.NET Core Entity Framework Core SQL Server Swagger

Funcionalidades

Pacientes Cadastrar
paciente Consultar
paciente pelo ID Consultar lista de
pacientes Atualizar informações do paciente 
Excluir paciente

Médicos

Cadastrar médico 
Consultar médico pelo ID 
Consultar lista de médicos 
Atualizar informações do médico
Excluir médico

Atendimentos

Agendar atendimento 
Consultar atendimento pelo ID
Consultar lista de atendimentos 
Registrar informações do atendimento
Cancelar atendimento


O projeto LABMedicine consiste em um sistema de gerenciamento de atendimentos médicos para clínicas e laboratórios. O objetivo principal do sistema é auxiliar no agendamento e acompanhamento dos atendimentos dos pacientes, além de possibilitar a geração de relatórios e estatísticas para análise dos dados.

O sistema é desenvolvido em C# utilizando o framework .NET e a plataforma ASP.NET Core para a construção da API RESTful. O banco de dados utilizado é o SQL Server e o ORM utilizado é o Entity Framework Core. Além disso, o projeto segue os padrões de arquitetura em camadas, utilizando as camadas de apresentação, aplicação, domínio e infraestrutura.

Na camada de apresentação, é utilizada a biblioteca Swagger para documentação e teste da API, além da implementação de autenticação e autorização através do ASP.NET Identity. Na camada de aplicação, são implementados os serviços responsáveis pela regra de negócio do sistema, bem como a implementação de mapeamento de objetos utilizando a biblioteca AutoMapper.

Na camada de domínio, são implementadas as entidades do sistema, como Paciente, Médico e Atendimento, além de suas respectivas interfaces e validações. Na camada de infraestrutura, são implementados os repositórios que fazem a comunicação com o banco de dados, bem como a implementação do DbContext.

O projeto ainda conta com testes unitários implementados utilizando o framework xUnit.net e a biblioteca Moq para simulação de objetos. Além disso, é utilizado o padrão de injeção de dependência para facilitar a manutenção e extensibilidade do sistema.

Para executar o sistema, basta clonar o repositório, configurar a string de conexão com o banco de dados no arquivo appsettings.json e executar o comando dotnet run. O sistema estará disponível na porta 5000 (http://localhost:5000) e a documentação da API estará disponível na rota /swagger (http://localhost:5000/swagger/index.html).

Entre as possíveis melhorias para o sistema, pode-se destacar a implementação de uma camada de apresentação em front-end para melhorar a experiência do usuário, além da implementação de novas funcionalidades, como o agendamento de consultas online e o envio de lembretes por e-mail para os pacientes.

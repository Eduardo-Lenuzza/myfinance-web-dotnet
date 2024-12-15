# Projeto: Sistema de Gestão Financeira (myfinance-web-dotnet)

![.NET](https://img.shields.io/badge/.NET-6.0-blueviolet?style=flat-square) ![C#](https://img.shields.io/badge/C%23-10.0-239120?style=flat-square) ![SQL Server](https://img.shields.io/badge/SQL%20Server-2019-red?style=flat-square)

## Descrição

Este projeto é uma aplicação desenvolvida em C# utilizando o framework ASP.NET Core, que permite o gerenciamento financeiro por meio de duas telas principais:

1. **Cadastro de Receitas ou Despesas**
   - Permite registrar despesas ou receitas, informando dados como descrição, valor, tipo (receita ou despesa) e data.

2. **Listagem de Receitas e Despesas**
   - Exibe uma tabela com todas as receitas e despesas cadastradas, permitindo visualização fácil dos dados financeiros.

## Tecnologias Utilizadas

- **Linguagem**: C#
- **Framework**: ASP.NET Core 6.0
- **Banco de Dados**: SQL Server 2019
- **Ferramentas Adicionais**: Entity Framework Core para ORM

## Funcionalidades

- **Cadastro**: Adição de receitas e despesas.
- **Listagem**: Exibição de todas as entradas financeiras registradas.

## Requisitos

Para rodar o projeto, você precisará dos seguintes requisitos:

- **SDK do .NET 6.0 ou superior**
- **SQL Server 2019 ou superior**
- **Visual Studio 2022** (ou IDE equivalente com suporte ao .NET Core)

## Configuração do Banco de Dados

1. Certifique-se de que o SQL Server esteja em execução.
2. Atualize a string de conexão no arquivo `appsettings.json` com as credenciais e o nome do seu banco de dados:
   ```json
   {
       "ConnectionStrings": {
           "DefaultConnection": "Server=LOCALHOST\SQLEXPRESS;Database=myfinance;Trusted_Connection=True;TrustServerCertificate=True;"
       }
   }
   ```
3. Execute as migrações para configurar o banco de dados:
   ```bash
   dotnet ef database update
   ```

## Instalação e Execução

1. Clone o repositório:
   ```bash
   git clone https://github.com/Eduardo-Lenuzza/myfinance-web-dotnet.git
   ```
2. Navegue até o diretório do projeto:
   ```bash
   cd myfinance-web-dotnet
   ```
3. Restaure as dependências:
   ```bash
   dotnet restore
   ```
4. Compile o projeto:
   ```bash
   dotnet build
   ```
5. Inicie a aplicação:
   ```bash
   dotnet run
   ```
6. Acesse a aplicação no navegador em [http://localhost:5211].

## Estrutura do Projeto

```plaintext
├── Controllers
|   ├── HomeController.cs  # Lida com as requisições na tela Home
│   ├── PlanoContaController.cs  # Lida com as requisições na tela Plano de Contas
├── Docs
│   ├── myfinance.sql  # Script de criação das tabelas
│   ├── queries.sql  # Script de carga e consulta
├── Domain
│   ├── PlanoConta.cs  # Entidade Plano de Conta
├── Infrastructure
│   ├── MyFinanceDbContext.cs  # Configuração de acesso ao banco de dados
├── Models
│   ├── PlanoContaModel.cs       # Representa o modelo de Plano de Contas
├── Services
│   ├── IPlanoContaService.cs       # Serviço de Plano de Contas
│   ├── PlanoContaService.cs       # Serviço de Plano de Contas
├── Views
│   ├── Home
│       ├── Index.cshtml     # Tela de Index
│       ├── Privacy.cshtml      # Tela de Privacy
│   ├── PlanoConta
│       ├── Cadastro.cshtml     # Tela de cadastro
│       ├── Index.cshtml      # Tela de listagem
├── appsettings.json          # Configuração da aplicação
```

## Contribuição

Sinta-se à vontade para contribuir com este projeto! Faça um fork do repositório, crie uma branch para sua feature ou correção e envie um pull request.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).

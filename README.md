# PescaAPI


Este é um projeto de API desenvolvido em C# utilizando o ASP.NET Core. O Swagger é integrado para documentar a API, permitindo fácil visualização e teste dos endpoints.

## Funcionalidades

- Endpoints de API RESTful desenvolvidos em ASP.NET Core
- Documentação automática com Swagger
- Estrutura modular para facilitar manutenção e extensão

## Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) - versão 6.0 ou superior

## Instalação

Para instalar e configurar o projeto, siga os passos abaixo:

1. Clone o repositório para o seu ambiente local:

   ```bash
   git clone https://github.com/seu-usuario/nome-do-repositorio.git
   ```

2. Acesse a pasta do projeto:

   ```bash
   cd nome-do-repositorio
   ```

3. Restaure as dependências do projeto:

   ```bash
   dotnet restore
   ```

## Executando o Projeto

Para iniciar o projeto em modo de desenvolvimento, execute o comando:

```bash
dotnet run
```

A API estará disponível em [http://localhost:5000](http://localhost:5000) e a documentação Swagger em [http://localhost:5000/swagger](http://localhost:5000/swagger).

## Uso do Swagger

A documentação gerada pelo Swagger permite visualizar todos os endpoints disponíveis, parâmetros de entrada, e respostas esperadas. Você pode testar diretamente cada endpoint a partir da interface Swagger, sem necessidade de ferramentas externas como Postman.

Para acessar a interface Swagger:

1. Inicie o projeto com `dotnet run`
2. Acesse [http://localhost:5000/swagger](http://localhost:5000/swagger) em seu navegador

### Principais Dependências

- [ASP.NET Core](https://dotnet.microsoft.com/apps/aspnet) - Framework para desenvolvimento de APIs em C#
- [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle.AspNetCore) - Implementação de Swagger para ASP.NET Core



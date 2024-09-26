# 📚 Projeto Web API com .NET 8 e SQL Server | CRUD + Repository Pattern

Este projeto foi desenvolvido durante o curso de **Web API com .NET 8 e SQL Server**, onde foi implementado um sistema de CRUD (Create, Read, Update, Delete) para gerenciar autores e livros, utilizando o padrão de repositório (Repository Pattern) e a injeção de dependências.


## Funcionalidades

- **CRUD de Autores**:
  - Criar novo autor
  - Listar todos os autores
  - Listar autor por ID
  - Editar autor
  - Excluir autor

- **CRUD de Livros**:
  - Criar novo livro
  - Listar todos os livros
  - Listar livro por ID
  - Editar livro
  - Excluir livro

- **Relacionamento Autor-Livro**:
  - Um autor pode ter vários livros (relação 1:N)
  - Um livro pode ter apenas um autor

## Tecnologias Utilizadas

- **.NET 8**: Framework utilizado para construir a API
- **Entity Framework Core**: ORM utilizado para mapear o banco de dados
- **SQL Server**: Banco de dados utilizado para armazenar as informações
- **Repository Pattern**: Padrão de repositório para organizar o código e separar a lógica de acesso aos dados
- **Injeção de Dependências**: Utilizada para desacoplar as camadas do projeto
- **Swagger**: Utilizado para documentar e testar os endpoints da API

## Estrutura do Projeto

- **Controllers**: Controlam as requisições HTTP e chamam os serviços necessários
- **Models**: Definem as entidades do sistema (Autor, Livro)
- **Services**: Contêm a lógica de negócio e interagem com o repositório
- **Repository**: Responsável por acessar o banco de dados e retornar os dados para os serviços
- **DTOs (Data Transfer Objects)**: Utilizados para transferir dados entre as camadas da aplicação de forma mais segura e otimizada

## Como Executar o Projeto

1. Clone o repositório
   ```bash
   git clone https://github.com/seuusuario/seurepositorio.git
2. Abra o projeto no Visual Studio.

3. Configure a string de conexão com o SQL Server no arquivo appsettings.json:
"ConnectionStrings": {
  "DefaultConnection": "Server=SEU_SERVIDOR;Database=NomeDoBancoDeDados;Trusted_Connection=True;"
}

4. Abra o Console do Gerenciador de Pacotes e execute os seguintes comandos para aplicar as migrações e criar o banco de dados:
Update-Database

5. Execute o projeto e acesse o Swagger em https://localhost:7053/swagger/ para testar os endpoints.


## Endpoints Principais

### Autores
- `GET /api/autores`: Lista todos os autores
- `GET /api/autores/{id}`: Retorna um autor pelo ID
- `POST /api/autores`: Cria um novo autor
- `PUT /api/autores/{id}`: Edita um autor existente
- `DELETE /api/autores/{id}`: Exclui um autor

### Livros
- `GET /api/livros`: Lista todos os livros
- `GET /api/livros/{id}`: Retorna um livro pelo ID
- `POST /api/livros`: Cria um novo livro
- `PUT /api/livros/{id}`: Edita um livro existente
- `DELETE /api/livros/{id}`: Exclui um livro

Este projeto foi desenvolvido por mim durante o curso de Web API com .NET 8 e SQL Server. Se tiver alguma dúvida ou sugestão, fique à vontade para entrar em contato!

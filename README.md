# Comandos iniciais:

``` bash
    mkdir mvc_entity
    cd mvc_entity
    dotnet run mvc
```

### gerei o conteúdo para ignorar itens como (Windows, Linux, MacOS, DotnetCore, VisualStudioCore) no link https://www.toptal.com/developers/gitignore
``` bash
    code .gitignore 
```

# Comandos git:
- Criei o repositório e rodei os comandos:
``` bash
    git init
    git add .
    git commit -m "Iniciando projeto"
    git remote add origin git@github.com:alejandro-espejo/aula-desafio21dias-mvc-entity-framework.git
    git branch -M main
    git push -u origin main
```

# Componentes instalados:
``` bash
    dotnet add package Microsoft.EntityFrameworkCore --version 8.0.1
    dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.1
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.1
    dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 8.0.0
```

# Comandos para migração:
``` bash
    dotnet tool install --global dotnet-ef
    dotnet ef migrations add ModeloAluno
    dotnet ef database update
```

# Instalação do code generator
``` bash
    dotnet tool install -g dotnet-aspnet-codegenerator
```

# Gerando o scaffold de Carros
``` bash
    dotnet aspnet-codegenerator controller -name AlunosController -m Aluno -dc DbContexto --relativeFolderPath Controllers --useDefaultLayout
```
# Um pouco sobre API REST
GET - Buscar Informações
POST - Cadastrar informações
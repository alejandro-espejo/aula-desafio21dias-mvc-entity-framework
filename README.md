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
```
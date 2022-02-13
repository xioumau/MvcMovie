# MvcMovie
## Aplicativo ASP.NET MVC para estudo a partir da documentação da Microsoft.

Execute o comando no terminal para criar um novo projeto ASP.NET Core MVC, digite no terminal:
```
dotnet new mvc -o MvcMovie 
```

Execute o comando no terminal para carregar o arquivo de projeto MvcMovie.csproj em Visual Studio Code.
```
code -r MvcMovie
```

No terminal adicione ferramentas de linha de comando, scaffolding aspnet.codegenerator e dependências Entity Framework ao projeto. Todos na versão 5.0.0:
```
dotnet tool install --global dotnet-ef --version 5.0.0
dotnet tool install --global dotnet-aspnet-codegenerator --version 5.0.0   
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.0  
dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.0.0
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.0
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.0
dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore --version 5.0.0
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 5.0.0
dotnet add package Microsoft.AspNetCore.Identity.UI --version 5.0.0
```

Exportar o caminho da ferramenta Scaffold:
```
export PATH=$HOME/.dotnet/tools:$PATH
```

Execute o seguinte comando:
```
dotnet-aspnet-codegenerator controller -name MoviesController -m Movie -dc MvcMovieContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
```

Em caso de dúvida em relação ao comando acima, acesse a [documentação dotnet-ASPNET-CodeGenerator](https://docs.microsoft.com/pt-br/aspnet/core/fundamentals/tools/dotnet-aspnet-codegenerator?view=aspnetcore-5.0).

Se for usuário do Linux, ao executar o comando acima pode aparecer essa saída de erro no terminal:
```
A file matching the name NewLocalDbContext.cshtml was not found within any of the folders: 
   at Microsoft.VisualStudio.Web.CodeGeneration.ActionInvoker.<BuildCommandLine>b__6_0()
   at Microsoft.Extensions.CommandLineUtils.CommandLineApplication.Execute(String[] args)
   at Microsoft.VisualStudio.Web.CodeGeneration.ActionInvoker.Execute(String[] args)
   at Microsoft.VisualStudio.Web.CodeGeneration.CodeGenCommand.Execute(String[] args)
```

Se for o caso, você pode achar a solução no repositório do [Scaffolding](https://github.com/dotnet/Scaffolding/issues/1387#issuecomment-735289808)

Gera um arquivo de migração Migrations/{timestamp}_InitialCreate.cs:
```
dotnet ef migrations add InitialCreate
```

Para atualizar o banco de dados para a migração mais recente, que o comando anterior criou:
```
dotnet ef database update
```

Instale o jQuery:
```
sudo apt install jq
```

E o pacote de validação do jQuery:
```
dotnet add package jQuery.Validation
```

Se alguma alteração no código for feita de modo que altere a estrutura do banco de dados, como por exemplo, adicionar uma nova propriedade em alguma classe que gere uma nova coluna no banco de dados, é necessário excluir o banco de dados e gerar um novo:

Exluir o banco de dados:
```
dotnet ef database drop
```

Gerar um banco de dados novo com as modificações:
```
dotnet ef database update
```
Assim cabe ao EF gerar o banco de dados novo.
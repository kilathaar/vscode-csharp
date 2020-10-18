# vscode-csharp

Experimentellt projekt för att lära mig sätta upp projekt för [C#](https://docs.microsoft.com/en-us/dotnet/csharp/).

*(Självklart är detta projekt extremt överkonstruerat för det lilla som produceras)*

1. Installera [Visual Studio Code](https://code.visualstudio.com/)
1. Installera [.NET Core SDK](https://dotnet.microsoft.com/download)

## Katalogstruktur
[Organizing and testing projects with the .NET Core CLI](https://docs.microsoft.com/en-us/dotnet/core/tutorials/testing-with-cli) visar nedanstående katalogstruktur:

```
/NewTypes
|__/src
   |__/NewTypes
      |__/Pets
         |__Dog.cs
         |__Cat.cs
         |__IPet.cs
      |__Program.cs
      |__NewTypes.csproj
|__/test
   |__NewTypesTests
      |__PetTests.cs
      |__NewTypesTests.csproj
```
Den påminner tillräckligt om den katalogstruktur jag brukar använda för Java så den tänker jag försöka följa.

## Solutions
Referens: [What's the purpose of using solution files for DotNet Core projects?](https://stackoverflow.com/questions/43426982/dotnet-core-purpose-of-solution-files)

*Solutions* hjälper dig gruppera flera projekt. Om man t ex vill följa [The Clean Architecture](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)
skulle man kunna skapa ett projekt för varje "lager" och lägga till respektive projekt i en *Solution*. När man sedan vill bygga hela systemet slipper man bygga varje
projekt individuellt.

### Skapa en *Solution*
Se `dotnet new sln --help`

För detta repository användes kommandot `dotnet new sln -n HelloWorld -o HelloWorld`

## Instruktioner för att återskapa katalogstruktur i detta projekt
ALla kommandon har exekverats i ett Git Bash-shell.

Punkt 6 - 10 repeteras för varje projekt som skall läggas till.

1. Skapa projekt på GitHub och klona det till lokal katalog.
1. `cd vscode-csharp`
1. `dotnet new sln -n HelloWorld -o HelloWorld`
1. `cd HelloWorld`
1. Konfigurera [.gitignore](https://raw.githubusercontent.com/dotnet/core/master/.gitignore)
1. `projekt="Applikation"`
1. `dotnet new console -n ${projekt} -o $projekt/src/${projekt}`
1. `dotnet new nunit -n ${projekt}Tests -o ${projekt}/test/${projekt}Tests`
1. `dotnet add ${projekt}/test/${projekt}Tests/${projekt}Tests.csproj reference ${projekt}/src/${projekt}/${projekt}.csproj`
1. `dotnet sln add ${projekt}/src/${projekt}/${projekt}.csproj`

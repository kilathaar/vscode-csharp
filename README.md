# vscode-csharp

Experimentellt projekt för att lära mig sätta upp projekt för [C#](https://docs.microsoft.com/en-us/dotnet/csharp/).

1. Installera [Visual Studio Code](https://code.visualstudio.com/)
1. Installera [.NET Core SDK](https://dotnet.microsoft.com/download)

## Solutions
Referens: [What's the purpose of using solution files for DotNet Core projects?](https://stackoverflow.com/questions/43426982/dotnet-core-purpose-of-solution-files)

*Solutions* hjälper dig gruppera flera projekt. Om man t ex vill följa [The Clean Architecture](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)
skulle man kunna skapa ett projekt för varje "lager" och lägga till respektive projekt i en *Solution*. När man sedan vill bygga hela systemet slipper man bygga varje
projekt individuellt.

### Skapa en *Solution*
Se `dotnet new sln --help`

För detta repository användes kommandot `dotnet new sln -n HelloWorld -o HelloWorld`

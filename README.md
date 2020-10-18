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

## Solutions
Referens: [What's the purpose of using solution files for DotNet Core projects?](https://stackoverflow.com/questions/43426982/dotnet-core-purpose-of-solution-files)

*Solutions* hjälper dig gruppera flera projekt. Om man t ex vill följa [The Clean Architecture](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)
skulle man kunna skapa ett projekt för varje "lager" och lägga till respektive projekt i en *Solution*. När man sedan vill bygga hela systemet slipper man bygga varje
projekt individuellt.

### Skapa en *Solution*
Se `dotnet new sln --help`

För detta repository användes kommandot `dotnet new sln -n HelloWorld -o HelloWorld`

## Skapa ett konsoll-projekt
Det finns säkert någon mer elegant lösning men detta var vad jag gjorde.

1. `cd HelloWorld`
1. Konfigurera [.gitignore](https://raw.githubusercontent.com/dotnet/core/master/.gitignore)
1. `dotnet new console -n Applikation`
1. `cd Applikation`
1. `mkdir -p src/main`
1. `mv Program.cs src/main`
1. `cd ..`
1. `dotnet sln add Applikation/Applikation.csproj`

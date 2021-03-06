# vscode-csharp

Experimentellt projekt för att lära mig sätta upp projekt för [C#](https://docs.microsoft.com/en-us/dotnet/csharp/).

*(Självklart är detta projekt extremt överkonstruerat för det lilla som produceras)*

[Installera och konfigurera Visual Studio Code](https://gist.github.com/kilathaar/845d406246de5fc42275bfe9c531db5e)

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

Se [C# solution katalogstruktur](https://gist.github.com/kilathaar/510457073616ed3479509db1df022a38) för exempel på kommandon man kan skriva.

[![Build-Deploy](https://github.com/datafac/template/actions/workflows/dotnet.yml/badge.svg)](https://github.com/datafac/template/actions/workflows/dotnet.yml)

# Datafac.Template
A template repo for quickly creating a C# .NET package which builds on GitHub 
and publishes to NuGet.

## In-the-box
- Visual Studio centric .gitignore
- Github workflow to build, test and deploy to Nuget
- NerdBank.GitVersioning
- build status badge
- package targets netstandard2.0, net8.0, net9.0
- includes publishing symbols (snupkg)
- XUnit test project using Shoudly, VerifyXUnit and PublicApiGenerator
- unit tests target net481, net8.0, net9.0

## How to use
1. Create a new repo by importing this repo.
2. Rename the solution and project files to your new package name.
   - e.g. Datafac.Template.sln to MyCompany.MyPackage.sln
   - e.g. Datafac.Template.csproj to MyCompany.MyPackage.csproj
   - e.g. Datafac.Template.Tests.csproj to MyCompany.MyPackage.Tests.csproj
3. Globally rename the namespace 'Datafac.Template' to your new package name.
   - e.g. Datafac.Template to MyCompany.MyPackage
4. Rename MyClass.cs to match your first class name.
5. Rename MyClassTests.cs to match your first test class name.
6. Update version.json and readme.md
7. Update the license properties in the .csproj file.
8. Make sure your Nuget API key is not expired and the
   saved as a Github secret named NUGET_APIKEY.
9. Push!

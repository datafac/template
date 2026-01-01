
# Datafac.Template
A template repo for quickly creating a C# .NET package which builds on GitHub 
and publishes to NuGet.

[![Build-Deploy](https://github.com/datafac/template/actions/workflows/dotnet.yml/badge.svg)](https://github.com/datafac/template/actions/workflows/dotnet.yml)
![NuGet Version](https://img.shields.io/nuget/v/Datafac.Template)
![GitHub License](https://img.shields.io/github/license/Datafac/Template)
![NuGet Downloads](https://img.shields.io/nuget/dt/Datafac.Template)
![GitHub Sponsors](https://img.shields.io/github/sponsors/psiman62)


## In-the-box
- Visual Studio centric .gitignore
- Github workflow to build, test and deploy to Nuget
- NerdBank.GitVersioning
- strong naming
- build status and other badges
- package targets netstandard2.0, net8.0, net9.0, net10.0
- includes publishing symbols (snupkg)
- XUnit test project using Shoudly, VerifyXUnit and PublicApiGenerator
- unit tests target net481, net8.0, net9.0

## How to use
1. Create a new repo by importing this repo.
2. Rename the solution and project files to your new package name.
   - e.g. Datafac.Template.sln to MyOrgName.MyPackage.sln
   - e.g. Datafac.Template.csproj to MyOrgName.MyPackage.csproj
   - e.g. Datafac.Template.Tests.csproj to MyOrgName.MyPackage.Tests.csproj
3. Globally rename the namespace 'Datafac.Template' to your new package name.
   - e.g. Datafac.Template to MyOrgName.MyPackage
4. Rename MyClass.cs to match your first class name.
5. Rename MyClassTests.cs to match your first test class name.
6. Update version.json and readme.md
7. Generate and update SigningKey.snk
8. Update the license properties in the .csproj file.
9. Make sure your Nuget API key is not expired and is
   saved as a Github secret named NUGET_APIKEY.
10. Commit and push!

## Coming soon
- Sample Benchmarking project using BenchmarkDotNet.
- Sample data modelling project using DTOMaker.

## How to sponsor
If you find this template useful, please consider sponsoring my work on GitHub 
at https://github.com/sponsors/Psiman62
or buy me a coffee at https://www.buymeacoffee.com/psiman62
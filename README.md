[![Build-Deploy](https://github.com/datafac/template/actions/workflows/dotnet.yml/badge.svg)](https://github.com/datafac/template/actions/workflows/dotnet.yml)

# Datafac.Template
A template repo for quickly creating a .NET package which builds on GitHub 
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
1. Clone this repo.
2. Globally rename namespace 'Datafac' to your organisation name.
3. Globally rename namespace 'Template' to your new package name.
	- don't forget project folders!
4. Rename MyClass.cs to your first class name.
5. Update version.json and readme.md
6. Make sure your Nuget API key is not expired and the
   saved as a Github secret named NUGET_APIKEY.
7. Push!

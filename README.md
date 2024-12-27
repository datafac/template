# Datafac.Template
A template repo for quickly creating .NET packages.

## In-the-box
- Visual Studio centric .gitignore
- Github workflow to build, test and deploy to Nuget
- NerdBank.Gitversioning
- package targets netstandard2.0, net8.0, net9.0
- includes publishing symbols (snupkg)
- XUnit test project using FluentAssertions and VerifyXUnit
- tests target net481, net6.0, net7.0, net8.0, net9.0

## How to use
1. Clone this repo.
2. Globally rename 'datafac' to your organisation name.
3. Globally rename 'template' to your new package name.
	- don't forget project folders!
4. Update version.json and readme.md
5. Make sure your Nuget API key is not expired and the
   saved as a Github secret named NUGET_APIKEY.
6. Push!

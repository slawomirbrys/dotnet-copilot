# dotnet-copilot

A .NET 10 console application demonstrating CLI tool development with [Spectre.Console.Cli](https://spectreconsole.net/cli/getting-started). Built as a learning/reference project for creating well-structured .NET CLI apps using AI-assisted (copilot) development.

## Commands

### `weather <city>`

Fetches and displays the current weather for a given city using the [wttr.in](https://wttr.in) service.

```
dotnet run --project src -- weather Rapperswil
dotnet run --project src -- weather London
```

## Requirements

- .NET 10 SDK

## Build & Run

```bash
dotnet build
dotnet run --project src -- <command> [arguments]
```

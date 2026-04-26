# dotnet-copilot

A .NET 10 console application demonstrating CLI tool development with [Spectre.Console.Cli](https://spectreconsole.net/cli/getting-started). Built as a learning/reference project for creating well-structured .NET CLI apps using AI-assisted (copilot) development.

## Commands

### `weather <city>`

Fetches and displays the current weather for a given city using the [wttr.in](https://wttr.in) service.

```
dotnet run --project src -- weather Rapperswil
dotnet run --project src -- weather London
```

### `math add <first> <second>`

Adds two numbers together and prints the result.

```
dotnet run --project src -- math add 3 5
# Sum of 3 + 5 is 8
```

### `math sub <first> <second>`

Subtracts the second number from the first and prints the result.

```
dotnet run --project src -- math sub 10 3
# Difference of 10 - 3 is 7
```

### `math mul <first> <second>`

Multiplies two numbers together and prints the result.

```
dotnet run --project src -- math mul 4 7
# Product of 4 * 7 is 28
```

### `math div <first> <second>`

Divides the first number by the second and prints the result.

```
dotnet run --project src -- math div 10 2
# Quotient of 10 / 2 is 5
```

## Requirements

- .NET 10 SDK

## Build & Run

```bash
dotnet build
dotnet run --project src -- <command> [arguments]
```

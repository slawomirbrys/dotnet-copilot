# Instructions for this project

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Build & Run

```bash
dotnet build
dotnet run --project src -- weather <city>
```

## Project Structure

- Solution file: `console-copilot.slnx` (.slnx format, not .sln)
- App source: `src/` — single project `console-copilot.csproj` targeting net10.0
- CLI framework: [Spectre.Console.Cli](https://spectreconsole.net/cli/getting-started)

## Architecture

The app is a `Spectre.Console.Cli` command-line tool. Each command is a class inheriting `AsyncCommand<TSettings>` with a nested `Settings` class for arguments/options. `Program.cs` wires commands into the `CommandApp`. New commands follow this pattern:

1. Create `FooCommand : AsyncCommand<FooCommand.Settings>` in `src/`
2. Register in `Program.cs` via `config.AddCommand<FooCommand>("foo")`
3. Readme.md file in root folder lists all possible commands with simple example

## Git Workflow

After completing tasks: commit with a descriptive message and ask to create a pull request to remote. Use `.slnx` for solution files — do not use `dotnet sln migrate` (not a valid CLI command); create `.slnx` files manually or via `dotnet new sln`.

using Spectre.Console;
using Spectre.Console.Cli;

namespace Brys.DotNet.ConsoleByCopilot;

internal sealed class AboutCommand : AsyncCommand
{
    public override Task<int> ExecuteAsync(CommandContext context)
    {
        AnsiConsole.MarkupLine("[bold cyan]dotnet-copilot[/]");
        AnsiConsole.MarkupLine("");
        AnsiConsole.MarkupLine("[bold]Author:[/] Slawomir Brys");
        AnsiConsole.MarkupLine("[bold]GitHub:[/] github.com/slawomirbrys");
        AnsiConsole.MarkupLine("");
        AnsiConsole.MarkupLine("A .NET console tool built with [link=https://spectreconsole.net]Spectre.Console[/].");
        return Task.FromResult(0);
    }
}

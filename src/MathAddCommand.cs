using System.ComponentModel;
using Spectre.Console;
using Spectre.Console.Cli;

namespace Brys.DotNet.ConsoleByCopilot;

internal sealed class MathAddCommand : AsyncCommand<MathAddCommand.Settings>
{
    public sealed class Settings : CommandSettings
    {
        [CommandArgument(0, "<first>")]
        [Description("The first number to add.")]
        public double First { get; init; }

        [CommandArgument(1, "<second>")]
        [Description("The second number to add.")]
        public double Second { get; init; }
    }

    public override Task<int> ExecuteAsync(CommandContext context, Settings settings)
    {
        var result = settings.First + settings.Second;
        AnsiConsole.WriteLine($"Sum of {settings.First} + {settings.Second} is {result}");
        return Task.FromResult(0);
    }
}

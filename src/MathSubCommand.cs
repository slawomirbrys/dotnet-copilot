using System.ComponentModel;
using Spectre.Console;
using Spectre.Console.Cli;

namespace Brys.DotNet.ConsoleByCopilot;

internal sealed class MathSubCommand : AsyncCommand<MathSubCommand.Settings>
{
    public sealed class Settings : CommandSettings
    {
        [CommandArgument(0, "<first>")]
        [Description("The first number to subtract from.")]
        public double First { get; init; }

        [CommandArgument(1, "<second>")]
        [Description("The second number to subtract.")]
        public double Second { get; init; }
    }

    public override Task<int> ExecuteAsync(CommandContext context, Settings settings)
    {
        var result = settings.First - settings.Second;
        AnsiConsole.WriteLine($"Difference of {settings.First} - {settings.Second} is {result}");
        return Task.FromResult(0);
    }
}

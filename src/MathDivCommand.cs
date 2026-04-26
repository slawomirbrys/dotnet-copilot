using System.ComponentModel;
using Spectre.Console;
using Spectre.Console.Cli;

namespace Brys.DotNet.ConsoleByCopilot;

internal sealed class MathDivCommand : AsyncCommand<MathDivCommand.Settings>
{
    public sealed class Settings : CommandSettings
    {
        [CommandArgument(0, "<first>")]
        [Description("The dividend (number to divide).")]
        public double First { get; init; }

        [CommandArgument(1, "<second>")]
        [Description("The divisor (number to divide by).")]
        public double Second { get; init; }
    }

    public override ValidationResult Validate(CommandContext context, Settings settings)
    {
        if (settings.Second == 0)
            return ValidationResult.Error("Divisor cannot be zero.");
        return ValidationResult.Success();
    }

    public override Task<int> ExecuteAsync(CommandContext context, Settings settings)
    {
        var result = settings.First / settings.Second;
        AnsiConsole.WriteLine($"Quotient of {settings.First} / {settings.Second} is {result}");
        return Task.FromResult(0);
    }
}

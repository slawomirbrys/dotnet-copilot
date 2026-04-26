using Brys.DotNet.ConsoleByCopilot;
using Spectre.Console.Cli;

var app = new CommandApp();
app.Configure(config =>
{
    config.AddCommand<WeatherCommand>("weather")
          .WithDescription("Get current weather for a city.")
          .WithExample("weather", "Rapperswil")
          .WithExample("weather", "London");
    config.AddCommand<AboutCommand>("about")
          .WithDescription("Show information about the author of this project.");
    config.AddBranch("math", math =>
    {
        math.AddCommand<MathAddCommand>("add")
            .WithDescription("Add two numbers together.")
            .WithExample("math", "add", "3", "5");
        math.AddCommand<MathSubCommand>("sub")
            .WithDescription("Subtract two numbers.")
            .WithExample("math", "sub", "10", "3");
        math.AddCommand<MathMulCommand>("mul")
            .WithDescription("Multiply two numbers.")
            .WithExample("math", "mul", "4", "7");
        math.AddCommand<MathDivCommand>("div")
            .WithDescription("Divide two numbers.")
            .WithExample("math", "div", "10", "2");
    });
});

return await app.RunAsync(args);

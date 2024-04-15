using RDotNet;
using RSingletonPattern.API.Arguments;
using RSingletonPattern.API.Interfaces.Services;
using RSingletonPattern.API.Settings;

namespace RSingletonPattern.API.Services;

public sealed class RService : IRService
{
    public int SumTwoNumbers(SumTwoNumbers sum)
    {
        var rEngine = RSingleton.GetInstance();

        const string sumNumbersFilePath = "/RFiles/sum_numbers.R";
        var scriptPath = Directory.GetCurrentDirectory().Replace('\\', '/') + sumNumbersFilePath ;

        var sumResult = rEngine.Evaluate($@"source('{scriptPath}')
            result <- sum_numbers({sum.Number1}, {sum.Number2})");

        return sumResult.AsInteger().FirstOrDefault();
    }
}

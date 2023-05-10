// Switch Statements
using SwitchStatements;

DisplayMeasurement(30);

void DisplayMeasurement(double measurement)
{
    switch (measurement)
    {
        case < 0.0:
            Console.WriteLine($"Measured value is {measurement}; too low");
            break;
        case > 15.0:
            Console.WriteLine($"Measured value is {measurement}; too high");
            break;
        case double.NaN:
            Console.WriteLine("Failed");
            break;
        default:
            Console.WriteLine($"Measure value is {measurement}");
            break;
    }
}


State state = State.Active;

switch (state)
{
    case State.Active:
        Console.WriteLine("Active");
        break;
    case State.Inactive:
        Console.WriteLine("Inactive");
        break;
    default:
        throw new Exception(String.Format("Unknown state: {0}", state));
        break;
}


Console.WriteLine(Classify(23));
static string Classify(double measurement1) => measurement1 switch
{
    < -4.0 => "Too low",
    > 10.0 => "Too High",
    double.NaN => "Unknown",
    _ => "Acceptable"
};
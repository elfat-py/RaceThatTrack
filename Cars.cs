namespace RaceThatTrack;

public class Cars
{
    //We have created a dictionary that is going to return us different attributes of the car depending on it's name.
    private static readonly Dictionary<string, (int, int, int)> CarCharacteristics = new Dictionary<string, (int, int, int)>
    {
        { "tesla", (120, 200, 99) }, //The first value of the car is the AVG speed with which the car starts racing (the coeficent of discharge will be 1), second value is the max speed, third is battery capacity
        { "ferrari", (140, 280, 60) },
        { "mercedesamg", (135, 250, 70) },
        { "porsche", (120, 220, 140) },
        { "mclaren", (110, 260, 80) }
    };
    
    //Here we are getting the name of the car
    public string CarName { get; private set; }
    
    //Here we are getting and setting the car features
    public (int, int, int) CarFeatures { get; private set; }

    public Cars(string carName)
    {
        if (CarCharacteristics.TryGetValue(carName, out var characteristics))
        {
            CarName = carName.ToLower();
            CarFeatures = characteristics;
        }
        else
        {
            throw new ArgumentException($"Unknown car name: {carName}", nameof(carName));
        }
    }
    
    public void PresentCar()
    {
        Console.WriteLine($"Car name: {char.ToUpper(this.CarName[0]) + this.CarName.Substring(1)} \n - Speed: {this.CarFeatures.Item1}, \n Max Speed: {this.CarFeatures.Item2}, \n Battery: {this.CarFeatures.Item3}");
    }
}
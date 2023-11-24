namespace RaceThatTrack;

public class Interface
{
    

    public void ProgramInterface()
    {
        Cars presentCarTest = new Cars("tesla");
        presentCarTest.PrintPorsche();
        //Welcome page
        // Player one name, player two name
        //Choose car
        //Choose race track
        //Start driving
        //Every two second update the console about the new distance
        //Every two seconds we should implement some print that will print the road & the cars
        //Formula: Speed = Distance / Time

    }
    /*
     Help
        1* Check our showroom
            1.tesla 
            2.ferrari
            3.mercedesamg
            4.porsche
            5.mclaren
        2* Check the tracks
            1.MonacoGrandPrixCircuit
            2.NrburgringNordschleife
            3.SilverstoneCircuit
            4.SuzukiInternationalRacingCourse
            5.MountPanoramaCircuit
     */

    public void DisplayStart()
    {
        Console.WriteLine("Welcome to the Console Car Race!");
        Console.WriteLine("Get ready for an exciting race between two cars.");
        Console.WriteLine("\nInstructions:");
        Console.WriteLine("1. Press 'Enter' to start the race.");
        Console.WriteLine("2. The race will run for a few seconds.");
        Console.WriteLine("3. The car that travels the farthest wins!");
        Console.WriteLine("\nPress 'Enter' to start the race...");
        Console.ReadLine();

    }
   

    public void PlayerOne()
    {
        string carName;
        Console.WriteLine("Enter the name of the car you want to race with: ");
        carName = Console.ReadLine();
        Cars car = new Cars(carName:carName);
    }

    public void PlayerTwo()
    {
        string carName;
        Console.WriteLine("Enter the name of the car you want to race with: ");
        carName = Console.ReadLine();
        Cars car = new Cars(carName: carName);
        //return carName;
    }
    
    
    
    //Should find some way so that i can implement this method here
    /*public void PresentCars(string player)
    {
        Console.WriteLine($"Car name: {char.ToUpper(this.CarName[0]) + this.CarName.Substring(1)} \n - Speed: {this.CarFeatures.Item1}, \n Max Speed: {this.CarFeatures.Item2}, \n Battery: {this.CarFeatures.Item3}");

    } */ 
   
}
namespace RaceThatTrack;

public class Interface
{

    public void ProgramInterface()
    {
        //Welcome page
        // Player one name, player two name
        //Choose car
        //Choose race track
        //Start driving
        //Every two second update the console about the new distance
        
        //Formula: Speed = Distance / Time
        
    }
    public void getCarName()
    {
        Console.WriteLine("Give the name of the car:");
        string carName = Console.ReadLine();
        Cars car = new Cars(carName.ToLower());
        car.PresentCar();
    }
    
   
}
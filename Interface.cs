namespace RaceThatTrack;

public class Interface
{
    

    public void ProgramInterface()
    {
        
        
        //PlayerTwo();
        //Cars presentCarTest = new Cars("tesla");
        //presentCarTest.PrintPorsche();
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
     1.PLay
      Player One name:
       Player Two name:
       
      -The name of the players will be saved at records as a dictionary or cvs file or what ever
      
      -(From here will be player X choose Y:)
       Choose car
            1.tesla 
            2.La Ferrari
            3.MercedesAMG
            4.Porsche
            5.McLaren
            6.Lamborghini
              Choose the track (If the track chosen by the two players ain't the same we will ask them again)
               1.MonacoGrandPrixCircuit
               2.NrburgringNordschleife
               3.SilverstoneCircuit
               4.SuzukiInternationalRacingCourse
               5.MountPanoramaCircuit
                 
                 (console)
                 Start 
                 3
                 2
                 1
                 (show the track and the cars)
              
     2.Records
        1.Best players records(will display the top three players records)
        2.Overall records (All the players records will be displayed here)
        
     3.Help (On proccess)
        1* Check our showroom            (DONE)
            1.tesla 
            2.ferrari
            3.mercedesamg
            4.porsche
            5.mclaren
        2* Check the tracks            (TO BE DONE)
            1.MonacoGrandPrixCircuit
            2.NrburgringNordschleife
            3.SilverstoneCircuit
            4.SuzukiInternationalRacingCourse
            5.MountPanoramaCircuit
        3* Game mechanics
            1.How does the battery disscharge
            2.Track information
            3.Car's information
     */
    
    //Should continue the game by the option choosed
    public void ChoiceOne()
    {
        
    }
    
    public void ChoiceTwo()
    {
        
    }

    public void ChoiceThree(int userChoice)
    {
        Console.WriteLine("Check our show room"); //Here there should be something displayed for 4-5 sec 
        Console.WriteLine("1.Tesla \n            2.La - Ferrari\n            3.MercedesAMG\n            4.Porsche\n            5.McLaren");
        // switch (userChoice)
        // {
        //     case 1:
        //         
        //     
        // }g
        
    }
    
    

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
        //Cars car = new Cars(carName:carName);
        PresentCar(carName);
    }

    public void PlayerTwo()
    {
        string carName;
        Console.WriteLine("Enter the name of the car you want to race with: ");
        carName = Console.ReadLine();
        //Cars car = new Cars(carName);
        PresentCar(carName);
    }
    
    public void PresentCar(string CarName)  //This method correctly displays the attributes of the car given as a parameter by the player
    {
        Cars car = new Cars(CarName);
        Console.WriteLine($"Car name: {char.ToUpper(CarName[0]) + CarName.Substring(1)} \n - Speed: {car.CarFeatures.Item1}, \n Max Speed: {car.CarFeatures.Item2}, \n Battery: {car.CarFeatures.Item3}");
    }
   
}
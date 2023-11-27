namespace RaceThatTrack;

public class Interface
{
    

    public void ProgramInterface()
    {
        bool isGameRunning = true;
        
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

        //Cars car = new Cars();
        //car.PrintMercedes();

        while (isGameRunning == true)
        {
            int userChoice = DisplayStart();
            if (userChoice==1)
            {
                (string firstPlName, string secPlName) = ChoiceOne();
            }else if (userChoice==2)
            {
                ChoiceTwo();
            }
            else if (userChoice==3)
            {
                ChoiceThree();
            }else if (userChoice==0)
            {
                isGameRunning = false;
            }else
            {
                Console.WriteLine("Unknown input(0 for quitting :( )");
                ProgramInterface();
            }
        }
    }
    /*
     1.PLay
      Player One name:
       Player Two name:
       
      -The name of the players will be saved at records as a dictionary or cvs file or what ever(Take care of this one later)
      
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
        
     3.Help (On progress)
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
    public int DisplayStart()
    {
        int userChoice;
        Console.WriteLine("Welcome to the Console Car Race!");
        Console.WriteLine("1. Play");
        Console.WriteLine("2. Records");
        Console.WriteLine("3. Help");
        
        return userChoice = Convert.ToInt32(Console.ReadLine());
    }
    
    //Should continue the game by the option choosed
    public (string, string) ChoiceOne()
    {
        Console.WriteLine("First player enter the name: ");
        string firstPlayerName = Console.ReadLine();
        
        Console.WriteLine("Second player enter the name: ");
        string secondPlayerName = Console.ReadLine();
        
        return (firstPlayerName, secondPlayerName); 
    }
    
    public void ChoiceTwo()
    {
        
    }

    public void ChoiceThree()
    {
        
        
        Console.WriteLine("Check our show room"); //Here there should be something displayed for 4-5 sec 
        Console.WriteLine("1.Check the tracks \n 2.Check the cars \n 3.Check game mechanics\n 0. Quit\n  -1. Back");
        int userChoice = Convert.ToInt32(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                CheckTracks();
                break;
            case 2:
                CheckCars();
                break;
            case 3:
                CheckGameMech();
                break;
            case -1:
                ProgramInterface();
                break;
            case 0:
                ProgramInterface();//Here we should give the value of Program Interface to quit.
                break;
            default:
                Console.WriteLine("Unknown input(0 for quitting, -1 to go back :( )");
                ChoiceThree();
                break;
        }
    }

    public void CheckTracks()
    {
        RaceTrack track = new RaceTrack();
        
        Console.WriteLine("1.MonacoGrandPrixCircuit \n 2.Nrburgring Nordschleife\n 3.SilverstoneCircuit\n 4.Suzuki International Racing Course\n 5.MountPanoramaCircuit");
        int userChoice = Convert.ToInt32(Console.ReadLine());

        /*switch (userChoice)
        {
            case 1:
                PrintTesla();
                break;
            case 2:
                car.PrintLaFerrari();
                break;
            case 3:
                car.PrintMercedes();
                break;
            case 4:
                car.PrintPorsche();
                break;
            case 5:
                car.PrintNissanGtR();
                break;
            case -1:
                ProgramInterface();
                break;
            case 0:
                ProgramInterface();//Here we should give the value of Program Interface to quit.
                break;
            default:
                Console.WriteLine("Unknown input(0 for quitting, -1 to go back :( )");
                ChoiceThree();
                break;
        }*/
        
    }

    public void CheckCars()
    {
        Cars car = new Cars();
        Console.WriteLine("1.Tesla \n            2.La - Ferrari\n            3.MercedesAMG\n            4.Porsche\n            5.McLaren");
        //int userChoice = Convert.ToInt32(Console.ReadLine());
        car.PrintMercedes();
        // switch (userChoice)
        // {
        //     case 1:
        //         Console.Clear();
        //         car.PrintTesla();
        //         Thread.Sleep(12000);
        //
        //         break;
        //     case 2:
        //         Console.Clear();
        //         car.PrintLaFerrari();
        //         break;
        //     case 3:
        //         Console.Clear();
        //         car.PrintMercedes();
        //         Thread.Sleep(12000);
        //         break;
        //     case 4:
        //         car.PrintPorsche();
        //         break;
        //     case 5:
        //         car.PrintNissanGtR();
        //         break;
        //     case -1:
        //         ProgramInterface();
        //         break;
        //     case 0:
        //         ProgramInterface();//Here we should give the value of Program Interface to quit.
        //         break;
        //     default:
        //         Console.WriteLine("Unknown input(0 for quitting, -1 to go back :( )");
        //         ChoiceThree();
        //         break;
        // }
    }

    public void CheckGameMech()
    {
        
    }
    

    /*public void DisplayStart()
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
    */
   

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
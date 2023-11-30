using System.Reflection.Metadata.Ecma335;

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
                string carFirstPlayer = PlayerOneCar( firstPlName);
                string secPlCar = PlayerTwoCar(secPlName);

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
        string firstPlayerName = Convert.ToString(Console.ReadLine());
        
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
   

    public string PlayerOneCar(string firstPlayerName)
    {
        string carName, userDecision;;
        bool showCar = false;
        
        
        Console.WriteLine($"{firstPlayerName}enter the name of the car you want to race with: ");
        carName = Console.ReadLine();
        PresentCar(carName);
        Records(firstPlayerName, carName);
        Console.WriteLine("Do you want to see your car: (y/n)");
        userDecision = Console.ReadLine();
        if (userDecision.ToLower()=="y")
        {
            Console.Clear();
            Thread.Sleep(300);
            CheckCarDecision(carName);
            Thread.Sleep(1500);
        }
        return carName;
    }

    public string PlayerTwoCar(string secPlayerName)
    {
        string carName, userDecision;
        bool showCar = false;
        
        Console.WriteLine($"{secPlayerName} enter the name of the car you want to race with: ");
        carName = Console.ReadLine();
        PresentCar(carName);
        Records(secPlayerName, carName);
        Console.WriteLine("Do you want to see your car: (y/n)");
        userDecision = Console.ReadLine();
        if (userDecision.ToLower()=="y")
        {
            Console.Clear();
            Thread.Sleep(300);
            CheckCarDecision(carName);
            Thread.Sleep(300);
        }
        return carName;
    }
    
    public void PresentCar(string carName)  //This method correctly displays the attributes of the car given as a parameter by the player
    {
        Cars car = new Cars(carName);
        Console.WriteLine($"Car name: {char.ToUpper(carName[0]) + carName.Substring(1)} \n - Speed: {car.CarFeatures.Item1}, \n Max Speed: {car.CarFeatures.Item2}, \n Battery: {car.CarFeatures.Item3}");
    }

    public void CheckCarDecision(string carName)
    {
        Cars car = new Cars();
        
        if (carName =="tesla")
        {
            car.PrintTesla();
        }else if (carName == "ferrari")
        {
            car.PrintLaFerrari();
        }else if (carName == "mercedesamg")
        {
            car.PrintMercedes();
        }else if (carName == "porsche")
        {
            car.PrintPorsche();
        }else if (carName == "lamborghini")
        {
            Console.WriteLine("Haven't been created yet");
            //car.PrintLa();
        }else if (carName=="mcclaren")
        {
            Console.WriteLine("Haven't been created yet");
        }else if (carName=="nissangtr")
        {
            car.PrintNissanGtR();
        }
        else
        {
            Console.WriteLine("We don't seem to have this car");
        }
    }

    public void Records(string playerName, string carName)
    {
        string directoryPath = @"C:\Users\User\RiderProjects\RaceThatTrack\Records\";

        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        using (StreamWriter writer = new StreamWriter(Path.Combine(directoryPath, "data.csv"), true))
        {
            if (new FileInfo(Path.Combine(directoryPath, "data.csv")).Length == 0)
            {
                writer.WriteLine("PlayerName,CarName");
            }

            writer.WriteLine($"{playerName},{carName}");

            Console.WriteLine("Data saved to CSV file in the specified directory.");
        }
    }
    
   
}
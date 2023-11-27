
namespace RaceThatTrack;

public class RemoteControlCar
{
    //After the users choose the cars a constructer here will attach values to each of the cars
    
    
    //A method that will check if the car may have crashed
    public bool CrashOrNot(int carSpeed, double terrainCrashingChances)
    {
        //Here if the speed is lower than 140 the crashing chances will be 5% and for every 20 km/h added the chances will add 
        //The terrain got it's own crashing chances which we will add to the total
        bool crashOrNot;
        int randomNumber;
        //float totalRisk = (float)(carSpeed + terrainCrashingChances);
        double baseRisk = 0.05; // Base risk for speeds up to 140 km/h  = 5%
        const double speedIncreaseThreshold = 20; // Increase risk for every 20 km/h above the threshold
        const double riskIncreasePercentage = 0.05; // 5% increase for every 20 km/h above the threshold

        if (carSpeed <= 140)
        {
            baseRisk = 0.05 + terrainCrashingChances; //0.05 are the base crashing chances
        }
        else
        {
            // Calculate the additional risk based on the speed increase
            double additionalRisk = Math.Floor((carSpeed - 140) / speedIncreaseThreshold) * riskIncreasePercentage; //This formula will increase the chances by 5% every 20km/h added, speedometer

            // Add the additional risk to the base risk
            baseRisk = 0.05 + additionalRisk + terrainCrashingChances;
        }
        
        //Here we call the function that will generate the random probability
        randomNumber = RandomChances();
        crashOrNot = CheckSurvivalChances(randomNumber, baseRisk);
        return crashOrNot;

    }
    //Check if the rider crashes or not
    public bool CheckSurvivalChances(int randomNumber, double baseRisk)
    {
        bool survived = true;
        if (baseRisk<=randomNumber)
        {
            survived = true;
        }
        else if (baseRisk >= randomNumber)
        {
            survived = false;
        }

        return survived;

    }
    
    //This function will generate us a number from 1- 100
    public int RandomChances()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101);
        return randomNumber;
    }
    
    //This method check which of the cars is winning the race
    public string CheckFirstPlace(int playerOneCarDistance, int playerTwoCarDistance)
    {
        if (playerOneCarDistance>playerTwoCarDistance)
        {
            return "first player is winning";

        }else if (playerTwoCarDistance>playerOneCarDistance)
        {
            return "sec player is winning";
        }else if (playerOneCarDistance==playerTwoCarDistance)
        {
            return "Quite of the race going on here, EQUAL";
        }
        else
        {
            return "Some error, uppsie";
        }
        
    }
    
    //This method checks if the car's can finish the race
    public bool CanFinishTrack(int battery, bool crashed)
    {
        //We should check if the battery 5 or lower than that to return false or if the car has been crashed
        if (battery<=5 || crashed)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    
    
    //RECHECK We should create a formula that will provide us for let's say 5 sec of race the rate of discharge should be 1 (coeficent)
    // so the rate of discharge will be 0.2 percent per second.  Formula: rateOfDischarge = Coeficent / perFiveSeconds
    public double UpdateAndCheckBatteryLevel(double batteryPercentage, double coeficent, bool speedRisen)//The coeficent will be 1 by default & will change depending on 
    {
        double addedValueToCoefficent; //This value will increase with the rise of speed
        double ceofficent = 1; // I think this will be the default coefficent & it will increase if the players want to increase the speed (meaby 0.2 with 10 km/h added in speedometer)
        double perFiveSec = 5;
        double rateOfDischarge;
        if (speedRisen == true)
        {
            addedValueToCoefficent = SpeedRisen();
            rateOfDischarge = (ceofficent+addedValueToCoefficent) / perFiveSec;
            batteryPercentage -= rateOfDischarge; //Battery percentage will be the total value of the car's battery 
            
        }
        else
        {
            rateOfDischarge = ceofficent / perFiveSec;
            batteryPercentage -= rateOfDischarge; //Battery percentage will be the total value of the car's battery 
            
        }
        return batteryPercentage;
    }

    public double SpeedRisen()
    {
        double coeficent = 0.2;
        coeficent += coeficent;
        return coeficent;
    }
}
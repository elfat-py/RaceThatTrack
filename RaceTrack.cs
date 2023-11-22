namespace RaceThatTrack;

public class RaceTrack
{
    private static readonly Dictionary<string, (int, int)> RaceTrackCharacteristics = new Dictionary<string, (int, int)>
    {   //The key is the name of the lab, first value is the length of the lab in meters, the second value is the chances of getting crashed.
        {"MonacoGrandPrixCircuit",(600, 39)},
        {"NrburgringNordschleife",(1200,32)},
        {"SilverstoneCircuit",(1600, 6)},
        {"SuzukiInternationalRacingCourse",(900, 32)},
        {"MountPanoramaCircuit", (700, 65)}
    };
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public RaceTrack()
    {
        
    }
    //We should be able to provide at least 5 different tracks and their characteristics here
    //public static int 
    public static void MonacoGrandPrixCircuit()
    {
        /*
        Location: Monte Carlo, Monaco
        Characteristics: Narrow and winding street circuit with tight corners,
        elevation changes, and minimal overtaking opportunities. Known for its glamorous setting and challenging driving conditions.
         */
        //Also consider that each car can have a chance of crashing at each one of these tracks , changes by the terrain and by car
        int distancePerLap = 400;
    }
    public static void NrburgringNordschleife()
    {
        //A fast track with more straight lines
        /*
        Location: Nürburg, Germany
        Characteristics: Often referred to as "The Green Hell,"
        it's a long and challenging track with a mix of fast straights,
        tight corners, and significant elevation changes. It's a favorite for testing and known for its demanding nature.
         */
        int distancePerLap = 400;
    }
    public static void SilverstoneCircuit()
    {
        //A completely straight mostly track
        /*
        Location: Silverstone, United Kingdom
        Characteristics: A fast and flowing track with 
        a mix of high-speed corners and straights. 
        It's the home of British motorsport and hosts the British Grand Prix.
         */
        int distancePerLap = 400;
    }
    public static void SuzukaInternationalRacingCourse()
    {
        /*
        Location: Suzuka, Japan
        Characteristics: A figure-eight 
        track with a unique layout featuring the challenging 130R corner and the iconic crossover bridge. 
        It demands a balance of power and technical skill.
         */
        int distancePerLap = 400;
    }
    public static void MountPanoramaCircuit()
    {
        //Also consider that each car can have a chance of crashing at each one of these tracks , changes by the terrain and by car
        /*
        Location: Bathurst, Australia
        Characteristics: A challenging street circuit that winds its way up 
        and down the side of Mount Panorama. It features the iconic "The Dipper" and the long Conrod Straight
         */
        int distancePerLap = 400;
    }
    
}
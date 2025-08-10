using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Note
        // I made a base Activity class and three derived classes.
        // Units: miles and mph. Numbers rounded to 1 decimal in output.
        

        var activities = new List<Activity>()
        {
            // Running(date, minutes, distanceMiles)
            new Running("03 Nov 2022", 30, 3.0),   // 3 miles in 30 min

            // Cycling(date, minutes, speedMph)
            new Cycling("04 Nov 2022", 45, 15.0),  // 15 mph for 45 min

            // Swimming(date, minutes, laps)
            new Swimming("05 Nov 2022", 40, 20)    // 20 laps (50m each) in 40 min
        };

        Console.WriteLine("Activity summaries:\n");
        foreach (var a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running Running1 = new Running("03 Nov 2022", 60, 3.0);
        StationaryBicycle StationaryBicycle1 = new StationaryBicycle("04 Nov 2022", 45, 10.0);
        Swimming Swimming1 = new Swimming("05 Nov 2022",120, 20);

        activities.Add(Running1);
        activities.Add(StationaryBicycle1);
        activities.Add(Swimming1);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
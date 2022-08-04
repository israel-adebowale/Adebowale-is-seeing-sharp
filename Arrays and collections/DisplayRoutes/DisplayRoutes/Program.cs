using DisplayRoutes;

var repository = new BusRouteRepository();

BusTimes time5 = repository.BusTimesRoute5;
BusRoutes route5 = time5.Route;

for (int iPlace = 0; iPlace < route5.PlacesServed.Length; iPlace++)
{
    Console.Write(route5.PlacesServed[iPlace].PadRight(12));

    for (int iJourney = 0; iJourney < time5.Times[iPlace].Length; iJourney++)
    {
        Console.Write(time5.Times[iPlace] [iJourney] + " ");
    }
    Console.WriteLine();
} 

//foreach (BusRoutes route in allRoutes.Values)
//{
//    Console.WriteLine(route);
//}
//Console.WriteLine("Which route do you want to look up?");

//#pragma warning disable CS8604 // Possible null reference argument.
//int number = int.Parse(Console.ReadLine());
//#pragma warning restore CS8604 // Possible null reference argument.

//bool success = allRoutes.TryGetValue(number, out BusRoutes answer);

// bool success = allRoutes.ContainsKey(number);
//if (success)
//    Console.WriteLine($"The route you asked for is {answer}");
//else
//    Console.WriteLine($"There is no route with number {number}");
//Console.WriteLine($"Before: There are {allRoutes.Count} routes");
//foreach (BusRoutes route in allRoutes)
//    Console.WriteLine($"Route: {route}");

//allRoutes.RemoveAll(route => route.Origin.StartsWith("Test"));
//Console.WriteLine($"\r\nAfter: There are {allRoutes.Count} routes"); 

//foreach (BusRoutes route in allRoutes)
//    Console.WriteLine($"Route: {route}");

//Console.WriteLine("where are you?");
//#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
//string startingAt = Console.ReadLine();
//#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.


//Console.WriteLine("where do you want to go?");
//#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
//string goingTo = Console.ReadLine();
//#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

//var originRoutes = repository.FindBusesTo(startingAt);
//var destinationRoutes = repository.FindBusesTo(goingTo);

//HashSet<BusRoutes> routes = new HashSet<BusRoutes>(originRoutes);
//routes.IntersectWith(destinationRoutes);

//if (routes.Count > 0)
//    foreach (var route in routes)
//        Console.WriteLine($"you can use route {route}");
//else
//    Console.WriteLine($"no routes between {startingAt} and {goingTo}");




Console.ReadLine();


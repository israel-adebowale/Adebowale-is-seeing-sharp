using JourneyApp;

public class BusStop
{
    private Queue<Passenger> _peopleWaiting = new Queue<Passenger>();
    public void PersonArrive(Passenger passenger)
    {
        _peopleWaiting.Enqueue(passenger);
        Console.WriteLine($"{passenger} queuimg at the bus stop");
    }
    public void BusArrive(Bus bus)
    {
        Console.WriteLine("\r\nBus arriving at the bus stop to load passengers");
        while (bus.Space > 0 && _peopleWaiting.Count > 0)
        {
            Passenger passenger = _peopleWaiting.Dequeue();
            bus.Load(passenger);
        }
    }
}
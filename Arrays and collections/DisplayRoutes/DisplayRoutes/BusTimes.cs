namespace DisplayRoutes
{
    public class BusTimes
    {
        public BusTimes(BusRoutes route, string[][] times)
        {
            Route = route;
            Times = times;
        }
        public string[][] Times { get; }
        public BusRoutes Route { get; }

    }
}

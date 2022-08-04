namespace DisplayRoutes
{
    public class BusRouteRepository
    {
        //public static Dictionary<int, BusRoutes> InitializeRoutes()
        //{
        //    BusRoutes route40 = new BusRoutes(40, new string[] { "Morecambe", "Lancaster", "Garstang", "Preston" });
        //    BusRoutes route42 = new BusRoutes(42, new string[] { "Lancaster", "Garstang", "Blackpool" });
        //    BusRoutes route100 = new BusRoutes(100, new string[] { "University", "Lancaster", "Morecambe" });
        //    BusRoutes route555 = new BusRoutes(555, new string[] { "Lancaster", "Carnforth", "Kendal", "Windermere", "Keswick" });
        //    BusRoutes route5 = new BusRoutes(5, new string[] { "Overton", "Morecambe", "Carnforth" });

        //    var routes = new Dictionary<int, BusRoutes>
        //    {
        //        { 40, route40 },
        //        { 42, route42 },
        //        { 100, route100 },
        //        { 555, route555 },
        //        { 5, route5 }
        //    };
        //    return routes;
        //}
        private readonly BusRoutes[] _allRoutes;
        public BusRouteRepository()
        {
            _allRoutes= new BusRoutes[]
            {
                new BusRoutes(40, new string[] { "Morecambe", "Lancaster", "Garstang", "Preston" }),
                new BusRoutes(42, new string[] { "Lancaster", "Garstang", "Blackpool" }),
                new BusRoutes(100, new string[] { "University", "Lancaster", "Morecambe" }),
                new BusRoutes(555, new string[] { "Lancaster", "Carnforth", "Kendal", "Windermere", "Keswick" }),
                new BusRoutes(5, new string[] { "Overton", "Morecambe", "Carnforth" })
            };

            //string[,] timeRoute5 =
            //{
            //    { "15:30", "16:40", "17:40", "18:40" },
            //    { "16:08", "17:08", "18:08", "19:08" },
            //    { "16:35", "17:35", "18:35", "19:35" }
            //};

            string[][] timeRoute5 =
            {
               new string[] { "15:30", "16:40", "17:40", "18:40", "19:40" },
               new string[] { "16:08", "17:08", "18:08", "19:08", "20:08" },
               new string[] { "16:35", "17:35", "18:35", "19:35" }
            };
            BusTimesRoute5 = new BusTimes(Array.Find(_allRoutes, x => x.Number == 5), timeRoute5);

        }
        public BusTimes BusTimesRoute5 { get; }
        public BusRoutes[] FindBusesTo(string location)
        {
            return Array.FindAll(_allRoutes, route => route.Serves(location));
            //foreach (var route in routes)
            //{
            //    if (route.origin == location || route.destination == location)
            //        return route;
            //}
            //return null;
        }
        public BusRoutes[] FindBusesBetween(string location1, string location2)
        {
            return Array.FindAll(_allRoutes, routes => routes.Serves(location1) && routes.Serves(location2));
        }
    }
}

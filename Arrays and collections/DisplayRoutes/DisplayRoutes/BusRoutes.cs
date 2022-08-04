namespace DisplayRoutes
{
    public class BusRoutes
    {
        public int Number { get; }
        public string Origin => PlacesServed[0];
        public string Destination => PlacesServed[^1];
        public string[] PlacesServed { get; }
        public BusRoutes(int number, string[] placesServed)
        {
            Number = number;
            PlacesServed = placesServed;
        }
        public override string ToString() => $"{Number}: {Origin} -> {Destination}";
        
        public bool Serves(string destination)
        {
            return Array.Exists(PlacesServed, place => place == destination);
            //foreach (string place in PlacesServed)
            //{
            //    if (place == destination)
            //    return true;              
            //}
            //return false;
        }
    }
}

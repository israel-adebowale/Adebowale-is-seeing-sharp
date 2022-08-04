﻿using JourneyApp;

public class PassengerGenerator
{
    private static int _count = 0;
    private static Random _rnd = new();
    public static Passenger CreatePassenger()
    {
        string destination = _rnd.Next(2) == 0 ? "Lancaster" : "Morecambe";
        return new Passenger($"Person {++_count}", destination);
    }
}
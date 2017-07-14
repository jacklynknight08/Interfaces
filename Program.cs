using System;
using System.Linq;
using System.Collections.Generic;


public interface IVehicle
{
    int Wheels { get; set; }
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }
    void Start();
    void Stop();

}

public interface IWaterbased
{
    double MaxWaterSpeed { get; set; }
    void Drive();
}

public interface IGroundbased
{
    double MaxLandSpeed { get; set; }
    void Drive();
}

public interface IAirbased
{
    double MaxAirSpeed { get; set; }
    bool Winged { get; set; }
    void Fly();
}
public class JetSki : IVehicle, IWaterbased
{
    public int Wheels { get; set; }
    public int Doors { get; set; }
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }

    public void Drive()
    {
        Console.WriteLine("");
        Console.WriteLine("The jetski zips through the waves with the greatest of ease");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Pontoon : IVehicle, IWaterbased
{
    public int Wheels { get; set; }
    public int Doors { get; set; }
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }

    public void Drive()
    {
        Console.WriteLine("The pontoon cruises through the water.");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Motorcycle : IVehicle, IGroundbased
{
    public int Wheels { get; set; } = 2;
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 1.3;
    public double MaxLandSpeed { get; set; } = 160.4;

    public void Drive()
    {
        Console.WriteLine("");
        Console.WriteLine("The motorcycle screams down the highway");
    }
    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Truck : IVehicle, IGroundbased
{
    public int Wheels { get; set; } = 4;
    public int Doors { get; set; } = 4;
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 1.3;
    public double MaxLandSpeed { get; set; } = 160.4;

    public void Drive()
    {
        Console.WriteLine("The truck drives down the road.");
    }
    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

    public class Cessna : IVehicle, IAirbased
    {
    public int Wheels { get; set; } = 3;
    public int Doors { get; set; } = 3;
    public int PassengerCapacity { get; set; } = 113;
    public bool Winged { get; set; } = true;
    public string TransmissionType { get; set; } = "None";
    public double EngineVolume { get; set; } = 31.1;
    public double MaxAirSpeed { get; set; } = 309.0;

    public void Drive()
    {
        throw new NotImplementedException();
    }

    public void Fly()
    {
        Console.WriteLine("");
        Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
    }

public class Jet : IVehicle, IAirbased
    {
    public int Wheels { get; set; } = 3;
    public int Doors { get; set; } = 2;
    public int PassengerCapacity { get; set; } = 2;
    public bool Winged { get; set; } = true;
    public string TransmissionType { get; set; } = "None";
    public double EngineVolume { get; set; } = 31.1;
    public double MaxAirSpeed { get; set; } = 410.0;

    public void Drive()
    {
        throw new NotImplementedException();
    }

    public void Fly()
    {
        Console.WriteLine("The Jet speeds through the sky.");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
    }


    public class Program
    {

        public static void Main() {

            // Build a collection of all vehicles that fly
            
            Cessna plane = new Cessna();
            Jet plane2 = new Jet();

            List<IAirbased> airList = new List<IAirbased>();

            airList.Add(plane);
            airList.Add(plane2);

            // With a single `foreach`, have each vehicle Fly()

            foreach(var item in airList)
            {
                item.Fly();
            }

            // Build a collection of all vehicles that operate on roads

            Motorcycle bike = new Motorcycle();
            Truck truck = new Truck();

            List<IGroundbased> groundList = new List<IGroundbased>();

            groundList.Add(bike);
            groundList.Add(truck);

            // With a single `foreach`, have each road vehicle Drive()

            foreach(var item in groundList)
            {
                item.Drive();
            }

            // Build a collection of all vehicles that operate on water
            
            JetSki ski = new JetSki();
            Pontoon boat = new Pontoon();

            List<IWaterbased> waterList = new List<IWaterbased>();

            waterList.Add(ski);
            waterList.Add(boat);

            // With a single `foreach`, have each water vehicle Drive()

            foreach(var item in waterList)
            {
                item.Drive();
            }
        }

}
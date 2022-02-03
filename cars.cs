public class Zero: Vehicle  // Electric motorcycle
{
    public double BatteryKWh { get; set; }
   

    public void ChargeBattery()
    {
        // method definition omitted
    }

     public override void Drive()
    {
        Console.WriteLine("Woooooooooooooooooo!");
    }
}


public class Cessna: Vehicle  // Propellor light aircraft
{
    public double FuelCapacity { get; set; }
   

    public void RefuelTank()
    {
        // method definition omitted
    }

     public override void Drive()
    {
        Console.WriteLine("Zoooooom!");
    }
}

public class Tesla: Vehicle  // Electric car
{
    public double BatteryKWh { get; set; }


    public void ChargeBattery()
    {
        // method definition omitted
    }

     public override void Drive()
    {
        Console.WriteLine("Plug it in!");
    }
}

public class Ram: Vehicle  // Gas powered truck
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        // method definition omitted
    }

     public override void Drive()
    {
        Console.WriteLine("Ram Slam!");
    }
         public override void Turn(string direction)
    {
        Console.WriteLine("Ram makes a slam bam right turn!");
    }
         public override void Stop()
    {
        Console.WriteLine("Rolled to a stop!");
    }
}

public class Vehicle
{
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

     virtual public void Drive()
    {
        Console.WriteLine("Vrooom!");
    }

    virtual public void Turn(string direction)
    {
        Console.WriteLine("Turn to the right");
    }

     virtual public void Stop()
    {
        Console.WriteLine("Stop!");
    }
}
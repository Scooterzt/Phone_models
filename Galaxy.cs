using System;
public class Galaxy : Phone, IRingable 
{
    public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
        : base(versionNumber, batteryPercentage, carrier, ringTone) {}
    public string Ring() 
    {
        return _ringTone;
    }
                
    public string Unlock() 
    {
        string unlock =  "Galaxy was unock with pin Code";
        return unlock;
    }
    public override void DisplayInfo() 
    {
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine($"Galaxy {_versionNumber}");
        Console.WriteLine($"Carrier: {_carrier}");
        Console.WriteLine($"battery procentage: {_batteryPercentage}");
        Console.WriteLine($"Ring Phone: {_ringTone}");
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$");
    }
}
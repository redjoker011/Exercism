using System;

class RemoteControlCar
{
    private readonly int meterPerRun = 20;
    private int battery { get;set; }
    private int odoMeter { get;set; }

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public RemoteControlCar() {
        battery = 100;
        odoMeter = 0;
    }

    public string DistanceDisplay()
    {
        return $"Driven {odoMeter} meters";
    }

    public string BatteryDisplay()
    {
        string message = String.Empty;
            if(canDrive())
            {
                message = $"Battery at {battery}%";
            }
            else
            {
                message = "Battery empty";
            }
            return message;
    }

    public void Drive()
    {
        if(canDrive()) {
            odoMeter += 20;
            --battery;
        }
    }

    private bool canDrive()
    {
        return battery > 0;
    }
}

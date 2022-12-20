using System;

class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    //
    private int speed { get; init; }
    private int batteryDrained { get; init; }
    private int battery { get; set; }

    private int distanceDriven { get; set; }

    public RemoteControlCar(int Speed, int BatteryDrained)
    {
        speed = Speed;
        batteryDrained = BatteryDrained;
        battery = 100;
    }

    public bool BatteryDrained()
    {
        return battery <= 0 || batteryDrained > battery;
    }

    public int DistanceDriven()
    {
        return distanceDriven;
    }

    public void Drive()
    {
        if (BatteryDrained() == false) {
            battery = battery - batteryDrained;
            distanceDriven += speed;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new(50, 4);
    }

    public int Battery()
    {
        return battery;
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class

    private int distance { get; init; }

    public RaceTrack(int Distance)
    {
        distance = Distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        do
        {
            car.Drive();
        }
        while(car.BatteryDrained() == false);

        return car.DistanceDriven() >= distance;
    }
}

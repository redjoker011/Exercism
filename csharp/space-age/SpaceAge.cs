using System;

public class SpaceAge
{
    private double _earthYearInSeconds = 31557600;
    private double _spaceAgeInSeconds { get; init; }

    public SpaceAge(int seconds)
    {
        _spaceAgeInSeconds = seconds;
    }

    public double OnEarth()
    {
        return _spaceAgeInSeconds / earthDayInSeconds("earth");
    }

    public double OnMercury()
    {
        return (_spaceAgeInSeconds / earthDayInSeconds("mercury")) / 100;
    }

    public double OnVenus()
    {
        return (_spaceAgeInSeconds / earthDayInSeconds("venus")) / 100;
    }

    public double OnMars()
    {
        return (_spaceAgeInSeconds / earthDayInSeconds("mars")) / 100;
    }

    public double OnJupiter()
    {
        return (_spaceAgeInSeconds / earthDayInSeconds("jupiter")) / 100;
    }

    public double OnSaturn()
    {
        return (_spaceAgeInSeconds / earthDayInSeconds("saturn")) / 100;
    }

    public double OnUranus()
    {
        return (_spaceAgeInSeconds / earthDayInSeconds("uranus")) / 100;
    }

    public double OnNeptune()
    {
        return (_spaceAgeInSeconds / earthDayInSeconds("neptune")) / 100;
    }

    private double earthDayInSeconds(string planet)
    {
        int divisor = 100;
        switch (planet)
        {
            case "mercury":
                return (0.2408467 / divisor) * _earthYearInSeconds;
            case "venus":
                return (0.61519726 / divisor) * _earthYearInSeconds;
            case "mars":
                return (1.8808158 / divisor) * _earthYearInSeconds;
            case "jupiter":
                return (11.862615 / divisor) * _earthYearInSeconds;
            case "saturn":
                return (29.447498 / divisor) * _earthYearInSeconds;
            case "uranus":
                return (84.016846 / divisor) * _earthYearInSeconds;
            case "neptune":
                return (164.79132 / divisor) * _earthYearInSeconds;
            default:
                return _earthYearInSeconds;
        }
    }
}

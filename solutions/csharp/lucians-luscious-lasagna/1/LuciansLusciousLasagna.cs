class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public static int TimeOven=40;
    public int ExpectedMinutesInOven() 
    {
        return TimeOven;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
public int RemainingMinutesInOven(int Time)
{
    return this.ExpectedMinutesInOven()-Time;
}
    // TODO: define the 'PreparationTimeInMinutes()' method
public int PreparationTimeInMinutes(int Layers)
{
    return Layers*2;
}
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int Layers,int Time)
    {
        return Layers*2+Time;
    }
}

public class Thermostat
{
    public event TemperatureChangedEventHandler TemperatureChanged;

    private double currentTemperature;

    public double CurrentTemperature
    {
        get { return currentTemperature; }
        set
        {
            currentTemperature = value;
            TemperatureChanged?.Invoke(currentTemperature);
        }
    }
}

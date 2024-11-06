using System;
using System.Collections.Generic;
using System.Linq;

public class Sensor
{
    private List<double> measurements = new List<double>();

    public event Action<double> MeasurementUpdated;

    public void AddMeasurement(double value)
    {
        measurements.Add(value);
        double average = measurements.Average();
        MeasurementUpdated?.Invoke(average);
    }
}

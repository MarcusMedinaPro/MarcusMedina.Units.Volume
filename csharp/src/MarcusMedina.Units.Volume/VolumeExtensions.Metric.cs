namespace MarcusMedina.Units.Volume.Metric;

/// <summary>
/// Metriska volymenheter — SI-standard med milliliter som basenhet.
/// <code>
/// 1.Liters().ToMilliliters()       // 1000
/// 1.CubicMeter().ToLiters()        // 1000
/// 2.5.Deciliters().ToMilliliters() // 250
/// </code>
/// </summary>
public static class MetricVolumeExtensions
{
    extension(int v)
    {
        public Volume Nanoliters() => new(v * 0.000001);
        public Volume Microliters() => new(v * 0.001);
        public Volume Milliliters() => new(v);
        public Volume CubicMillimeters() => new(v * 0.001);
        public Volume CubicCentimeters() => new(v);
        public Volume Centiliters() => new(v * 10.0);
        public Volume Deciliters() => new(v * 100.0);
        public Volume Liters() => new(v * 1_000.0);
        public Volume Decaliters() => new(v * 10_000.0);
        public Volume Hectoliters() => new(v * 100_000.0);
        public Volume Kiloliters() => new(v * 1_000_000.0);
        public Volume CubicMeters() => new(v * 1_000_000.0);
    }

    extension(double v)
    {
        public Volume Nanoliters() => new(v * 0.000001);
        public Volume Microliters() => new(v * 0.001);
        public Volume Milliliters() => new(v);
        public Volume CubicMillimeters() => new(v * 0.001);
        public Volume CubicCentimeters() => new(v);
        public Volume Centiliters() => new(v * 10.0);
        public Volume Deciliters() => new(v * 100.0);
        public Volume Liters() => new(v * 1_000.0);
        public Volume Decaliters() => new(v * 10_000.0);
        public Volume Hectoliters() => new(v * 100_000.0);
        public Volume Kiloliters() => new(v * 1_000_000.0);
        public Volume CubicMeters() => new(v * 1_000_000.0);
    }

    extension(Volume v)
    {
        public double ToNanoliters() => v.Milliliters / 0.000001;
        public double ToMicroliters() => v.Milliliters / 0.001;
        public double ToMilliliters() => v.Milliliters;
        public double ToCubicMillimeters() => v.Milliliters / 0.001;
        public double ToCubicCentimeters() => v.Milliliters;
        public double ToCentiliters() => v.Milliliters / 10.0;
        public double ToDeciliters() => v.Milliliters / 100.0;
        public double ToLiters() => v.Milliliters / 1_000.0;
        public double ToDecaliters() => v.Milliliters / 10_000.0;
        public double ToHectoliters() => v.Milliliters / 100_000.0;
        public double ToKiloliters() => v.Milliliters / 1_000_000.0;
        public double ToCubicMeters() => v.Milliliters / 1_000_000.0;
    }
}

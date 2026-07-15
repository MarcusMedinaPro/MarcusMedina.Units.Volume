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
    public static Volume Nanoliters(this int v) => new(v * 0.000001);
    public static Volume Nanoliters(this double v) => new(v * 0.000001);
    public static Volume Microliters(this int v) => new(v * 0.001);
    public static Volume Microliters(this double v) => new(v * 0.001);
    public static Volume Milliliters(this int v) => new(v);
    public static Volume Milliliters(this double v) => new(v);
    public static Volume CubicMillimeters(this int v) => new(v * 0.001);
    public static Volume CubicMillimeters(this double v) => new(v * 0.001);
    public static Volume CubicCentimeters(this int v) => new(v);
    public static Volume CubicCentimeters(this double v) => new(v);
    public static Volume Centiliters(this int v) => new(v * 10.0);
    public static Volume Centiliters(this double v) => new(v * 10.0);
    public static Volume Deciliters(this int v) => new(v * 100.0);
    public static Volume Deciliters(this double v) => new(v * 100.0);
    public static Volume Liters(this int v) => new(v * 1_000.0);
    public static Volume Liters(this double v) => new(v * 1_000.0);
    public static Volume Decaliters(this int v) => new(v * 10_000.0);
    public static Volume Decaliters(this double v) => new(v * 10_000.0);
    public static Volume Hectoliters(this int v) => new(v * 100_000.0);
    public static Volume Hectoliters(this double v) => new(v * 100_000.0);
    public static Volume Kiloliters(this int v) => new(v * 1_000_000.0);
    public static Volume Kiloliters(this double v) => new(v * 1_000_000.0);
    public static Volume CubicMeters(this int v) => new(v * 1_000_000.0);
    public static Volume CubicMeters(this double v) => new(v * 1_000_000.0);

    public static double ToNanoliters(this Volume v) => v.Milliliters / 0.000001;
    public static double ToMicroliters(this Volume v) => v.Milliliters / 0.001;
    public static double ToMilliliters(this Volume v) => v.Milliliters;
    public static double ToCubicMillimeters(this Volume v) => v.Milliliters / 0.001;
    public static double ToCubicCentimeters(this Volume v) => v.Milliliters;
    public static double ToCentiliters(this Volume v) => v.Milliliters / 10.0;
    public static double ToDeciliters(this Volume v) => v.Milliliters / 100.0;
    public static double ToLiters(this Volume v) => v.Milliliters / 1_000.0;
    public static double ToDecaliters(this Volume v) => v.Milliliters / 10_000.0;
    public static double ToHectoliters(this Volume v) => v.Milliliters / 100_000.0;
    public static double ToKiloliters(this Volume v) => v.Milliliters / 1_000_000.0;
    public static double ToCubicMeters(this Volume v) => v.Milliliters / 1_000_000.0;
}

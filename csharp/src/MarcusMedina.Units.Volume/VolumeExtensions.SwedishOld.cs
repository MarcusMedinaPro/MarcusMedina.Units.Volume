namespace MarcusMedina.Units.Volume.SwedishOld;

/// <summary>
/// Historiska svenska volymenheter — före metersystemets införande (1889).
/// Kanna (2.6177 L) var huvudenheten.
/// <code>
/// 1.Kanna().ToLiters()     // ≈ 2.618
/// 1.Tunna().ToKannor()     // 48
/// </code>
/// </summary>
public static class SwedishOldVolumeExtensions
{
    /// <summary>1 jungfru = 1/4 stop = 81.93 mL</summary>
    public static Volume Jungfru(this int v) => new(v * 81.93);
    public static Volume Jungfru(this double v) => new(v * 81.93);

    /// <summary>1 stop = 1/8 kanna = 327.72 mL</summary>
    public static Volume Stop(this int v) => new(v * 327.72);
    public static Volume Stop(this double v) => new(v * 327.72);

    /// <summary>1 kanna = 2 617.7 mL (= 2.6177 liter, huvudenheten)</summary>
    public static Volume Kanna(this int v) => new(v * 2_617.7);
    public static Volume Kanna(this double v) => new(v * 2_617.7);

    /// <summary>1 ankare = 15 kannor = 39 265.5 mL (ölankare)</summary>
    public static Volume Ankare(this int v) => new(v * 39_265.5);
    public static Volume Ankare(this double v) => new(v * 39_265.5);

    /// <summary>1 tunna = 48 kannor = 125 649.6 mL (torrvolym säd)</summary>
    public static Volume Tunna(this int v) => new(v * 125_649.6);
    public static Volume Tunna(this double v) => new(v * 125_649.6);

    public static double ToJungfru(this Volume v) => v.Milliliters / 81.93;
    public static double ToStop(this Volume v) => v.Milliliters / 327.72;
    public static double ToKanna(this Volume v) => v.Milliliters / 2_617.7;
    public static double ToAnkare(this Volume v) => v.Milliliters / 39_265.5;
    public static double ToTunna(this Volume v) => v.Milliliters / 125_649.6;
}

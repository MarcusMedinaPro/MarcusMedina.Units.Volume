namespace MarcusMedina.Units.Volume.British;

/// <summary>
/// Brittiska volymenheter (imperial).
/// OBS: Dessa skiljer sig från amerikanska enheter med samma namn!
/// 1 brittisk gallon ≈ 4.546 L vs 1 US gallon ≈ 3.785 L.
/// <code>
/// 1.GallonUK().ToLiters()     // ≈ 4.546
/// 1.PintUK().ToMilliliters()  // ≈ 568.3
/// </code>
/// </summary>
public static class BritishVolumeExtensions
{
    /// <summary>1 UK teaspoon = 5.91939 mL</summary>
    public static Volume TeaspoonUK(this int v) => new(v * 5.91939);
    public static Volume TeaspoonUK(this double v) => new(v * 5.91939);

    /// <summary>1 UK tablespoon = 17.7582 mL</summary>
    public static Volume TablespoonUK(this int v) => new(v * 17.7582);
    public static Volume TablespoonUK(this double v) => new(v * 17.7582);

    /// <summary>1 UK fluid ounce = 28.4131 mL</summary>
    public static Volume FluidOunceUK(this int v) => new(v * 28.4131);
    public static Volume FluidOunceUK(this double v) => new(v * 28.4131);

    /// <summary>1 UK gill = 142.065 mL</summary>
    public static Volume GillUK(this int v) => new(v * 142.065);
    public static Volume GillUK(this double v) => new(v * 142.065);

    /// <summary>1 UK pint = 568.261 mL</summary>
    public static Volume PintUK(this int v) => new(v * 568.261);
    public static Volume PintUK(this double v) => new(v * 568.261);

    /// <summary>1 UK quart = 1 136.52 mL</summary>
    public static Volume QuartUK(this int v) => new(v * 1_136.52);
    public static Volume QuartUK(this double v) => new(v * 1_136.52);

    /// <summary>1 UK gallon = 4 546.09 mL</summary>
    public static Volume GallonUK(this int v) => new(v * 4_546.09);
    public static Volume GallonUK(this double v) => new(v * 4_546.09);

    public static double ToTeaspoonUK(this Volume v) => v.Milliliters / 5.91939;
    public static double ToTablespoonUK(this Volume v) => v.Milliliters / 17.7582;
    public static double ToFluidOunceUK(this Volume v) => v.Milliliters / 28.4131;
    public static double ToGillUK(this Volume v) => v.Milliliters / 142.065;
    public static double ToPintUK(this Volume v) => v.Milliliters / 568.261;
    public static double ToQuartUK(this Volume v) => v.Milliliters / 1_136.52;
    public static double ToGallonUK(this Volume v) => v.Milliliters / 4_546.09;
}

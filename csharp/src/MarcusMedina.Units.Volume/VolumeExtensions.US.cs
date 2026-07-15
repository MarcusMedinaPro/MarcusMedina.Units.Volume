namespace MarcusMedina.Units.Volume.US;

/// <summary>
/// Amerikanska volymenheter (US customary).
/// OBS: Dessa skiljer sig från brittiska enheter med samma namn!
/// <code>
/// 1.GallonUS().ToLiters()     // ≈ 3.785
/// 1.PintUS().ToMilliliters()  // ≈ 473.2
/// </code>
/// </summary>
public static class USVolumeExtensions
{
    /// <summary>1 US teaspoon = 4.92892 mL</summary>
    public static Volume TeaspoonUS(this int v) => new(v * 4.92892);
    public static Volume TeaspoonUS(this double v) => new(v * 4.92892);

    /// <summary>1 US tablespoon = 14.78676 mL</summary>
    public static Volume TablespoonUS(this int v) => new(v * 14.78676);
    public static Volume TablespoonUS(this double v) => new(v * 14.78676);

    /// <summary>1 US fluid ounce = 29.57353 mL</summary>
    public static Volume FluidOunceUS(this int v) => new(v * 29.57353);
    public static Volume FluidOunceUS(this double v) => new(v * 29.57353);

    /// <summary>1 US cup = 236.5882 mL</summary>
    public static Volume CupUS(this int v) => new(v * 236.5882);
    public static Volume CupUS(this double v) => new(v * 236.5882);

    /// <summary>1 US pint = 473.1765 mL</summary>
    public static Volume PintUS(this int v) => new(v * 473.1765);
    public static Volume PintUS(this double v) => new(v * 473.1765);

    /// <summary>1 US quart = 946.3529 mL</summary>
    public static Volume QuartUS(this int v) => new(v * 946.3529);
    public static Volume QuartUS(this double v) => new(v * 946.3529);

    /// <summary>1 US gallon = 3 785.412 mL</summary>
    public static Volume GallonUS(this int v) => new(v * 3_785.412);
    public static Volume GallonUS(this double v) => new(v * 3_785.412);

    public static double ToTeaspoonUS(this Volume v) => v.Milliliters / 4.92892;
    public static double ToTablespoonUS(this Volume v) => v.Milliliters / 14.78676;
    public static double ToFluidOunceUS(this Volume v) => v.Milliliters / 29.57353;
    public static double ToCupUS(this Volume v) => v.Milliliters / 236.5882;
    public static double ToPintUS(this Volume v) => v.Milliliters / 473.1765;
    public static double ToQuartUS(this Volume v) => v.Milliliters / 946.3529;
    public static double ToGallonUS(this Volume v) => v.Milliliters / 3_785.412;
}

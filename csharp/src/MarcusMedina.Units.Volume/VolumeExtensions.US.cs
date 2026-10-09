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
    extension(int v)
    {
        /// <summary>1 US teaspoon = 4.92892 mL</summary>
        public Volume TeaspoonUS() => new(v * 4.92892);
        /// <summary>1 US tablespoon = 14.78676 mL</summary>
        public Volume TablespoonUS() => new(v * 14.78676);
        /// <summary>1 US fluid ounce = 29.57353 mL</summary>
        public Volume FluidOunceUS() => new(v * 29.57353);
        /// <summary>1 US cup = 236.5882 mL</summary>
        public Volume CupUS() => new(v * 236.5882);
        /// <summary>1 US pint = 473.1765 mL</summary>
        public Volume PintUS() => new(v * 473.1765);
        /// <summary>1 US quart = 946.3529 mL</summary>
        public Volume QuartUS() => new(v * 946.3529);
        /// <summary>1 US gallon = 3 785.412 mL</summary>
        public Volume GallonUS() => new(v * 3_785.412);
    }

    extension(double v)
    {
        public Volume TeaspoonUS() => new(v * 4.92892);
        public Volume TablespoonUS() => new(v * 14.78676);
        public Volume FluidOunceUS() => new(v * 29.57353);
        public Volume CupUS() => new(v * 236.5882);
        public Volume PintUS() => new(v * 473.1765);
        public Volume QuartUS() => new(v * 946.3529);
        public Volume GallonUS() => new(v * 3_785.412);
    }

    extension(Volume v)
    {
        public double ToTeaspoonUS() => v.Milliliters / 4.92892;
        public double ToTablespoonUS() => v.Milliliters / 14.78676;
        public double ToFluidOunceUS() => v.Milliliters / 29.57353;
        public double ToCupUS() => v.Milliliters / 236.5882;
        public double ToPintUS() => v.Milliliters / 473.1765;
        public double ToQuartUS() => v.Milliliters / 946.3529;
        public double ToGallonUS() => v.Milliliters / 3_785.412;
    }
}

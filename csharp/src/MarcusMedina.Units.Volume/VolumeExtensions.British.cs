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
    extension(int v)
    {
        /// <summary>1 UK teaspoon = 5.91939 mL</summary>
        public Volume TeaspoonUK() => new(v * 5.91939);
        /// <summary>1 UK tablespoon = 17.7582 mL</summary>
        public Volume TablespoonUK() => new(v * 17.7582);
        /// <summary>1 UK fluid ounce = 28.4131 mL</summary>
        public Volume FluidOunceUK() => new(v * 28.4131);
        /// <summary>1 UK gill = 142.065 mL</summary>
        public Volume GillUK() => new(v * 142.065);
        /// <summary>1 UK pint = 568.261 mL</summary>
        public Volume PintUK() => new(v * 568.261);
        /// <summary>1 UK quart = 1 136.52 mL</summary>
        public Volume QuartUK() => new(v * 1_136.52);
        /// <summary>1 UK gallon = 4 546.09 mL</summary>
        public Volume GallonUK() => new(v * 4_546.09);
    }

    extension(double v)
    {
        public Volume TeaspoonUK() => new(v * 5.91939);
        public Volume TablespoonUK() => new(v * 17.7582);
        public Volume FluidOunceUK() => new(v * 28.4131);
        public Volume GillUK() => new(v * 142.065);
        public Volume PintUK() => new(v * 568.261);
        public Volume QuartUK() => new(v * 1_136.52);
        public Volume GallonUK() => new(v * 4_546.09);
    }

    extension(Volume v)
    {
        public double ToTeaspoonUK() => v.Milliliters / 5.91939;
        public double ToTablespoonUK() => v.Milliliters / 17.7582;
        public double ToFluidOunceUK() => v.Milliliters / 28.4131;
        public double ToGillUK() => v.Milliliters / 142.065;
        public double ToPintUK() => v.Milliliters / 568.261;
        public double ToQuartUK() => v.Milliliters / 1_136.52;
        public double ToGallonUK() => v.Milliliters / 4_546.09;
    }
}

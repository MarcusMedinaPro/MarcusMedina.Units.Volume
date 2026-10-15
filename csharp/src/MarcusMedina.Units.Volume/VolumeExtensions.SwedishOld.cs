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
    extension(int v)
    {
        /// <summary>1 jungfru = 1/4 stop = 81.93 mL</summary>
        public Volume Jungfru() => new(v * 81.93);
        /// <summary>1 stop = 1/8 kanna = 327.72 mL</summary>
        public Volume Stop() => new(v * 327.72);
        /// <summary>1 kanna = 2 617.7 mL (= 2.6177 liter, huvudenheten)</summary>
        public Volume Kanna() => new(v * 2_617.7);
        /// <summary>1 ankare = 15 kannor = 39 265.5 mL (ölankare)</summary>
        public Volume Ankare() => new(v * 39_265.5);
        /// <summary>1 tunna = 48 kannor = 125 649.6 mL (torrvolym säd)</summary>
        public Volume Tunna() => new(v * 125_649.6);
    }

    extension(double v)
    {
        public Volume Jungfru() => new(v * 81.93);
        public Volume Stop() => new(v * 327.72);
        public Volume Kanna() => new(v * 2_617.7);
        public Volume Ankare() => new(v * 39_265.5);
        public Volume Tunna() => new(v * 125_649.6);
    }

    extension(Volume v)
    {
        public double ToJungfru() => v.Milliliters / 81.93;
        public double ToStop() => v.Milliliters / 327.72;
        public double ToKanna() => v.Milliliters / 2_617.7;
        public double ToAnkare() => v.Milliliters / 39_265.5;
        public double ToTunna() => v.Milliliters / 125_649.6;
    }
}

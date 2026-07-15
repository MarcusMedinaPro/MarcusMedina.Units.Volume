using System.Globalization;

namespace MarcusMedina.Units.Volume;

/// <summary>
/// Representerar en volym med milliliter som basenhet.
/// Alla konverteringar sker genom att multiplicera/dividera milliliter-värdet.
/// </summary>
public readonly struct Volume : IComparable<Volume>, IEquatable<Volume>
{
    /// <summary>Värdet i milliliter (basenhet).</summary>
    public double Milliliters { get; }

    public Volume(double milliliters) { Milliliters = milliliters; }

    public int CompareTo(Volume other) => Milliliters.CompareTo(other.Milliliters);
    public bool Equals(Volume other) => Milliliters.Equals(other.Milliliters);
    public override bool Equals(object? obj) => obj is Volume v && Equals(v);
    public override int GetHashCode() => HashCode.Combine(Milliliters);
    public override string ToString() => $"{Milliliters.ToString("G", CultureInfo.InvariantCulture)} mL";

    public static bool operator ==(Volume a, Volume b) => a.Equals(b);
    public static bool operator !=(Volume a, Volume b) => !(a == b);
    public static bool operator <(Volume a, Volume b) => a.Milliliters < b.Milliliters;
    public static bool operator >(Volume a, Volume b) => a.Milliliters > b.Milliliters;
    public static bool operator <=(Volume a, Volume b) => a.Milliliters <= b.Milliliters;
    public static bool operator >=(Volume a, Volume b) => a.Milliliters >= b.Milliliters;
    public static Volume operator +(Volume a, Volume b) => new(a.Milliliters + b.Milliliters);
    public static Volume operator -(Volume a, Volume b) => new(a.Milliliters - b.Milliliters);
    public static Volume operator *(Volume v, double factor) => new(v.Milliliters * factor);
    public static Volume operator /(Volume v, double divisor) => new(v.Milliliters / divisor);
    public static double operator /(Volume a, Volume b) => a.Milliliters / b.Milliliters;
}

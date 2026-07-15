using FluentAssertions;
using MarcusMedina.Units.Volume.Metric;
using MarcusMedina.Units.Volume.US;
using MarcusMedina.Units.Volume.British;
using MarcusMedina.Units.Volume.SwedishOld;
using Xunit;

namespace MarcusMedina.Units.Volume.Tests;

public class MetricVolumeTests
{
    [Fact]
    public void OneLiter_ToMilliliters_Is1000()
        => 1.Liters().ToMilliliters().Should().BeApproximately(1000, 0.001);

    [Fact]
    public void OneDeciliter_ToMilliliters_Is100()
        => 1.Deciliters().ToMilliliters().Should().BeApproximately(100, 0.001);

    [Fact]
    public void OneCubicMeter_ToLiters_Is1000()
        => 1.CubicMeters().ToLiters().Should().BeApproximately(1000, 0.001);

    [Fact]
    public void RoundTrip_Liter()
        => 2.5.Liters().ToLiters().Should().BeApproximately(2.5, 0.0001);
}

public class USVolumeTests
{
    [Fact]
    public void OneGallonUS_ToLiters_Is3point785()
        => 1.GallonUS().ToLiters().Should().BeApproximately(3.785, 0.001);

    [Fact]
    public void OnePintUS_ToMilliliters_Is473()
        => 1.PintUS().ToMilliliters().Should().BeApproximately(473.18, 0.1);

    [Fact]
    public void RoundTrip_GallonUS()
        => 5.0.GallonUS().ToGallonUS().Should().BeApproximately(5.0, 0.0001);
}

public class BritishVolumeTests
{
    [Fact]
    public void OneGallonUK_ToLiters_Is4point546()
        => 1.GallonUK().ToLiters().Should().BeApproximately(4.546, 0.001);

    [Fact]
    public void OnePintUK_ToMilliliters_Is568()
        => 1.PintUK().ToMilliliters().Should().BeApproximately(568.261, 0.001);

    [Fact]
    public void UKGallon_BiggerThan_USGallon()
        => 1.GallonUK().ToMilliliters().Should().BeGreaterThan(1.GallonUS().ToMilliliters());

    [Fact]
    public void RoundTrip_GallonUK()
        => 3.0.GallonUK().ToGallonUK().Should().BeApproximately(3.0, 0.0001);
}

public class SwedishOldVolumeTests
{
    [Fact]
    public void OneKanna_ToLiters_Is2point618()
        => 1.Kanna().ToLiters().Should().BeApproximately(2.6177, 0.001);

    [Fact]
    public void OneTunna_ToKannor_Is48()
        => 1.Tunna().ToKanna().Should().BeApproximately(48, 0.01);

    [Fact]
    public void OneAnkare_ToKannor_Is15()
        => 1.Ankare().ToKanna().Should().BeApproximately(15, 0.01);

    [Fact]
    public void RoundTrip_Kanna()
        => 10.0.Kanna().ToKanna().Should().BeApproximately(10.0, 0.0001);
}

public class CrossSystemVolumeTests
{
    [Fact]
    public void OneKanna_ToGallonUS()
        => 1.Kanna().ToGallonUS().Should().BeApproximately(0.691, 0.001);

    [Fact]
    public void OneGallonUS_IsLessThan_OneGallonUK()
        => 1.GallonUS().ToMilliliters().Should().BeLessThan(1.GallonUK().ToMilliliters());
}

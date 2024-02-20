// ReSharper disable once CheckNamespace

namespace Avalonia.Media;

public interface IBlurEffect : IEffect
{
    double Radius { get; }
}

public class ImmutableBlurEffect : IBlurEffect, IImmutableEffect
{
    public ImmutableBlurEffect(double radius)
    {
        Radius = radius;
    }

    public double Radius { get; }

    public bool Equals(IEffect? other) =>
        // ReSharper disable once CompareOfFloatsByEqualityOperator
        other is IBlurEffect blur && blur.Radius == Radius;
}

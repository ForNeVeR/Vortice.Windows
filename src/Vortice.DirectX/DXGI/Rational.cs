// Copyright � Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.DXGI;

public partial struct Rational
{
    /// <summary>
    /// Initialize instance of <see cref="Rational"/> struct.
    /// </summary>
    /// <param name="numerator"></param>
    /// <param name="denominator"></param>
    public Rational(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public override string ToString() => $"Numerator: {Numerator}, Denominator: {Denominator}";
}

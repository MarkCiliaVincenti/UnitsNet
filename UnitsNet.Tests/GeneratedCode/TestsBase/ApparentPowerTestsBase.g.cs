﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ApparentPower.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ApparentPowerTestsBase
    {
        protected abstract double GigavoltamperesInOneVoltampere { get; }
        protected abstract double KilovoltamperesInOneVoltampere { get; }
        protected abstract double MegavoltamperesInOneVoltampere { get; }
        protected abstract double VoltamperesInOneVoltampere { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double GigavoltamperesTolerance { get { return 1e-5; } }
        protected virtual double KilovoltamperesTolerance { get { return 1e-5; } }
        protected virtual double MegavoltamperesTolerance { get { return 1e-5; } }
        protected virtual double VoltamperesTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ApparentPower((double)0.0, ApparentPowerUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ApparentPower();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ApparentPowerUnit.Voltampere, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ApparentPower(double.PositiveInfinity, ApparentPowerUnit.Voltampere));
            Assert.Throws<ArgumentException>(() => new ApparentPower(double.NegativeInfinity, ApparentPowerUnit.Voltampere));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ApparentPower(double.NaN, ApparentPowerUnit.Voltampere));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ApparentPower(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void ApparentPower_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ApparentPower(1, ApparentPowerUnit.Voltampere);

            QuantityInfo<ApparentPowerUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ApparentPower.Zero, quantityInfo.Zero);
            Assert.Equal("ApparentPower", quantityInfo.Name);
            Assert.Equal(QuantityType.ApparentPower, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<ApparentPowerUnit>().Except(new[] {ApparentPowerUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void VoltampereToApparentPowerUnits()
        {
            ApparentPower voltampere = ApparentPower.FromVoltamperes(1);
            AssertEx.EqualTolerance(GigavoltamperesInOneVoltampere, voltampere.Gigavoltamperes, GigavoltamperesTolerance);
            AssertEx.EqualTolerance(KilovoltamperesInOneVoltampere, voltampere.Kilovoltamperes, KilovoltamperesTolerance);
            AssertEx.EqualTolerance(MegavoltamperesInOneVoltampere, voltampere.Megavoltamperes, MegavoltamperesTolerance);
            AssertEx.EqualTolerance(VoltamperesInOneVoltampere, voltampere.Voltamperes, VoltamperesTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ApparentPower.From(1, ApparentPowerUnit.Gigavoltampere);
            AssertEx.EqualTolerance(1, quantity00.Gigavoltamperes, GigavoltamperesTolerance);
            Assert.Equal(ApparentPowerUnit.Gigavoltampere, quantity00.Unit);

            var quantity01 = ApparentPower.From(1, ApparentPowerUnit.Kilovoltampere);
            AssertEx.EqualTolerance(1, quantity01.Kilovoltamperes, KilovoltamperesTolerance);
            Assert.Equal(ApparentPowerUnit.Kilovoltampere, quantity01.Unit);

            var quantity02 = ApparentPower.From(1, ApparentPowerUnit.Megavoltampere);
            AssertEx.EqualTolerance(1, quantity02.Megavoltamperes, MegavoltamperesTolerance);
            Assert.Equal(ApparentPowerUnit.Megavoltampere, quantity02.Unit);

            var quantity03 = ApparentPower.From(1, ApparentPowerUnit.Voltampere);
            AssertEx.EqualTolerance(1, quantity03.Voltamperes, VoltamperesTolerance);
            Assert.Equal(ApparentPowerUnit.Voltampere, quantity03.Unit);

        }

        [Fact]
        public void FromVoltamperes_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ApparentPower.FromVoltamperes(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ApparentPower.FromVoltamperes(double.NegativeInfinity));
        }

        [Fact]
        public void FromVoltamperes_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ApparentPower.FromVoltamperes(double.NaN));
        }

        [Fact]
        public void As()
        {
            var voltampere = ApparentPower.FromVoltamperes(1);
            AssertEx.EqualTolerance(GigavoltamperesInOneVoltampere, voltampere.As(ApparentPowerUnit.Gigavoltampere), GigavoltamperesTolerance);
            AssertEx.EqualTolerance(KilovoltamperesInOneVoltampere, voltampere.As(ApparentPowerUnit.Kilovoltampere), KilovoltamperesTolerance);
            AssertEx.EqualTolerance(MegavoltamperesInOneVoltampere, voltampere.As(ApparentPowerUnit.Megavoltampere), MegavoltamperesTolerance);
            AssertEx.EqualTolerance(VoltamperesInOneVoltampere, voltampere.As(ApparentPowerUnit.Voltampere), VoltamperesTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var voltampere = ApparentPower.FromVoltamperes(1);

            var gigavoltampereQuantity = voltampere.ToUnit(ApparentPowerUnit.Gigavoltampere);
            AssertEx.EqualTolerance(GigavoltamperesInOneVoltampere, (double)gigavoltampereQuantity.Value, GigavoltamperesTolerance);
            Assert.Equal(ApparentPowerUnit.Gigavoltampere, gigavoltampereQuantity.Unit);

            var kilovoltampereQuantity = voltampere.ToUnit(ApparentPowerUnit.Kilovoltampere);
            AssertEx.EqualTolerance(KilovoltamperesInOneVoltampere, (double)kilovoltampereQuantity.Value, KilovoltamperesTolerance);
            Assert.Equal(ApparentPowerUnit.Kilovoltampere, kilovoltampereQuantity.Unit);

            var megavoltampereQuantity = voltampere.ToUnit(ApparentPowerUnit.Megavoltampere);
            AssertEx.EqualTolerance(MegavoltamperesInOneVoltampere, (double)megavoltampereQuantity.Value, MegavoltamperesTolerance);
            Assert.Equal(ApparentPowerUnit.Megavoltampere, megavoltampereQuantity.Unit);

            var voltampereQuantity = voltampere.ToUnit(ApparentPowerUnit.Voltampere);
            AssertEx.EqualTolerance(VoltamperesInOneVoltampere, (double)voltampereQuantity.Value, VoltamperesTolerance);
            Assert.Equal(ApparentPowerUnit.Voltampere, voltampereQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ApparentPower voltampere = ApparentPower.FromVoltamperes(1);
            AssertEx.EqualTolerance(1, ApparentPower.FromGigavoltamperes(voltampere.Gigavoltamperes).Voltamperes, GigavoltamperesTolerance);
            AssertEx.EqualTolerance(1, ApparentPower.FromKilovoltamperes(voltampere.Kilovoltamperes).Voltamperes, KilovoltamperesTolerance);
            AssertEx.EqualTolerance(1, ApparentPower.FromMegavoltamperes(voltampere.Megavoltamperes).Voltamperes, MegavoltamperesTolerance);
            AssertEx.EqualTolerance(1, ApparentPower.FromVoltamperes(voltampere.Voltamperes).Voltamperes, VoltamperesTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ApparentPower v = ApparentPower.FromVoltamperes(1);
            AssertEx.EqualTolerance(-1, -v.Voltamperes, VoltamperesTolerance);
            AssertEx.EqualTolerance(2, (ApparentPower.FromVoltamperes(3)-v).Voltamperes, VoltamperesTolerance);
            AssertEx.EqualTolerance(2, (v + v).Voltamperes, VoltamperesTolerance);
            AssertEx.EqualTolerance(10, (v*10).Voltamperes, VoltamperesTolerance);
            AssertEx.EqualTolerance(10, (10*v).Voltamperes, VoltamperesTolerance);
            AssertEx.EqualTolerance(2, (ApparentPower.FromVoltamperes(10)/5).Voltamperes, VoltamperesTolerance);
            AssertEx.EqualTolerance(2, ApparentPower.FromVoltamperes(10)/ApparentPower.FromVoltamperes(5), VoltamperesTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ApparentPower oneVoltampere = ApparentPower.FromVoltamperes(1);
            ApparentPower twoVoltamperes = ApparentPower.FromVoltamperes(2);

            Assert.True(oneVoltampere < twoVoltamperes);
            Assert.True(oneVoltampere <= twoVoltamperes);
            Assert.True(twoVoltamperes > oneVoltampere);
            Assert.True(twoVoltamperes >= oneVoltampere);

            Assert.False(oneVoltampere > twoVoltamperes);
            Assert.False(oneVoltampere >= twoVoltamperes);
            Assert.False(twoVoltamperes < oneVoltampere);
            Assert.False(twoVoltamperes <= oneVoltampere);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ApparentPower voltampere = ApparentPower.FromVoltamperes(1);
            Assert.Equal(0, voltampere.CompareTo(voltampere));
            Assert.True(voltampere.CompareTo(ApparentPower.Zero) > 0);
            Assert.True(ApparentPower.Zero.CompareTo(voltampere) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ApparentPower voltampere = ApparentPower.FromVoltamperes(1);
            Assert.Throws<ArgumentException>(() => voltampere.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ApparentPower voltampere = ApparentPower.FromVoltamperes(1);
            Assert.Throws<ArgumentNullException>(() => voltampere.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ApparentPower.FromVoltamperes(1);
            var b = ApparentPower.FromVoltamperes(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            var a = ApparentPower.FromVoltamperes(1);
            var b = ApparentPower.FromVoltamperes(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = ApparentPower.FromVoltamperes(1);
            Assert.True(v.Equals(ApparentPower.FromVoltamperes(1), VoltamperesTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ApparentPower.Zero, VoltamperesTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ApparentPower voltampere = ApparentPower.FromVoltamperes(1);
            Assert.False(voltampere.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ApparentPower voltampere = ApparentPower.FromVoltamperes(1);
            Assert.False(voltampere.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ApparentPowerUnit.Undefined, ApparentPower.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ApparentPowerUnit)).Cast<ApparentPowerUnit>();
            foreach(var unit in units)
            {
                if(unit == ApparentPowerUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ApparentPower.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 GVA", new ApparentPower(1, ApparentPowerUnit.Gigavoltampere).ToString());
                Assert.Equal("1 kVA", new ApparentPower(1, ApparentPowerUnit.Kilovoltampere).ToString());
                Assert.Equal("1 MVA", new ApparentPower(1, ApparentPowerUnit.Megavoltampere).ToString());
                Assert.Equal("1 VA", new ApparentPower(1, ApparentPowerUnit.Voltampere).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 GVA", new ApparentPower(1, ApparentPowerUnit.Gigavoltampere).ToString(swedishCulture));
            Assert.Equal("1 kVA", new ApparentPower(1, ApparentPowerUnit.Kilovoltampere).ToString(swedishCulture));
            Assert.Equal("1 MVA", new ApparentPower(1, ApparentPowerUnit.Megavoltampere).ToString(swedishCulture));
            Assert.Equal("1 VA", new ApparentPower(1, ApparentPowerUnit.Voltampere).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 VA", new ApparentPower(0.123456, ApparentPowerUnit.Voltampere).ToString("s1"));
                Assert.Equal("0.12 VA", new ApparentPower(0.123456, ApparentPowerUnit.Voltampere).ToString("s2"));
                Assert.Equal("0.123 VA", new ApparentPower(0.123456, ApparentPowerUnit.Voltampere).ToString("s3"));
                Assert.Equal("0.1235 VA", new ApparentPower(0.123456, ApparentPowerUnit.Voltampere).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 VA", new ApparentPower(0.123456, ApparentPowerUnit.Voltampere).ToString("s1", culture));
            Assert.Equal("0.12 VA", new ApparentPower(0.123456, ApparentPowerUnit.Voltampere).ToString("s2", culture));
            Assert.Equal("0.123 VA", new ApparentPower(0.123456, ApparentPowerUnit.Voltampere).ToString("s3", culture));
            Assert.Equal("0.1235 VA", new ApparentPower(0.123456, ApparentPowerUnit.Voltampere).ToString("s4", culture));
        }
    }
}
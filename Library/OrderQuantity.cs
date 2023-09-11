// Copyright (c) Land O'Lakes. All rights reserved.

using UnitsNet;

namespace SharedKernel.ValueObjects
{
    public readonly struct OrderQuantity : IArithmeticQuantity<OrderQuantity, OrderQuantityUnit, decimal>
    {
        public OrderQuantityUnit Unit => throw new NotImplementedException();

        public QuantityInfo<OrderQuantityUnit> QuantityInfo => throw new NotImplementedException();

        public decimal Value => throw new NotImplementedException();

        public BaseDimensions Dimensions => throw new NotImplementedException();

        QuantityInfo IQuantity.QuantityInfo => throw new NotImplementedException();

        Enum IQuantity.Unit => throw new NotImplementedException();

        QuantityValue IQuantity.Value => throw new NotImplementedException();

        public decimal As(OrderQuantityUnit unit)
        {
            throw new NotImplementedException();
        }

        public decimal As(Enum unit)
        {
            throw new NotImplementedException();
        }

        public decimal As(UnitSystem unitSystem)
        {
            throw new NotImplementedException();
        }

        public bool Equals(OrderQuantity other, OrderQuantity tolerance)
        {
            throw new NotImplementedException();
        }

        public bool Equals(IQuantity? other, IQuantity tolerance)
        {
            throw new NotImplementedException();
        }

        public string ToString(IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            throw new NotImplementedException();
        }

        public IQuantity<OrderQuantityUnit> ToUnit(OrderQuantityUnit unit)
        {
            throw new NotImplementedException();
        }

        public IQuantity<OrderQuantityUnit> ToUnit(UnitSystem unitSystem)
        {
            throw new NotImplementedException();
        }

        public IValueQuantity<decimal> ToUnit(Enum unit)
        {
            throw new NotImplementedException();
        }

        double IQuantity<OrderQuantityUnit>.As(OrderQuantityUnit unit)
        {
            throw new NotImplementedException();
        }

        double IQuantity.As(Enum unit)
        {
            throw new NotImplementedException();
        }

        double IQuantity.As(UnitSystem unitSystem)
        {
            throw new NotImplementedException();
        }

        IValueQuantity<decimal> IValueQuantity<decimal>.ToUnit(UnitSystem unitSystem)
        {
            throw new NotImplementedException();
        }

        IQuantity IQuantity.ToUnit(Enum unit)
        {
            throw new NotImplementedException();
        }

        IQuantity IQuantity.ToUnit(UnitSystem unitSystem)
        {
            throw new NotImplementedException();
        }
    }
}

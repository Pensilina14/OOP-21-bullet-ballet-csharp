using System;
using System.Collections.Generic;
using OOP21_task_cSharp.Pioggia;

namespace OOP21_bullet_ballet_cSharp.Pioggia
{
    internal class Dimension2DCore : IDimension2D
    {
        private readonly double _height;
        private readonly double _width;

        public Dimension2DCore(double height, double width)
        {
            this._height = height;
            this._width = width;
        }
        
        public double GetHeight()
        {
            return this._height;
        }

        public double GetWidth()
        {
            return this._width;
        }

        private sealed class HeightWidthEqualityComparer : IEqualityComparer<Dimension2DCore>
        {
            public bool Equals(Dimension2DCore x, Dimension2DCore y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return x._height.Equals(y._height) && x._width.Equals(y._width);
            }

            public int GetHashCode(Dimension2DCore obj)
            {
                return HashCode.Combine(obj._height, obj._width);
            }
        }

        public static IEqualityComparer<Dimension2DCore> HeightWidthComparer { get; } = new HeightWidthEqualityComparer();
    }
}

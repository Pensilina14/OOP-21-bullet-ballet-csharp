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
    }
}

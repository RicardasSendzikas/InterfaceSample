using PirkiniuKrepselisCore.Contracts;

namespace PirkiniuKrepselisCore.Services
{
    public class ShapeService
    {
        public double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
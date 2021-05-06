using NUnit.Framework;

namespace Lab5
{
    public class Tests : Expected 
    {

        [Test]
        public void TestRectangleGetArea([Range(0, 20)] int x, [Range(0, 20)] int y)
        {
            var temp = GeometricFigures.Rectangle.GetArea(x, y);
            Assert.AreEqual(GetAreaRectangle(x, y), temp);
        }
        
        [Test]
        public void TestRectangleGetLength([Range(0, 20)] int x, [Range(0, 20)] int y)
        {
            var temp = GeometricFigures.Rectangle.GetLength(x, y);
            Assert.AreEqual(GetLengthRectangle(x, y), temp);
        }
        [Test]
        public void TestSquareGetArea([Range(0, 20)] int x)
        {
            var temp = GeometricFigures.Square.GetArea(x);
            Assert.AreEqual(GetAreaSquare(x), temp);
        }

        [Test]
        public void TestSquareGetLength([Range(0, 20)] int x)
        { 
            var temp = GeometricFigures.Square.GetLength(x);
            Assert.AreEqual(GetLengthSquare(x), temp);
        }

        [Test]
        public void TestTreangleGetArea([Range(0, 20)] int x, [Range(0, 20)] int y, [Range(0, 20)] int z)
        {
            var temp = GeometricFigures.Triangle.GetArea(x, y, z);
            Assert.AreEqual(GetAreaTreangle(x, y, z), temp);
        }

        [Test]
        public void TestTreangleGetLength([Range(0, 20)] int x, [Range(0, 20)] int y, [Range(0, 20)] int z)
        {
            var temp = GeometricFigures.Triangle.GetLength(x, y, z);
            Assert.AreEqual(GetLengthTreangle(x, y, z), temp);
        }
    }
}
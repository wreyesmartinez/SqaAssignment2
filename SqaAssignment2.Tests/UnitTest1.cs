using NUnit.Framework;
using SqaAssignment2;

namespace SqaAssignment2.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        /**
         * Input validation.
         * The valid input should be higher than zero.
         **/
        [Test]
        public void Analyze_InvalidInput_ReturnsFalse()
        {
            //Arrange
            int sideA = 0;
            int sideB = 0;
            int sideC = 0;

            var rectangle = TriangleSolver.Analyze(sideA, sideB, sideC);

            //Act
            

            //Assert
            Assert.AreEqual(rectangle, "");
        }

        /**
         * Input validation.
         * The valid input should be positive values.
         **/
        [Test]
        public void Analyze_NegativeValues_ReturnsFalse()
        {
            //Arrange
            int sideA = -1;
            int sideB = 0;
            int sideC = 0;

            var rectangle = TriangleSolver.Analyze(sideA, sideB, sideC);

            //Act


            //Assert
            Assert.AreEqual(rectangle, "");
        }

        /**
         * Input validation.
         * The valid input should be higher than zero.
         **/
        [Test]
        public void Analyze_BlankInput_ReturnsFalse()
        {
            //Arrange
            int sideA = 0;
            int sideB = 0;
            int sideC = 0;

            var rectangle = TriangleSolver.Analyze(sideA, sideB, sideC);

            //Act


            //Assert
            Assert.AreEqual(rectangle, "");
        }

        /**
         * Return validation.
         * The Analyze method identifies if the inputs values are valid and those, do not form a triangle.
         **/
        [Test]
        public void Analyze_NotTriangle_ReturnsFalse()
        {
            //Arrange
            int sideA = 5;
            int sideB = 3;
            int sideC = 8;

            var rectangle = TriangleSolver.Analyze(sideA, sideB, sideC);

            //Act


            //Assert
            Assert.AreEqual(rectangle, "");
        }

        /**
         * Return validation.
         * The Analyze method identifies if the inputs values are valid and those, do form a triangle.
         **/
        [Test]
        public void Analyze_IsATriangle_ReturnsTrue()
        {
            //Arrange
            int sideA = 10;
            int sideB = 13;
            int sideC = 22;

            var rectangle = TriangleSolver.Analyze(sideA, sideB, sideC);

            //Act


            //Assert
            Assert.IsNotEmpty(rectangle);
        }

        /**
         * Return validation.
         * The Analyze method identifies if the inputs values form a  equilateral triangle.
         **/
        [Test]
        public void Analyze_EquilateralTriangle_ReturnsTrue()
        {
            //Arrange
            int sideA = 5;
            int sideB = 5;
            int sideC = 5;

            var rectangle = TriangleSolver.Analyze(sideA, sideB, sideC);

            //Act


            //Assert
            Assert.AreEqual(rectangle, "Equilateral");
        }

        /**
         * Return validation.
         * The Analyze method identifies if the inputs values form a  isosceles triangle.
         **/
        [Test]
        public void Analyze_IsoscelesTriangle_ReturnsTrue()
        {
            //Arrange
            int sideA = 5;
            int sideB = 2;
            int sideC = 5;

            var rectangle = TriangleSolver.Analyze(sideA, sideB, sideC);

            //Act


            //Assert
            Assert.AreEqual(rectangle, "Isosceles");
        }

        /**
         * Return validation.
         * The Analyze method identifies if the inputs values form a  scalene triangle.
         **/
        [Test]
        public void Analyze_ScaleneTriangle_ReturnsTrue()
        {
            //Arrange
            int sideA = 3;
            int sideB = 6;
            int sideC = 8;

            var rectangle = TriangleSolver.Analyze(sideA, sideB, sideC);

            //Act


            //Assert
            Assert.AreEqual(rectangle, "Scalene");
        }

    }
}

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
         * This test was selected due to the input values are needed for the entire program functionality.
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
         * The valid input should have positive values.
         * This test was selected due to negative length in the side of the triangle is not correct.
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
         * Interior angles property.
         * The angles of the triangle should sum up to 180 degrees.
         * This test was selected to validate the interior angles property, to ensure the correct execution of the program.
         **/
        [Test]
        public void Analyze_AngleTriangle_ReturnsTrue()
        {
            //Arrange
            int sideA = 8;
            int sideB = 6;
            int sideC = 7;

            var rectangle = TriangleSolver.Analyze(sideA, sideB, sideC);

            //Act
            
            //Assert
            Assert.IsNotEmpty(rectangle);
        }

        /**
         * Return validation.
         * The Analyze method identifies if the inputs values are valid and if those sides do not form a triangle.
         * This test was selected to validate the sides of triangle property to ensure the correct response of the program.
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
         * The Analyze method identifies if the inputs values are valid and if those sides do form a triangle.
         * This test was selected to validate the sides of triangle property to ensure it is well form.
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
         * The Analyze method identifies if the inputs values form a equilateral triangle.
         * This  test was selected to validate if the entries correspond to an equilateral triangle.
         **/
        [Test]
        public void Analyze_EquilateralTriangle_ReturnsTrue()
        {
            //Arrange
            int sideA = 8;
            int sideB = 8;
            int sideC = 8;

            var rectangle = TriangleSolver.Analyze(sideA, sideB, sideC);

            //Act

            //Assert
            Assert.AreEqual(rectangle, "Equilateral");
        }

        /**
         * Return validation.
         * The Analyze method identifies if the inputs values form a isosceles triangle.
         * This  test was selected to validate if the entries correspond to an isosceles triangle.
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
         * The Analyze method identifies if the inputs values form a scalene triangle.
         * This  test was selected to validate if the entries correspond to a scalene triangle.
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

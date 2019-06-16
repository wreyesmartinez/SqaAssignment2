using NUnit.Framework;
using SqaAssignment2;

namespace SqaAssignment2.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Analyze_RetrivingInfo_ReturnsFalse()
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

       
    }
}

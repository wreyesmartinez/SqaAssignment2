using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqaAssignment2
{
    public static class TriangleSolver
    {
        /**
         * Variable definition for the 3 sides of the triangle
         **/
        public static int sideOne;
        public static int sideTwo;
        public static int sideThree;


        /**
         * This method validates which type of triangle can be form base on the user inputs. 
         **/
        public static string Analyze(int One, int Two, int Three)
        {
            sideOne = One;
            sideTwo = Two;
            sideThree = Three;

            string typeTriangle = string.Empty;
            
            if (validateNumbers())
                if (angleTriangle())
                    if(triangleInequalityTheorem()) 
                    {
                        if ((sideOne == sideTwo) && (sideOne == sideThree))
                            typeTriangle = "Equilateral";
                        else if( (sideOne == sideTwo) || (sideOne == sideThree) || (sideTwo == sideThree))
                            typeTriangle = "Isosceles";
                        else if ((sideOne != sideTwo) || (sideOne != sideThree) || (sideTwo != sideThree))
                            typeTriangle = "Scalene";
                    }
            return typeTriangle;
        }

        /**
         * This method validates if the sides of the triangle are greater than zero to proceed.
         **/
        public static bool validateNumbers()
        {
            if (sideOne > 0 && sideTwo > 0 && sideThree > 0)
                return true;
            else
                return false;
        }

        /**
         * This method validates that the sum of the lenghts of any 2 sides must be greater than the third side of the triangle.
         **/
        public static bool triangleInequalityTheorem()
        {
            if ( (sideOne + sideTwo)   > sideThree &&
                 (sideOne + sideThree) > sideTwo   &&
                 (sideTwo + sideThree) > sideOne)
                return true;
            else
                return false;
        }

        /**
         * This method validates that the sum of the inner angles would be to 180 degrees.
         **/
        public static bool angleTriangle()
        {
            // Law of Cosines to know the angle of the side A
            double cosA = ((Math.Pow(sideTwo, 2)) + (Math.Pow(sideThree, 2)) - (Math.Pow(sideOne, 2))) / (2 * (sideTwo * sideThree));
            double aAngle = Math.Round(Math.Acos(cosA), 2);

            // Law of Cosines to know the angle of the side B
            double cosB = ((Math.Pow(sideThree, 2)) + (Math.Pow(sideOne, 2)) - (Math.Pow(sideTwo, 2))) / (2 * (sideThree* sideOne));
            double bAngle = Math.Round(Math.Acos(cosB), 2);

            // Angle of the side C
            double cAngle = Math.Round( (180 - aAngle - bAngle), 2);
            
            return (aAngle + bAngle + cAngle) == 180;
        }

    }
}

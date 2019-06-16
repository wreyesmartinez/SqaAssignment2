using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqaAssignment2
{
    public static class TriangleSolver
    {

        public static int sideOne;
        public static int sideTwo;
        public static int sideThree;

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

        public static bool validateNumbers()
        {
            if (sideOne > 0 && sideTwo > 0 && sideThree > 0)
                return true;
            else
                return false;
        }

        public static bool triangleInequalityTheorem()
        {
            if ( (sideOne + sideTwo)   > sideThree &&
                 (sideOne + sideThree) > sideTwo   &&
                 (sideTwo + sideThree) > sideOne)
                return true;
            else
                return false;
        }

        public static bool angleTriangle()
        {
            double cosA = ((Math.Pow(sideTwo, 2)) + (Math.Pow(sideThree, 2)) - (Math.Pow(sideOne, 2))) / (2 * (sideTwo * sideThree));
            double aAngle = Math.Round(Math.Acos(cosA), 2);

            double cosB = ((Math.Pow(sideThree, 2)) + (Math.Pow(sideOne, 2)) - (Math.Pow(sideTwo, 2))) / (2 * (sideThree* sideOne));
            double bAngle = Math.Round(Math.Acos(cosB), 2);

            double cAngle = 180 - aAngle - bAngle;
            Console.WriteLine("angle C: ", cAngle);
            
            return (aAngle + bAngle + cAngle) == 180;
        }

    }
}

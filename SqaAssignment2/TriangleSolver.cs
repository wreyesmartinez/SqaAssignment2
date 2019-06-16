using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqaAssignment2
{
    static class TriangleSolver
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
                if (triangleInequalityTheorem())
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

    }
}

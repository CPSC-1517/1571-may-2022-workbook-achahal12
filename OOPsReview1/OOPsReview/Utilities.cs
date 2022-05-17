using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    public static class Utilities
    {
        //static class are NOT instantiated by the outside user (developere)
        //static class items are referenced using the classname.xxxxxx
        //method within this class have the keyword static in their signature
        // static classes are shared between all outside user at the SAME time
        //DoNOT consider saving data within a static class BECAUSE you cannot be
        // certain it will be there want you use the class again
        //consider placing GENERIC re-usable method within a static class

        //sample of overloaded method
        //the method signatures 
        public static bool IsZeroPositive(int value)
        {
            bool valid = true;
            if (value < 0)
            {
                valid = false;
            }
            return valid;
        }

        public static bool IsZeroPositive(double value)
        {
            bool valid = true;
            if (value < 0)
            {
                valid = false;
            }
            return valid;
        }

        public static bool IsZeroPositive(decimal value)
        {
            bool valid = true;
            if (value < 0)
            {
                valid = false;
            }
            return valid;
        }
    }// eoc
} //eon

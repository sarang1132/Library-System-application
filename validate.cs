using System;

namespace customValidation
{
    public class validate
    {
        public static Boolean  valid(string A,string B)
        {
            if(A.Equals("Sarang")&& B.Equals("Pass@123"))
            {

                return true;
            }
            return false;
        }


    }
}

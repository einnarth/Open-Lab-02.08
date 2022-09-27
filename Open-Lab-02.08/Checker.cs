using System;
using System.ComponentModel.Design;

namespace Open_Lab_02._08
{
    public class Checker
    {
        public bool IsEmpty(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return true;
            }else
            {
                return false;
            }
        }  
    }
}

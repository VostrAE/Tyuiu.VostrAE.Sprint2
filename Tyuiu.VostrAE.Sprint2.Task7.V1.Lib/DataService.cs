﻿using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VostrAE.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1 && ((x <= y) && (x >= -y) && (y > 0) && (y <= 1))))
                {
                res = true;
            }
            else { res = false; }
            return res;
        }
        
    }

}

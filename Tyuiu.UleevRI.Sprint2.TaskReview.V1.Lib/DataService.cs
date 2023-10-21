using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.UleevRI.Sprint2.TaskReview.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y >= x) && (y >= -x) && (x*x + y*y <= 1) && (y >= 0) && (y <= 1) && (x >= -1) && (x <= 1)) res = true;
            else res = false;
            return res;
        }
    }
}

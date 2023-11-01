using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RagimovaMA.Sprint2.Task1.V7.Lib
{
    public class DataService : ISprint2Task1V7
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (d < c); //true
            res[1] = (a > b) & (d < c); //false
            res[2] = (b > a) || (d < c); //false
            res[3] = (a > b) && (d < c); //false
            res[4] = (!res[2]); //true
            res[5] = (a > b) ^ (c < d); //false
            return res;
        }
    }
}

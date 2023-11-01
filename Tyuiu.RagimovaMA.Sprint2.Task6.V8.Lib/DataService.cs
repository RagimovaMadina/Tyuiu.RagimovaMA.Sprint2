using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RagimovaMA.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            int k = n - 1;
            if (n == 1)
            {
                switch (m)
                {
                    case 1: return "";
                    case 2: return "31." + "0" + (m - 1).ToString();
                    case 3: return "28." + "0" + (m - 1).ToString();
                    case 4: return "31." + "0" + (m - 1).ToString();
                    case 5: return "30." + "0" + (m - 1).ToString();
                    case 6: return "31." + "0" + (m - 1).ToString();
                    case 7: return "30." + "0" + (m - 1).ToString();
                    case 8: return "31." + "0" + (m - 1).ToString();
                    case 9: return "31." + "0" + (m - 1).ToString();
                    case 10: return "30." + "0" + (m - 1).ToString();
                    case 11: return "31." + (m - 1).ToString();
                    case 12: return "30." + (m - 1).ToString();
                    default:
                        throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
                }
            }
            else if (n < 32 && n != 1)
            {
                if (m < 10)
                {
                    if (n < 10)
                    {
                        return "0" + k + ".0" + m;
                    }
                    else
                    {
                        return k + ".0" + m;
                    }
                }
                else
                {
                    if (n < 10)
                    {
                        return "0" + k + "." + m;
                    }
                    else
                    {
                        return k + "." + m;
                    }
                }
            }
            else
            {
                throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
            }

        }
    }
}

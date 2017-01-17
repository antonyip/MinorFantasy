using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balancing
{
    public static class TestHelpers
    {
        public static bool ValueIsBetween(float value, float minValue, float maxValue)
        {
            if (value < minValue || value > maxValue)
                return false;

            return true;
        }
    }
}

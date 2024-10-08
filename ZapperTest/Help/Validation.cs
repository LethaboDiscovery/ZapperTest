using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapperTest.Help
{
    public static class Validation
    {
        public static void ValidateFeatureId(int featureId)
        {          
            if (!IsValidFeature(featureId))
            {
                Console.WriteLine("Feature id must be between 1 and 8");
            }
        }

        public static bool IsValidFeature(int featureId) 
        {
        return (featureId >= 1 && featureId <= 8) ? true : false;
        }
    }
}

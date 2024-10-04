using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapperTest
{
    public  class UserSettings
    {
        public static bool IsFeatureEnabled(string settings, int  featureId)
        {
            bool IsValidFeature = (featureId >= 1 && featureId <= 8) ? true: false;

            return settings[featureId - 1] == '1';
        }
    }
}

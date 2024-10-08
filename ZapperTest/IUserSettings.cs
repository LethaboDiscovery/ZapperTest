using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapperTest
{
    public interface IUserSettings
    {
        bool IsFeatureEnabled(string setting, int featureId);
        bool IsFeatureEnabled(int featureId);
        void EnableFeature(int featureId);
        void DisableFeature(int featureId);

        string GetSettings();
    }
}

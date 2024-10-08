using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZapperTest.Help;

namespace ZapperTest
{
    public  class UserSettings : IUserSettings
    {
        private readonly IUserSettingsStore _userSettingsStore;

        private byte _settings;

        public UserSettings(IUserSettingsStore userSettingsStore)
        {
            _userSettingsStore = userSettingsStore;
            LoadSettings();
        }


        public bool IsFeatureEnabled(string setting, int  featureId)
        {
            Validation.ValidateFeatureId(featureId);

            return setting[featureId - 1] == '1';
        }

        public void DisableFeature(int featureId)
        {
            if (Validation.IsValidFeature(featureId))
            {
                _settings &= (byte)(_settings - (1 <<8 - featureId));
                _userSettingsStore?.WriteFileSettings(_settings);
            }

        }

        public void EnableFeature(int featureId)
        {
            if (Validation.IsValidFeature(featureId))
            {
                _settings |= (byte)(1 << 8 - featureId);
                _userSettingsStore?.WriteFileSettings(_settings);
            }
        }

        public bool IsFeatureEnabled(int featureId)
        {
            Validation.ValidateFeatureId(featureId);
            bool isEnable = (_settings & (1 << featureId)) != 0;
            return isEnable;
        }

        public string GetSettings()
        {
            return Convert.ToString(_settings, 2).PadLeft(8, '0');          
        }

        private void LoadSettings()
        {
            _settings = _userSettingsStore.ReadFileSettings();
        }
    }
}

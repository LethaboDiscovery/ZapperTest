using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapperTest
{
    public class UserSettingStore : IUserSettingsStore
    {
        private readonly string  _filePath;

        public UserSettingStore(string filePath)
        {
            _filePath = filePath;
        }
        public byte ReadFileSettings()
        {
            if (File.Exists(_filePath)) 
            { 
                byte[] settings = File.ReadAllBytes(_filePath);
                return settings.FirstOrDefault();
            }
            return 0;
        }

        public void WriteFileSettings(byte settings)
        {
            File.WriteAllBytes(_filePath, new byte[] {settings});
        }
    }
}

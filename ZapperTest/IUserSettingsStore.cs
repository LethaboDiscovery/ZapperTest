using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapperTest
{
    public interface IUserSettingsStore
    {
        byte ReadFileSettings();
        void WriteFileSettings(byte settings);
    }
}

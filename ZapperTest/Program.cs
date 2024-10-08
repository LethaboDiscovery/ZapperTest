
using ZapperTest;

IUserSettingsStore userSettingsStore = new UserSettingStore("setting.bat");
IUserSettings userSettings = new UserSettings(userSettingsStore);

//testing 2.1
Console.WriteLine(userSettings.IsFeatureEnabled("00000000", 7));
Console.WriteLine(userSettings.IsFeatureEnabled("00000010", 7));
Console.WriteLine(userSettings.IsFeatureEnabled("11111111", 4));
Console.WriteLine(userSettings.IsFeatureEnabled("00000001", 7));

Console.WriteLine(userSettings.GetSettings());
//testing 2.2
userSettings.EnableFeature(1);
Console.WriteLine(userSettings.GetSettings());
userSettings.EnableFeature(2);


Console.WriteLine(userSettings.GetSettings());

Console.WriteLine(userSettings.IsFeatureEnabled(1));
Console.WriteLine(userSettings.IsFeatureEnabled(2));

userSettings.DisableFeature(1);
Console.WriteLine(userSettings.GetSettings());




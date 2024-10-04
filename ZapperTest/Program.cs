
using ZapperTest;

Console.WriteLine(UserSettings.IsFeatureEnabled("00000000", 7));//false
Console.WriteLine(UserSettings.IsFeatureEnabled("00000010", 7));//true
Console.WriteLine(UserSettings.IsFeatureEnabled("11111111", 9));//true
Console.WriteLine(UserSettings.IsFeatureEnabled("00000001", 7));//false


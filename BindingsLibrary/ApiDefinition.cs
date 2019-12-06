using Foundation;
using ObjCRuntime;

namespace BindingsLibrary.ThemeKit
{
    [BaseType(typeof(NSObject), Name = "TKThemeManager")]
    interface ThemeManager
    {
        [Static, Export("sharedManager")]
        ThemeManager Shared { get; }

        [Export("themeWithIdentifier:")]
        NSObject Theme(string identifier);
    }
}

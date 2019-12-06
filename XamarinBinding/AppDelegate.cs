using AppKit;
using Foundation;
using BindingsLibrary.ThemeKit;

namespace XamarinBinding
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        public override void WillFinishLaunching(NSNotification notification)
        {
            var themeManager = ThemeManager.Shared;
            var ladyInDarkTheme = themeManager.Theme("com.luckymarmot.ThemeKit.LadyInDark");
        }
    }
}

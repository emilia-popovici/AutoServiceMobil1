using Android;
using Android.App;
using Android.Content.PM;
using Android.OS;

namespace AutoServiceMobil;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        if (Build.VERSION.SdkInt >= BuildVersionCodes.Tiramisu)
        {
            if (CheckSelfPermission(Manifest.Permission.PostNotifications) != Permission.Granted)
            {
                RequestPermissions(new[] { Manifest.Permission.PostNotifications }, 1001);
            }
        }
    }
}
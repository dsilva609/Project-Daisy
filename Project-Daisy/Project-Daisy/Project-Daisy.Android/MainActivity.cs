using Android.App;
using Android.Content.PM;
using Android.OS;
using Project_Daisy.Droid.Services;

namespace Project_Daisy.Droid
{
    [Activity(Label = "Project_Daisy", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            App.CreateItemService = () => new ItemService();

            LoadApplication(new App());
        }
    }
}
using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Widget;

namespace LoginScreen
{
    [Activity(Label = "BottomNavigationView", Theme = "@style/AppTheme")]
    public class BottomNavigationViewActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.bottomNavigationViewUi);

            var bottomNavigation = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation);
            var imageView = FindViewById<ImageView>(Resource.Id.imageView1);

            bottomNavigation.NavigationItemSelected += (s, e) =>
            {
                switch (e.Item.ItemId)
                {
                    case Resource.Id.menu_home:
                        Toast.MakeText(this, "1st", ToastLength.Short).Show();
                        break;
                    case Resource.Id.menu_audio:
                        Toast.MakeText(this, "2nd", ToastLength.Short).Show();
                        imageView.SetImageResource(Resource.Drawable.number1_min);
                        break;
                    case Resource.Id.menu_video:
                        Toast.MakeText(this, "3rd", ToastLength.Short).Show();
                        imageView.SetImageDrawable(null);
                        break;
                }
            };
        }
    }
}
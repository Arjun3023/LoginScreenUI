using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace LoginScreen
{
    [Activity(Label = "Options", Theme = "@style/AppTheme")]
    public class Options : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Options);

            var listViewButton = FindViewById<Button>(Resource.Id.button1);
            listViewButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(ListViewActivity));
                StartActivity(intent);
            };

            var bottomNavigationButton = FindViewById<Button>(Resource.Id.button2);
            bottomNavigationButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(BottomNavigationViewActivity));
                StartActivity(intent);
            };

            var pagerSlidingTabButton = FindViewById<Button>(Resource.Id.button3);
            pagerSlidingTabButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(PagerSlidingTabStripActivity));
                StartActivity(intent);
            };

            var logoutButton = FindViewById<Button>(Resource.Id.button4);
            logoutButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };

        }
    }
}
using Android.App;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Support.V7.App;
using com.refractored;
using Java.Lang;
using Fragment = Android.Support.V4.App.Fragment;
using FragmentManager = Android.Support.V4.App.FragmentManager;

namespace LoginScreen
{
    [Activity(Label = "pagerSlidingTabStripActivity",Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class PagerSlidingTabStripActivity : AppCompatActivity
    {
        private MyAdapter _myAdapter;
        private PagerSlidingTabStrip _tabs;
        private ViewPager _pager;

        public PagerSlidingTabStripActivity()
        {}
        public PagerSlidingTabStripActivity(MyAdapter myAdapter, ViewPager pager, PagerSlidingTabStrip tabs)
        {
            this._myAdapter = myAdapter;
            _pager = pager;
            this._tabs = tabs;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.pagerSlidingTabStripUi);
            // Create your application here
            _myAdapter = new MyAdapter(SupportFragmentManager);
            _pager = FindViewById<ViewPager>(Resource.Id.pager);
            _tabs = FindViewById<PagerSlidingTabStrip>(Resource.Id.tabs);
            _pager.Adapter = _myAdapter;
            _tabs.SetViewPager(_pager);
            _tabs.SetBackgroundColor(Android.Graphics.Color.Argb(255,0,149,164));
        }

        public class MyAdapter : FragmentPagerAdapter
        {
            private int tabCount = 3;

            public MyAdapter(FragmentManager fm) : base(fm)
            {

            }

            public override int Count
            {
                get { return tabCount; }
            }

            public override ICharSequence GetPageTitleFormatted(int position)
            {
                ICharSequence cs;
                if(position == 0)
                    cs = new Java.Lang.String("Android");
                else if(position == 1)
                    cs = new Java.Lang.String("iOS");
                else
                    cs = new Java.Lang.String("NOT");
                return cs;
            }

            public override Fragment GetItem(int position)
            {
                return ContentFragment.NewInstance(position);
            }
        }
    }
}
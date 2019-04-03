using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace LoginScreen
{
    [Activity(Label = "ListViewActivity")]
    public class ListViewActivity : Activity
    {
        private List<string> _mList;
        private ListView _mListView;

        public ListViewActivity() { }

        public ListViewActivity(List<string> mList, ListView mListView)
        {
            _mList = mList;
            _mListView = mListView;
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ListViewUi);

            _mList = new List<string> { "One", "Two", "Three" };
            _mListView = FindViewById<ListView>(Resource.Id.listView1);

            var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, _mList);
            _mListView.Adapter = adapter;

            var button = FindViewById<Button>(Resource.Id.button1);
            button.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Options));
                StartActivity(intent);
            };
        }
    }
}
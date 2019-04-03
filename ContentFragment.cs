using Android.OS;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;

namespace LoginScreen
{
    public class ContentFragment : Fragment
    {
        private int _position;

        public ContentFragment()
        {}

        public ContentFragment(int position)
        {
            _position = position;
        }

        public static ContentFragment NewInstance(int position)
        {
            var f= new ContentFragment();
            var b = new Bundle();
            b.PutInt("position",position);
            f.Arguments = b;
            return f;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            _position = Arguments.GetInt("position");
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var root = inflater.Inflate(Resource.Layout.fragment, container, false);
            var text = root.FindViewById<TextView>(Resource.Id.textView);

            if (_position == 0)
                text.Text = "Page Android";
            else if (_position == 1)
                text.Text = "Page iOS";
            else
                text.Text = "None of these";
            ViewCompat.SetElevation(root,50);
            return root;
        }
    }
}
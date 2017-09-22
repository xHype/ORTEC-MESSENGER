using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;

namespace MVVM.Droid.Views
{
    [Activity(Label = "Main Activity", Theme = "@style/ORTECMessenger")]
    public class MainView : MvxActivity
    {
        Fragment[] _fragments = { new TempFragment(), new TempFragment() };
        string[] _titles = { "My List", "My Settings" };
        ActionBarDrawerToggle _drawerToggle;
        ListView _drawerListView;
        DrawerLayout _drawerLayout;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = "ORTEC Messenger";
            _drawerListView = FindViewById<ListView>(Resource.Id.drawerListView);
            _drawerListView.ItemClick += (s, e) => ShowFragmentAt(e.Position);
            _drawerListView.Adapter = new ArrayAdapter<string>(
                this,
                global::Android.Resource.Layout.SimpleListItem1,
                _titles);
            _drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawerLayout);
            _drawerToggle = new ActionBarDrawerToggle(
                this,
                _drawerLayout,
                1,
                0);
            _drawerLayout.SetDrawerListener(_drawerToggle);
            ShowFragmentAt(0);
        }
        void ShowFragmentAt(int position)
        {
            FragmentManager
                .BeginTransaction()
                .Replace(Resource.Id.frameLayout, _fragments[position])
                .Commit();
            Title = _titles[position];
            _drawerLayout.CloseDrawer(_drawerListView);
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.top_menus, menu);
            return base.OnCreateOptionsMenu(menu);
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (_drawerToggle.OnOptionsItemSelected(item))
                return true;
            Toast.MakeText(this, "Action selected: " + item.TitleFormatted, ToastLength.Short).Show();
            return base.OnOptionsItemSelected(item);
        }
    }
}

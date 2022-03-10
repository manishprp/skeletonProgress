using Android.App;
using Android.OS;
using Android.Runtime;
using Supercharge;
using AndroidX.AppCompat.App;

namespace skeletonProgress
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity        
    {
       ShimmerLayout shimmerLayout;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            shimmerLayout = FindViewById<ShimmerLayout>(Resource.Id.shimmerLayout);
          shimmerLayout.StartShimmerAnimation();


        }

    }
}
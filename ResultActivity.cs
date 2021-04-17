
using Android.App;
using Android.OS;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace CalculatorApp
{
    [Activity(Label = "ResultActivity", ParentActivity = typeof(MainActivity))]
    public class ResultActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_result);
            // Create your application here

            var result = Intent.GetIntExtra("result", 0);

        }
    }
}


using Android.App;
using Android.OS;
using AndroidX.AppCompat.App;

namespace CalculatorApp
{
    [Activity(Label = "ResultActivity")]
    public class ResultActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_result);
            // Create your application here
        }
    }
}

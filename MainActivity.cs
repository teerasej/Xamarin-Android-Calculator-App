using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace CalculatorApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var inputFirst = FindViewById<EditText>(Resource.Id.inputFirst);
            var inputSecond = FindViewById<EditText>(Resource.Id.inputSecond);
            var buttonCalcualte = FindViewById<Button>(Resource.Id.button_calculate);

            buttonCalcualte.Click += (sender, e) =>
            {
                var first = inputFirst.Text;
                var second = inputSecond.Text;
                Toast toast;

                if (string.IsNullOrEmpty(first) || string.IsNullOrEmpty(second))
                {
                    toast = Toast.MakeText(Application.Context, "ข้อมูลยังกรอกไม่ครบ", ToastLength.Short);
                    toast.Show();
                    return;
                }

                try
                {
                    var firstNum = int.Parse(first);
                    var secondNum = int.Parse(second);

                    var result = firstNum + secondNum;

                    //toast = Toast.MakeText(Application.Context, "ผลลัพธ์: " + result.ToString(), ToastLength.Short);
                    //toast.Show();

                    Intent intent = new Intent(this, typeof(ResultActivity));
                    intent.PutExtra("result", result);
                    StartActivity(intent);

                }
                catch (System.Exception ex)
                {
                    toast = Toast.MakeText(Application.Context, "ข้อมูลไม่สามารถนำมาคำนวนได้", ToastLength.Short);
                    toast.Show();
                    return;
                }

              

            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
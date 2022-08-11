using Android.App;
using Android.Widget;
using Android.OS;

namespace calculadora1
{
    [Activity(Label = "EjemploCalculadora", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button b1 = FindViewById<Button>(Resource.Id.button1);
            b1.Click += Suma;

            Button b2 = FindViewById<Button>(Resource.Id.button2);
            b2.Click += Resta;

            Button b3 = FindViewById<Button>(Resource.Id.button3);
            b3.Click += Producto;

            Button b4 = FindViewById<Button>(Resource.Id.button4);
            b4.Click += Division;
        }

        //Handles click
        private void Suma(object sender, System.EventArgs e)
        {
            EditText input1 = FindViewById<EditText>(Resource.Id.editText1);
            EditText input2 = FindViewById<EditText>(Resource.Id.editText2);
            TextView result = FindViewById<TextView>(Resource.Id.textView3);

            result.Text = (int.Parse(input1.Text) + int.Parse(input2.Text)).ToString();
        }
        private void Resta(object sender, System.EventArgs e)
        {
            EditText input1 = FindViewById<EditText>(Resource.Id.editText1);
            EditText input2 = FindViewById<EditText>(Resource.Id.editText2);
            TextView result = FindViewById<TextView>(Resource.Id.textView3);

            result.Text = (int.Parse(input1.Text) - int.Parse(input2.Text)).ToString();
        }

        private void Producto(object sender, System.EventArgs e)
        {
            EditText input1 = FindViewById<EditText>(Resource.Id.editText1);
            EditText input2 = FindViewById<EditText>(Resource.Id.editText2);
            TextView result = FindViewById<TextView>(Resource.Id.textView3);

            result.Text = (int.Parse(input1.Text) * int.Parse(input2.Text)).ToString();
        }

        private void Division(object sender, System.EventArgs e)
        {
            EditText input1 = FindViewById<EditText>(Resource.Id.editText1);
            EditText input2 = FindViewById<EditText>(Resource.Id.editText2);
            TextView result = FindViewById<TextView>(Resource.Id.textView3);

            result.Text = (int.Parse(input1.Text) / int.Parse(input2.Text)).ToString();
        }
    }


}
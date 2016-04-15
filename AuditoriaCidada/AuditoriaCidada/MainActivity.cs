using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace AuditoriaCidada
{
	[Activity (Label = "AuditoriaCidada", MainLauncher = true, Theme="@android:style/Theme.NoTitleBar")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);


            Toast.MakeText(this.ApplicationContext,"Instruções de Teste: Clique no botão [Entrar] para ter acesso a tela principal.", ToastLength.Long).Show();


            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button> (Resource.Id.btnEntrar);

      
			button.Click += delegate {

                var intent = new Intent(this, typeof(Principal));

                StartActivity(intent);

              

            };
		}
	}
}



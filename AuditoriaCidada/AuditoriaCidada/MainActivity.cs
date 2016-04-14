using Android.App;
using Android.Widget;
using Android.OS;

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

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.btnEntrar);
		


			button.Click += delegate {
				
			};
		}
	}
}



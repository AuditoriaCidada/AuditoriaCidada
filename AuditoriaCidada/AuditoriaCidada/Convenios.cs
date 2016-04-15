using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AuditoriaCidada
{
    [Activity(Label = "Convenios")]
    public class Convenios : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Convenios);


            // Get our button from the layout resource,
            // and attach an event to it
            ImageButton imbconvenio1 = FindViewById<ImageButton>(Resource.Id.Convenios_imbConvenio1);

            // and attach an event to it
            ImageButton imbconvenio2 = FindViewById<ImageButton>(Resource.Id.Convenios_imbConvenio2);


            Toast.MakeText(this.ApplicationContext, "Instruções de Teste: Clique em um dos convênios para simular o processo de auditoria.", ToastLength.Long).Show();


            imbconvenio1.Click += delegate {

                Util.VisitaMarcada = true;

                Toast.MakeText(this.ApplicationContext, $"A visita de sua auditoria foi marcada para {DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")} ", ToastLength.Long).Show();



                var intent = new Intent(this, typeof(Principal));

                StartActivity(intent);

            };

            imbconvenio2.Click += delegate {

                Util.VisitaMarcada = true;

                Toast.MakeText(this.ApplicationContext, $"A visita de sua auditoria foi marcada para {DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")} ", ToastLength.Long).Show();

                var intent = new Intent(this, typeof(Principal));

                StartActivity(intent);

            };
        }
    }
}
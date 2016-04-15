
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
	[Activity (Label = "Principal")]			
	public class Principal : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Principal);

            ImageView imbNovaAuditoria = FindViewById<ImageView>(Resource.Id.imbNovaAuditoria);

            ImageView Principal_menuPrincipal = FindViewById<ImageView>(Resource.Id.Principal_menu);

            Toast.MakeText(this.ApplicationContext, "Instruções de Teste: Clique no botão [ + ] para simular a pesquisa entre os convênios.", ToastLength.Long).Show();

            if (Util.VisitaMarcada)
            {
                Toast.MakeText(this.ApplicationContext, "Instruções de Teste:Clique no Badge acima para ter acesso ao protótipo do roteiro.", ToastLength.Long).Show();
            }

            imbNovaAuditoria.Click += delegate
            {

                StartActivity(new Intent(this, typeof(Convenios)));

            };



            Principal_menuPrincipal.Click += delegate
            {

                if (Util.VisitaMarcada)
                {
                    StartActivity(new Intent(this, typeof(Roteiro)));
                }

            };
           

            // Create your application here
        }

    }
}


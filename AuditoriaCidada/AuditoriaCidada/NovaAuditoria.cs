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
    [Activity(Label = "NovaAuditoria")]
    public class NovaAuditoria : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.NovaAuditoria);
            // Create your application here

            ImageView imgView = FindViewById<ImageView>(Resource.Id.NovaAuditoria_imbRoteiro);

            imgView.Click += delegate
            {
                var intent = new Intent(this, typeof(Convenios));
                StartActivity(intent);
            };
        }
    }
}
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
using SqlEx;
using SqlEx.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(RoundedEntry), typeof(RoundedEntryImpl))]
namespace SqlEx.Droid
{
    [Obsolete]
    class RoundedEntryImpl : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            Control.Background = Resources.GetDrawable(Resource.Drawable.test);

            //Control.Background = Android.App.Application.Context.GetDrawable(Resource.Drawable.rounded_entry);
        }
    }
}
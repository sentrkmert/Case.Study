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
using GA.CaseStudy.Custom;
using GA.CaseStudy.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(LoginEntry), typeof(LoginEntryRenderer))]
namespace GA.CaseStudy.Droid.Renderer
{
    public class LoginEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = this.Resources.GetDrawable(Resource.Drawable.LoginEntry);
                Control.InputType = Android.Text.InputTypes.TextFlagNoSuggestions;
                Control.Text.ToUpper();
            }

            if (e.NewElement.IsPassword) { Control.TransformationMethod = new Android.Text.Method.PasswordTransformationMethod(); }
            if (e.NewElement.Keyboard == Keyboard.Numeric) { Control.SetRawInputType(Android.Text.InputTypes.ClassNumber | Android.Text.InputTypes.NumberFlagSigned | Android.Text.InputTypes.NumberVariationPassword); }
        }
    }
         
    }

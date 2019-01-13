using System;
using GA.CaseStudy.Custom;
using GA.CaseStudy.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(UnderlineLbl), typeof(UnderlineLblRenderer))]
namespace GA.CaseStudy.Droid.Renderer
{
    public class UnderlineLblRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            try
            {
                base.OnElementChanged(e);
                if (Control != null)
                {
                    Control.PaintFlags = Android.Graphics.PaintFlags.UnderlineText;
                }
            }
            catch (Exception ex)
            {
               throw ex;
            }
            
        }
    }
}
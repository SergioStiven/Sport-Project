﻿using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Xpinn.SportsGo.Movil.iOS.Renderers;

[assembly: ExportRenderer(typeof(Editor), typeof(BorderedEditorRenderer))]
namespace Xpinn.SportsGo.Movil.iOS.Renderers
{
    [Foundation.Preserve(AllMembers = true)]
    public class BorderedEditorRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Layer.CornerRadius = 3;
                Control.Layer.BorderColor = Color.FromHex("F0F0F0").ToCGColor();
                Control.Layer.BorderWidth = 2;
            }
        }
    }
}
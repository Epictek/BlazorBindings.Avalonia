// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.Maui;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public abstract partial class View : VisualElement
    {
        static View()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public MC.LayoutOptions? HorizontalOptions { get; set; }
        [Parameter] public Thickness? Margin { get; set; }
        [Parameter] public MC.LayoutOptions? VerticalOptions { get; set; }

        public new MC.View NativeControl => (MC.View)((Element)this).NativeControl;


        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(HorizontalOptions):
                    if (!Equals(HorizontalOptions, value))
                    {
                        HorizontalOptions = (MC.LayoutOptions?)value;
                        NativeControl.HorizontalOptions = HorizontalOptions ?? (MC.LayoutOptions)MC.View.HorizontalOptionsProperty.DefaultValue;
                    }
                    break;
                case nameof(Margin):
                    if (!Equals(Margin, value))
                    {
                        Margin = (Thickness?)value;
                        NativeControl.Margin = Margin ?? (Thickness)MC.View.MarginProperty.DefaultValue;
                    }
                    break;
                case nameof(VerticalOptions):
                    if (!Equals(VerticalOptions, value))
                    {
                        VerticalOptions = (MC.LayoutOptions?)value;
                        NativeControl.VerticalOptions = VerticalOptions ?? (MC.LayoutOptions)MC.View.VerticalOptionsProperty.DefaultValue;
                    }
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        static partial void RegisterAdditionalHandlers();
    }
}
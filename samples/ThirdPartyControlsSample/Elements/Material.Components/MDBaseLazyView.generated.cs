// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using BlazorBindings.Maui.Elements;
using MC = Microsoft.Maui.Controls;
using MCM = Material.Components.Maui;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

#pragma warning disable CA2252

namespace BlazorBindings.Maui.Elements.Material.Components
{
    public abstract partial class MDBaseLazyView : BlazorBindings.Maui.Elements.ContentView
    {
        static MDBaseLazyView()
        {
            RegisterAdditionalHandlers();
        }

        public new MCM.BaseLazyView NativeControl => (MCM.BaseLazyView)((BindableObject)this).NativeControl;



        static partial void RegisterAdditionalHandlers();
    }
}
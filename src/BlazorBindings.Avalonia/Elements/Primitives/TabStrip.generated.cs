// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using ACP = Avalonia.Controls.Primitives;
using BlazorBindings.AvaloniaBindings.Elements;

#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements.Primitives
{
    public partial class TabStrip<T> : SelectingItemsControl<T>
    {
        static TabStrip()
        {
            RegisterAdditionalHandlers();
        }

        public new ACP.TabStrip NativeControl => (ACP.TabStrip)((BindableObject)this).NativeControl;

        protected override ACP.TabStrip CreateNativeElement() => new();


        static partial void RegisterAdditionalHandlers();
    }
}

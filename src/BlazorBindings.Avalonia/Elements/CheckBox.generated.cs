// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>


using BlazorBindings.Avalonia.Elements.Primitives;

#pragma warning disable CA2252

namespace BlazorBindings.Avalonia.Elements
{
    /// <summary>
    /// A check box control.
    /// </summary>
    public partial class CheckBox : ToggleButton
    {
        static CheckBox()
        {
            RegisterAdditionalHandlers();
        }

        public new AC.CheckBox NativeControl => (AC.CheckBox)((AvaloniaObject)this).NativeControl;

        protected override AC.CheckBox CreateNativeElement() => new();


        static partial void RegisterAdditionalHandlers();
    }
}

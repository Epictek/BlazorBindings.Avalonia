// <auto-generated>
//     This code was generated by a BlazorBindingsAvalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>



#pragma warning disable CA2252

namespace BlazorBindingsAvalonia.Elements
{
    /// <summary>
    /// A check box control.
    /// </summary>
    public partial class CheckBox : BlazorBindingsAvalonia.Elements.Primitives.ToggleButton
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
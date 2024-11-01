// <auto-generated>
//     This code was generated by a BlazorBindingsAvalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using AL = Avalonia.Layout;
using BlazorBindingsAvalonia.Elements;

#pragma warning disable CA2252

namespace BlazorBindingsAvalonia.Elements.Layout
{
    /// <summary>
    /// Arranges elements into a single line (with spacing) that can be oriented horizontally or vertically.
    /// </summary>
    public partial class StackLayout : VirtualizingLayout
    {
        static StackLayout()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets a value indicating whether virtualization is disabled on the layout.
        /// </summary>
        [Parameter] public bool? DisableVirtualization { get; set; }
        /// <summary>
        /// Gets or sets the axis along which items are laid out.
        /// </summary>
        /// <value>
        /// One of the enumeration values that specifies the axis along which items are laid out. The default is Vertical.
        /// </value>
        [Parameter] public AL.Orientation? Orientation { get; set; }
        /// <summary>
        /// Gets or sets a uniform distance (in pixels) between stacked items. It is applied in the direction of the StackLayout's Orientation.
        /// </summary>
        [Parameter] public double? Spacing { get; set; }

        public new AL.StackLayout NativeControl => (AL.StackLayout)((AvaloniaObject)this).NativeControl;

        protected override AL.StackLayout CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(DisableVirtualization):
                    if (!Equals(DisableVirtualization, value))
                    {
                        DisableVirtualization = (bool?)value;
                        NativeControl.DisableVirtualization = DisableVirtualization ?? (bool)AL.StackLayout.DisableVirtualizationProperty.GetDefaultValue(AL.StackLayout.DisableVirtualizationProperty.OwnerType);
                    }
                    break;
                case nameof(Orientation):
                    if (!Equals(Orientation, value))
                    {
                        Orientation = (AL.Orientation?)value;
                        NativeControl.Orientation = Orientation ?? (AL.Orientation)AL.StackLayout.OrientationProperty.GetDefaultValue(AL.StackLayout.OrientationProperty.OwnerType);
                    }
                    break;
                case nameof(Spacing):
                    if (!Equals(Spacing, value))
                    {
                        Spacing = (double?)value;
                        NativeControl.Spacing = Spacing ?? (double)AL.StackLayout.SpacingProperty.GetDefaultValue(AL.StackLayout.SpacingProperty.OwnerType);
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
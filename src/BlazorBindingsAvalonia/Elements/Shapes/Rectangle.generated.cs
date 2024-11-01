// <auto-generated>
//     This code was generated by a BlazorBindingsAvalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using ACS = Avalonia.Controls.Shapes;
using BlazorBindingsAvalonia.Elements;

#pragma warning disable CA2252

namespace BlazorBindingsAvalonia.Elements.Shapes
{
    /// <summary>
    /// Represents a rectangle with optional rounded corners.
    /// </summary>
    public partial class Rectangle : Shape
    {
        static Rectangle()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public double? RadiusX { get; set; }
        [Parameter] public double? RadiusY { get; set; }

        public new ACS.Rectangle NativeControl => (ACS.Rectangle)((AvaloniaObject)this).NativeControl;

        protected override ACS.Rectangle CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(RadiusX):
                    if (!Equals(RadiusX, value))
                    {
                        RadiusX = (double?)value;
                        NativeControl.RadiusX = RadiusX ?? (double)ACS.Rectangle.RadiusXProperty.GetDefaultValue(ACS.Rectangle.RadiusXProperty.OwnerType);
                    }
                    break;
                case nameof(RadiusY):
                    if (!Equals(RadiusY, value))
                    {
                        RadiusY = (double?)value;
                        NativeControl.RadiusY = RadiusY ?? (double)ACS.Rectangle.RadiusYProperty.GetDefaultValue(ACS.Rectangle.RadiusYProperty.OwnerType);
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
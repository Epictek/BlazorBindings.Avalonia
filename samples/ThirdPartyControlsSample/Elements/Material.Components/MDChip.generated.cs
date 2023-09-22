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
using Microsoft.Maui.Graphics;
using System;
using System.Threading.Tasks;

#pragma warning disable CA2252

namespace BlazorBindings.Maui.Elements.Material.Components
{
    public partial class MDChip : SKTouchCanvasView
    {
        static MDChip()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public Color BackgroundColour { get; set; }
        [Parameter] public MCM.Tokens.Elevation? Elevation { get; set; }
        [Parameter] public string FontFamily { get; set; }
        [Parameter] public bool? FontItalic { get; set; }
        [Parameter] public float? FontSize { get; set; }
        [Parameter] public int? FontWeight { get; set; }
        [Parameter] public Color ForegroundColor { get; set; }
        [Parameter] public bool? HasCloseIcon { get; set; }
        [Parameter] public Color IconColor { get; set; }
        [Parameter] public string IconData { get; set; }
        [Parameter] public global::IconPacks.Material.IconKind? IconKind { get; set; }
        [Parameter] public global::SkiaSharp.SKPicture IconSource { get; set; }
        [Parameter] public bool? IsChecked { get; set; }
        [Parameter] public Color OutlineColor { get; set; }
        [Parameter] public int? OutlineWidth { get; set; }
        [Parameter] public Color RippleColor { get; set; }
        [Parameter] public MCM.Tokens.Shape? Shape { get; set; }
        [Parameter] public Color StateLayerColor { get; set; }
        [Parameter] public string Text { get; set; }
        [Parameter] public EventCallback<bool> IsCheckedChanged { get; set; }
        [Parameter] public EventCallback OnClosed { get; set; }

        public new MCM.Chip NativeControl => (MCM.Chip)((BindableObject)this).NativeControl;

        protected override MCM.Chip CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(BackgroundColour):
                    if (!Equals(BackgroundColour, value))
                    {
                        BackgroundColour = (Color)value;
                        NativeControl.BackgroundColour = BackgroundColour;
                    }
                    break;
                case nameof(Elevation):
                    if (!Equals(Elevation, value))
                    {
                        Elevation = (MCM.Tokens.Elevation?)value;
                        NativeControl.Elevation = Elevation ?? (MCM.Tokens.Elevation)MCM.Chip.ElevationProperty.DefaultValue;
                    }
                    break;
                case nameof(FontFamily):
                    if (!Equals(FontFamily, value))
                    {
                        FontFamily = (string)value;
                        NativeControl.FontFamily = FontFamily;
                    }
                    break;
                case nameof(FontItalic):
                    if (!Equals(FontItalic, value))
                    {
                        FontItalic = (bool?)value;
                        NativeControl.FontItalic = FontItalic ?? (bool)MCM.Chip.FontItalicProperty.DefaultValue;
                    }
                    break;
                case nameof(FontSize):
                    if (!Equals(FontSize, value))
                    {
                        FontSize = (float?)value;
                        NativeControl.FontSize = FontSize ?? (float)MCM.Chip.FontSizeProperty.DefaultValue;
                    }
                    break;
                case nameof(FontWeight):
                    if (!Equals(FontWeight, value))
                    {
                        FontWeight = (int?)value;
                        NativeControl.FontWeight = FontWeight ?? (int)MCM.Chip.FontWeightProperty.DefaultValue;
                    }
                    break;
                case nameof(ForegroundColor):
                    if (!Equals(ForegroundColor, value))
                    {
                        ForegroundColor = (Color)value;
                        NativeControl.ForegroundColor = ForegroundColor;
                    }
                    break;
                case nameof(HasCloseIcon):
                    if (!Equals(HasCloseIcon, value))
                    {
                        HasCloseIcon = (bool?)value;
                        NativeControl.HasCloseIcon = HasCloseIcon ?? (bool)MCM.Chip.HasCloseIconProperty.DefaultValue;
                    }
                    break;
                case nameof(IconColor):
                    if (!Equals(IconColor, value))
                    {
                        IconColor = (Color)value;
                        NativeControl.IconColor = IconColor;
                    }
                    break;
                case nameof(IconData):
                    if (!Equals(IconData, value))
                    {
                        IconData = (string)value;
                        NativeControl.IconData = IconData;
                    }
                    break;
                case nameof(IconKind):
                    if (!Equals(IconKind, value))
                    {
                        IconKind = (global::IconPacks.Material.IconKind?)value;
                        NativeControl.IconKind = IconKind ?? (global::IconPacks.Material.IconKind)MCM.Chip.IconKindProperty.DefaultValue;
                    }
                    break;
                case nameof(IconSource):
                    if (!Equals(IconSource, value))
                    {
                        IconSource = (global::SkiaSharp.SKPicture)value;
                        NativeControl.IconSource = IconSource;
                    }
                    break;
                case nameof(IsChecked):
                    if (!Equals(IsChecked, value))
                    {
                        IsChecked = (bool?)value;
                        NativeControl.IsChecked = IsChecked ?? (bool)MCM.Chip.IsCheckedProperty.DefaultValue;
                    }
                    break;
                case nameof(OutlineColor):
                    if (!Equals(OutlineColor, value))
                    {
                        OutlineColor = (Color)value;
                        NativeControl.OutlineColor = OutlineColor;
                    }
                    break;
                case nameof(OutlineWidth):
                    if (!Equals(OutlineWidth, value))
                    {
                        OutlineWidth = (int?)value;
                        NativeControl.OutlineWidth = OutlineWidth ?? (int)MCM.Chip.OutlineWidthProperty.DefaultValue;
                    }
                    break;
                case nameof(RippleColor):
                    if (!Equals(RippleColor, value))
                    {
                        RippleColor = (Color)value;
                        NativeControl.RippleColor = RippleColor;
                    }
                    break;
                case nameof(Shape):
                    if (!Equals(Shape, value))
                    {
                        Shape = (MCM.Tokens.Shape?)value;
                        NativeControl.Shape = Shape ?? (MCM.Tokens.Shape)MCM.Chip.ShapeProperty.DefaultValue;
                    }
                    break;
                case nameof(StateLayerColor):
                    if (!Equals(StateLayerColor, value))
                    {
                        StateLayerColor = (Color)value;
                        NativeControl.StateLayerColor = StateLayerColor;
                    }
                    break;
                case nameof(Text):
                    if (!Equals(Text, value))
                    {
                        Text = (string)value;
                        NativeControl.Text = Text;
                    }
                    break;
                case nameof(IsCheckedChanged):
                    if (!Equals(IsCheckedChanged, value))
                    {
                        void NativeControlCheckedChanged(object sender, MC.CheckedChangedEventArgs e)
                        {
                            var value = NativeControl.IsChecked;
                            IsChecked = value;
                            InvokeEventCallback(IsCheckedChanged, value);
                        }

                        IsCheckedChanged = (EventCallback<bool>)value;
                        NativeControl.CheckedChanged -= NativeControlCheckedChanged;
                        NativeControl.CheckedChanged += NativeControlCheckedChanged;
                    }
                    break;
                case nameof(OnClosed):
                    if (!Equals(OnClosed, value))
                    {
                        void NativeControlClosed(object sender, EventArgs e) => InvokeEventCallback(OnClosed);

                        OnClosed = (EventCallback)value;
                        NativeControl.Closed -= NativeControlClosed;
                        NativeControl.Closed += NativeControlClosed;
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
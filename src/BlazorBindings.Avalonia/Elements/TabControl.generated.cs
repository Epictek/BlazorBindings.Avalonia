// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using Microsoft.AspNetCore.Components.Rendering;

#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements
{
    /// <summary>
    /// A tab control that displays a tab strip along with the content of the selected tab.
    /// </summary>
    public partial class TabControl<T> : BlazorBindings.AvaloniaBindings.Elements.Primitives.SelectingItemsControl<T>
    {
        static TabControl()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets the horizontal alignment of the content within the control.
        /// </summary>
        [Parameter] public global::Avalonia.Layout.HorizontalAlignment? HorizontalContentAlignment { get; set; }
        /// <summary>
        /// Gets or sets the tabstrip placement of the TabControl.
        /// </summary>
        [Parameter] public AC.Dock? TabStripPlacement { get; set; }
        /// <summary>
        /// Gets or sets the vertical alignment of the content within the control.
        /// </summary>
        [Parameter] public global::Avalonia.Layout.VerticalAlignment? VerticalContentAlignment { get; set; }
        /// <summary>
        /// Gets or sets the default data template used to display the content of the selected tab.
        /// </summary>
        [Parameter] public RenderFragment ContentTemplate { get; set; }

        public new AC.TabControl NativeControl => (AC.TabControl)((BindableObject)this).NativeControl;

        protected override AC.TabControl CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(HorizontalContentAlignment):
                    if (!Equals(HorizontalContentAlignment, value))
                    {
                        HorizontalContentAlignment = (global::Avalonia.Layout.HorizontalAlignment?)value;
                        NativeControl.HorizontalContentAlignment = HorizontalContentAlignment ?? (global::Avalonia.Layout.HorizontalAlignment)AC.TabControl.HorizontalContentAlignmentProperty.GetDefaultValue(AC.TabControl.HorizontalContentAlignmentProperty.OwnerType);
                    }
                    break;
                case nameof(TabStripPlacement):
                    if (!Equals(TabStripPlacement, value))
                    {
                        TabStripPlacement = (AC.Dock?)value;
                        NativeControl.TabStripPlacement = TabStripPlacement ?? (AC.Dock)AC.TabControl.TabStripPlacementProperty.GetDefaultValue(AC.TabControl.TabStripPlacementProperty.OwnerType);
                    }
                    break;
                case nameof(VerticalContentAlignment):
                    if (!Equals(VerticalContentAlignment, value))
                    {
                        VerticalContentAlignment = (global::Avalonia.Layout.VerticalAlignment?)value;
                        NativeControl.VerticalContentAlignment = VerticalContentAlignment ?? (global::Avalonia.Layout.VerticalAlignment)AC.TabControl.VerticalContentAlignmentProperty.GetDefaultValue(AC.TabControl.VerticalContentAlignmentProperty.OwnerType);
                    }
                    break;
                case nameof(ContentTemplate):
                    ContentTemplate = (RenderFragment)value;
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        protected override void RenderAdditionalElementContent(RenderTreeBuilder builder, ref int sequence)
        {
            base.RenderAdditionalElementContent(builder, ref sequence);
            RenderTreeBuilderHelper.AddDataTemplateProperty<AC.TabControl>(builder, sequence++, ContentTemplate,
                (nativeControl, nativeTemplate) => nativeControl.ContentTemplate = nativeTemplate);
        }

        static partial void RegisterAdditionalHandlers();
    }
}

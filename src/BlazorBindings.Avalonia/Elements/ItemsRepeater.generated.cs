// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using Microsoft.AspNetCore.Components.Rendering;
using System.Collections;

#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements
{
    /// <summary>
    /// Represents a data-driven collection control that incorporates a flexible layout system, custom views, and virtualization.
    /// </summary>
    public partial class ItemsRepeater : Panel
    {
        static ItemsRepeater()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets a value that indicates the size of the buffer used to realize items when panning or scrolling horizontally.
        /// </summary>
        [Parameter] public double? HorizontalCacheLength { get; set; }
        /// <summary>
        /// Gets or sets an object source used to generate the content of the ItemsRepeater.
        /// </summary>
        [Parameter] public IEnumerable ItemsSource { get; set; }
        /// <summary>
        /// Gets or sets the layout used to size and position elements in the ItemsRepeater.
        /// </summary>
        /// <value>
        /// The layout used to size and position elements. The default is a StackLayout with vertical orientation.
        /// </value>
        [Parameter] public global::Avalonia.Layout.AttachedLayout Layout { get; set; }
        /// <summary>
        /// Gets or sets a value that indicates the size of the buffer used to realize items when panning or scrolling vertically.
        /// </summary>
        [Parameter] public double? VerticalCacheLength { get; set; }
        /// <summary>
        /// Gets or sets the template used to display each item.
        /// </summary>
        [Parameter] public RenderFragment ItemTemplate { get; set; }
        [Parameter] public EventCallback<AC.ItemsRepeaterElementClearingEventArgs> OnElementClearing { get; set; }
        [Parameter] public EventCallback<AC.ItemsRepeaterElementIndexChangedEventArgs> OnElementIndexChanged { get; set; }
        [Parameter] public EventCallback<AC.ItemsRepeaterElementPreparedEventArgs> OnElementPrepared { get; set; }

        public new AC.ItemsRepeater NativeControl => (AC.ItemsRepeater)((BindableObject)this).NativeControl;

        protected override AC.ItemsRepeater CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(HorizontalCacheLength):
                    if (!Equals(HorizontalCacheLength, value))
                    {
                        HorizontalCacheLength = (double?)value;
                        NativeControl.HorizontalCacheLength = HorizontalCacheLength ?? (double)AC.ItemsRepeater.HorizontalCacheLengthProperty.GetDefaultValue(AC.ItemsRepeater.HorizontalCacheLengthProperty.OwnerType);
                    }
                    break;
                case nameof(ItemsSource):
                    if (!Equals(ItemsSource, value))
                    {
                        ItemsSource = (IEnumerable)value;
                        NativeControl.ItemsSource = ItemsSource;
                    }
                    break;
                case nameof(Layout):
                    if (!Equals(Layout, value))
                    {
                        Layout = (global::Avalonia.Layout.AttachedLayout)value;
                        NativeControl.Layout = Layout;
                    }
                    break;
                case nameof(VerticalCacheLength):
                    if (!Equals(VerticalCacheLength, value))
                    {
                        VerticalCacheLength = (double?)value;
                        NativeControl.VerticalCacheLength = VerticalCacheLength ?? (double)AC.ItemsRepeater.VerticalCacheLengthProperty.GetDefaultValue(AC.ItemsRepeater.VerticalCacheLengthProperty.OwnerType);
                    }
                    break;
                case nameof(ItemTemplate):
                    ItemTemplate = (RenderFragment)value;
                    break;
                case nameof(OnElementClearing):
                    if (!Equals(OnElementClearing, value))
                    {
                        void NativeControlElementClearing(object sender, AC.ItemsRepeaterElementClearingEventArgs e) => InvokeEventCallback(OnElementClearing, e);

                        OnElementClearing = (EventCallback<AC.ItemsRepeaterElementClearingEventArgs>)value;
                        NativeControl.ElementClearing -= NativeControlElementClearing;
                        NativeControl.ElementClearing += NativeControlElementClearing;
                    }
                    break;
                case nameof(OnElementIndexChanged):
                    if (!Equals(OnElementIndexChanged, value))
                    {
                        void NativeControlElementIndexChanged(object sender, AC.ItemsRepeaterElementIndexChangedEventArgs e) => InvokeEventCallback(OnElementIndexChanged, e);

                        OnElementIndexChanged = (EventCallback<AC.ItemsRepeaterElementIndexChangedEventArgs>)value;
                        NativeControl.ElementIndexChanged -= NativeControlElementIndexChanged;
                        NativeControl.ElementIndexChanged += NativeControlElementIndexChanged;
                    }
                    break;
                case nameof(OnElementPrepared):
                    if (!Equals(OnElementPrepared, value))
                    {
                        void NativeControlElementPrepared(object sender, AC.ItemsRepeaterElementPreparedEventArgs e) => InvokeEventCallback(OnElementPrepared, e);

                        OnElementPrepared = (EventCallback<AC.ItemsRepeaterElementPreparedEventArgs>)value;
                        NativeControl.ElementPrepared -= NativeControlElementPrepared;
                        NativeControl.ElementPrepared += NativeControlElementPrepared;
                    }
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        protected override void RenderAdditionalElementContent(RenderTreeBuilder builder, ref int sequence)
        {
            base.RenderAdditionalElementContent(builder, ref sequence);
            RenderTreeBuilderHelper.AddDataTemplateProperty<AC.ItemsRepeater>(builder, sequence++, ItemTemplate,
                (nativeControl, nativeTemplate) => nativeControl.ItemTemplate = nativeTemplate);
        }

        static partial void RegisterAdditionalHandlers();
    }
}
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
    /// <summary>
    /// A scrollbar control.
    /// </summary>
    public partial class ScrollBar : RangeBase
    {
        static ScrollBar()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets a value that indicates whether the scrollbar can hide itself when user is not interacting with it.
        /// </summary>
        [Parameter] public bool? AllowAutoHide { get; set; }
        /// <summary>
        /// Gets a value that determines how long will be the hide delay after user stops interacting with the scrollbar.
        /// </summary>
        [Parameter] public TimeSpan? HideDelay { get; set; }
        /// <summary>
        /// Gets or sets the orientation of the scrollbar.
        /// </summary>
        [Parameter] public global::Avalonia.Layout.Orientation? Orientation { get; set; }
        /// <summary>
        /// Gets a value that determines how long will be the show delay when user starts interacting with the scrollbar.
        /// </summary>
        [Parameter] public TimeSpan? ShowDelay { get; set; }
        /// <summary>
        /// Gets or sets the amount of the scrollable content that is currently visible.
        /// </summary>
        [Parameter] public double? ViewportSize { get; set; }
        /// <summary>
        /// Gets or sets a value that indicates whether the scrollbar should hide itself when it is not needed.
        /// </summary>
        [Parameter] public ACP.ScrollBarVisibility? Visibility { get; set; }
        [Parameter] public EventCallback<ACP.ScrollEventArgs> OnScroll { get; set; }

        public new ACP.ScrollBar NativeControl => (ACP.ScrollBar)((BindableObject)this).NativeControl;

        protected override ACP.ScrollBar CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(AllowAutoHide):
                    if (!Equals(AllowAutoHide, value))
                    {
                        AllowAutoHide = (bool?)value;
                        NativeControl.AllowAutoHide = AllowAutoHide ?? (bool)ACP.ScrollBar.AllowAutoHideProperty.GetDefaultValue(ACP.ScrollBar.AllowAutoHideProperty.OwnerType);
                    }
                    break;
                case nameof(HideDelay):
                    if (!Equals(HideDelay, value))
                    {
                        HideDelay = (TimeSpan?)value;
                        NativeControl.HideDelay = HideDelay ?? (TimeSpan)ACP.ScrollBar.HideDelayProperty.GetDefaultValue(ACP.ScrollBar.HideDelayProperty.OwnerType);
                    }
                    break;
                case nameof(Orientation):
                    if (!Equals(Orientation, value))
                    {
                        Orientation = (global::Avalonia.Layout.Orientation?)value;
                        NativeControl.Orientation = Orientation ?? (global::Avalonia.Layout.Orientation)ACP.ScrollBar.OrientationProperty.GetDefaultValue(ACP.ScrollBar.OrientationProperty.OwnerType);
                    }
                    break;
                case nameof(ShowDelay):
                    if (!Equals(ShowDelay, value))
                    {
                        ShowDelay = (TimeSpan?)value;
                        NativeControl.ShowDelay = ShowDelay ?? (TimeSpan)ACP.ScrollBar.ShowDelayProperty.GetDefaultValue(ACP.ScrollBar.ShowDelayProperty.OwnerType);
                    }
                    break;
                case nameof(ViewportSize):
                    if (!Equals(ViewportSize, value))
                    {
                        ViewportSize = (double?)value;
                        NativeControl.ViewportSize = ViewportSize ?? (double)ACP.ScrollBar.ViewportSizeProperty.GetDefaultValue(ACP.ScrollBar.ViewportSizeProperty.OwnerType);
                    }
                    break;
                case nameof(Visibility):
                    if (!Equals(Visibility, value))
                    {
                        Visibility = (ACP.ScrollBarVisibility?)value;
                        NativeControl.Visibility = Visibility ?? (ACP.ScrollBarVisibility)ACP.ScrollBar.VisibilityProperty.GetDefaultValue(ACP.ScrollBar.VisibilityProperty.OwnerType);
                    }
                    break;
                case nameof(OnScroll):
                    if (!Equals(OnScroll, value))
                    {
                        void NativeControlScroll(object sender, ACP.ScrollEventArgs e) => InvokeEventCallback(OnScroll, e);

                        OnScroll = (EventCallback<ACP.ScrollEventArgs>)value;
                        NativeControl.Scroll -= NativeControlScroll;
                        NativeControl.Scroll += NativeControlScroll;
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
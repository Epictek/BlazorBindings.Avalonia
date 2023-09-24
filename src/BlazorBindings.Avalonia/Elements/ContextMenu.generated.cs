// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using System.ComponentModel;

#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements
{
    /// <summary>
    /// A control context menu.
    /// </summary>
    public partial class ContextMenu<T> : MenuBase<T>
    {
        static ContextMenu()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public double? HorizontalOffset { get; set; }
        [Parameter] public AC.PlacementMode? Placement { get; set; }
        [Parameter] public AC.Primitives.PopupPositioning.PopupAnchor? PlacementAnchor { get; set; }
        [Parameter] public AC.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment? PlacementConstraintAdjustment { get; set; }
        [Parameter] public AC.Primitives.PopupPositioning.PopupGravity? PlacementGravity { get; set; }
        [Parameter] public Nullable<global::Avalonia.Rect> PlacementRect { get; set; }
        [Parameter] public AC.Control PlacementTarget { get; set; }
        [Parameter] public double? VerticalOffset { get; set; }
        [Parameter] public bool? WindowManagerAddShadowHint { get; set; }
        [Parameter] public EventCallback<CancelEventArgs> OnOpening { get; set; }
        [Parameter] public EventCallback<CancelEventArgs> OnClosing { get; set; }

        public new AC.ContextMenu NativeControl => (AC.ContextMenu)((BindableObject)this).NativeControl;

        protected override AC.ContextMenu CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(HorizontalOffset):
                    if (!Equals(HorizontalOffset, value))
                    {
                        HorizontalOffset = (double?)value;
                        NativeControl.HorizontalOffset = HorizontalOffset ?? (double)AC.ContextMenu.HorizontalOffsetProperty.GetDefaultValue(AC.ContextMenu.HorizontalOffsetProperty.OwnerType);
                    }
                    break;
                case nameof(Placement):
                    if (!Equals(Placement, value))
                    {
                        Placement = (AC.PlacementMode?)value;
                        NativeControl.Placement = Placement ?? (AC.PlacementMode)AC.ContextMenu.PlacementProperty.GetDefaultValue(AC.ContextMenu.PlacementProperty.OwnerType);
                    }
                    break;
                case nameof(PlacementAnchor):
                    if (!Equals(PlacementAnchor, value))
                    {
                        PlacementAnchor = (AC.Primitives.PopupPositioning.PopupAnchor?)value;
                        NativeControl.PlacementAnchor = PlacementAnchor ?? (AC.Primitives.PopupPositioning.PopupAnchor)AC.ContextMenu.PlacementAnchorProperty.GetDefaultValue(AC.ContextMenu.PlacementAnchorProperty.OwnerType);
                    }
                    break;
                case nameof(PlacementConstraintAdjustment):
                    if (!Equals(PlacementConstraintAdjustment, value))
                    {
                        PlacementConstraintAdjustment = (AC.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment?)value;
                        NativeControl.PlacementConstraintAdjustment = PlacementConstraintAdjustment ?? (AC.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment)AC.ContextMenu.PlacementConstraintAdjustmentProperty.GetDefaultValue(AC.ContextMenu.PlacementConstraintAdjustmentProperty.OwnerType);
                    }
                    break;
                case nameof(PlacementGravity):
                    if (!Equals(PlacementGravity, value))
                    {
                        PlacementGravity = (AC.Primitives.PopupPositioning.PopupGravity?)value;
                        NativeControl.PlacementGravity = PlacementGravity ?? (AC.Primitives.PopupPositioning.PopupGravity)AC.ContextMenu.PlacementGravityProperty.GetDefaultValue(AC.ContextMenu.PlacementGravityProperty.OwnerType);
                    }
                    break;
                case nameof(PlacementRect):
                    if (!Equals(PlacementRect, value))
                    {
                        PlacementRect = (Nullable<global::Avalonia.Rect>)value;
                        NativeControl.PlacementRect = PlacementRect;
                    }
                    break;
                case nameof(PlacementTarget):
                    if (!Equals(PlacementTarget, value))
                    {
                        PlacementTarget = (AC.Control)value;
                        NativeControl.PlacementTarget = PlacementTarget;
                    }
                    break;
                case nameof(VerticalOffset):
                    if (!Equals(VerticalOffset, value))
                    {
                        VerticalOffset = (double?)value;
                        NativeControl.VerticalOffset = VerticalOffset ?? (double)AC.ContextMenu.VerticalOffsetProperty.GetDefaultValue(AC.ContextMenu.VerticalOffsetProperty.OwnerType);
                    }
                    break;
                case nameof(WindowManagerAddShadowHint):
                    if (!Equals(WindowManagerAddShadowHint, value))
                    {
                        WindowManagerAddShadowHint = (bool?)value;
                        NativeControl.WindowManagerAddShadowHint = WindowManagerAddShadowHint ?? (bool)AC.ContextMenu.WindowManagerAddShadowHintProperty.GetDefaultValue(AC.ContextMenu.WindowManagerAddShadowHintProperty.OwnerType);
                    }
                    break;
                case nameof(OnOpening):
                    if (!Equals(OnOpening, value))
                    {
                        void NativeControlOpening(object sender, CancelEventArgs e) => InvokeEventCallback(OnOpening, e);

                        OnOpening = (EventCallback<CancelEventArgs>)value;
                        NativeControl.Opening -= NativeControlOpening;
                        NativeControl.Opening += NativeControlOpening;
                    }
                    break;
                case nameof(OnClosing):
                    if (!Equals(OnClosing, value))
                    {
                        void NativeControlClosing(object sender, CancelEventArgs e) => InvokeEventCallback(OnClosing, e);

                        OnClosing = (EventCallback<CancelEventArgs>)value;
                        NativeControl.Closing -= NativeControlClosing;
                        NativeControl.Closing += NativeControlClosing;
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

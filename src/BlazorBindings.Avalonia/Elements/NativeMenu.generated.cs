// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>



#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements
{
    public partial class NativeMenu : BindableObject
    {
        static NativeMenu()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public EventCallback OnNeedsUpdate { get; set; }
        [Parameter] public EventCallback OnOpening { get; set; }
        [Parameter] public EventCallback OnClosed { get; set; }

        public new AC.NativeMenu NativeControl => (AC.NativeMenu)((BindableObject)this).NativeControl;

        protected override AC.NativeMenu CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(OnNeedsUpdate):
                    if (!Equals(OnNeedsUpdate, value))
                    {
                        void NativeControlNeedsUpdate(object sender, EventArgs e) => InvokeEventCallback(OnNeedsUpdate);

                        OnNeedsUpdate = (EventCallback)value;
                        NativeControl.NeedsUpdate -= NativeControlNeedsUpdate;
                        NativeControl.NeedsUpdate += NativeControlNeedsUpdate;
                    }
                    break;
                case nameof(OnOpening):
                    if (!Equals(OnOpening, value))
                    {
                        void NativeControlOpening(object sender, EventArgs e) => InvokeEventCallback(OnOpening);

                        OnOpening = (EventCallback)value;
                        NativeControl.Opening -= NativeControlOpening;
                        NativeControl.Opening += NativeControlOpening;
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

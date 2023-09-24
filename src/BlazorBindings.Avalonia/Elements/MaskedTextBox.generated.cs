// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using System.Globalization;

#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements
{
    public partial class MaskedTextBox : TextBox
    {
        static MaskedTextBox()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets a value indicating if the masked text box is restricted to accept only ASCII characters. Default value is false.
        /// </summary>
        [Parameter] public bool? AsciiOnly { get; set; }
        /// <summary>
        /// Gets or sets the culture information associated with the masked text box.
        /// </summary>
        [Parameter] public CultureInfo Culture { get; set; }
        /// <summary>
        /// Gets or sets a value indicating if the prompt character is hidden when the masked text box loses focus.
        /// </summary>
        [Parameter] public bool? HidePromptOnLeave { get; set; }
        /// <summary>
        /// Gets or sets the mask to apply to the TextBox.
        /// </summary>
        [Parameter] public string Mask { get; set; }
        /// <summary>
        /// Gets or sets the character used to represent the absence of user input in MaskedTextBox.
        /// </summary>
        [Parameter] public char? PromptChar { get; set; }
        /// <summary>
        /// Gets or sets a value indicating if selected characters should be reset when the prompt character is pressed.
        /// </summary>
        [Parameter] public bool? ResetOnPrompt { get; set; }
        /// <summary>
        /// Gets or sets a value indicating if selected characters should be reset when the space character is pressed.
        /// </summary>
        [Parameter] public bool? ResetOnSpace { get; set; }

        public new AC.MaskedTextBox NativeControl => (AC.MaskedTextBox)((BindableObject)this).NativeControl;

        protected override AC.MaskedTextBox CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(AsciiOnly):
                    if (!Equals(AsciiOnly, value))
                    {
                        AsciiOnly = (bool?)value;
                        NativeControl.AsciiOnly = AsciiOnly ?? (bool)AC.MaskedTextBox.AsciiOnlyProperty.GetDefaultValue(AC.MaskedTextBox.AsciiOnlyProperty.OwnerType);
                    }
                    break;
                case nameof(Culture):
                    if (!Equals(Culture, value))
                    {
                        Culture = (CultureInfo)value;
                        NativeControl.Culture = Culture;
                    }
                    break;
                case nameof(HidePromptOnLeave):
                    if (!Equals(HidePromptOnLeave, value))
                    {
                        HidePromptOnLeave = (bool?)value;
                        NativeControl.HidePromptOnLeave = HidePromptOnLeave ?? (bool)AC.MaskedTextBox.HidePromptOnLeaveProperty.GetDefaultValue(AC.MaskedTextBox.HidePromptOnLeaveProperty.OwnerType);
                    }
                    break;
                case nameof(Mask):
                    if (!Equals(Mask, value))
                    {
                        Mask = (string)value;
                        NativeControl.Mask = Mask;
                    }
                    break;
                case nameof(PromptChar):
                    if (!Equals(PromptChar, value))
                    {
                        PromptChar = (char?)value;
                        NativeControl.PromptChar = PromptChar ?? (char)AC.MaskedTextBox.PromptCharProperty.GetDefaultValue(AC.MaskedTextBox.PromptCharProperty.OwnerType);
                    }
                    break;
                case nameof(ResetOnPrompt):
                    if (!Equals(ResetOnPrompt, value))
                    {
                        ResetOnPrompt = (bool?)value;
                        NativeControl.ResetOnPrompt = ResetOnPrompt ?? (bool)AC.MaskedTextBox.ResetOnPromptProperty.GetDefaultValue(AC.MaskedTextBox.ResetOnPromptProperty.OwnerType);
                    }
                    break;
                case nameof(ResetOnSpace):
                    if (!Equals(ResetOnSpace, value))
                    {
                        ResetOnSpace = (bool?)value;
                        NativeControl.ResetOnSpace = ResetOnSpace ?? (bool)AC.MaskedTextBox.ResetOnSpaceProperty.GetDefaultValue(AC.MaskedTextBox.ResetOnSpaceProperty.OwnerType);
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

// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using BlazorBindings.Core;
using BlazorBindings.Maui.Elements.Handlers;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.Maui;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public abstract partial class Layout : View
    {
        static Layout()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public bool? CascadeInputTransparent { get; set; }
        [Parameter] public bool? IgnoreSafeArea { get; set; }
        [Parameter] public bool? IsClippedToBounds { get; set; }
        [Parameter] public Thickness? Padding { get; set; }

        public new MC.Layout NativeControl => (ElementHandler as LayoutHandler)?.LayoutControl;

        protected override void RenderAttributes(AttributesBuilder builder)
        {
            base.RenderAttributes(builder);

            if (CascadeInputTransparent != null)
            {
                builder.AddAttribute(nameof(CascadeInputTransparent), CascadeInputTransparent.Value);
            }
            if (IgnoreSafeArea != null)
            {
                builder.AddAttribute(nameof(IgnoreSafeArea), IgnoreSafeArea.Value);
            }
            if (IsClippedToBounds != null)
            {
                builder.AddAttribute(nameof(IsClippedToBounds), IsClippedToBounds.Value);
            }
            if (Padding != null)
            {
                builder.AddAttribute(nameof(Padding), AttributeHelper.ThicknessToString(Padding.Value));
            }

            RenderAdditionalAttributes(builder);
        }

        partial void RenderAdditionalAttributes(AttributesBuilder builder);

        static partial void RegisterAdditionalHandlers();
    }
}
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Microsoft.AspNetCore.Components;

namespace BlazorBindings.Maui.Elements.Shapes
{
    public partial class Polyline : Shape
    {
        [Parameter] public string Points { get; set; }

        protected override bool HandleAdditionalParameter(string name, object value)
        {
            if (name == nameof(Points))
            {
                if (!Equals(value, Points))
                {
                    NativeControl.Points = AttributeHelper.StringToPointCollection((string)value);
                    Points = (string)value;
                }
                return true;
            }

            return base.HandleAdditionalParameter(name, value);
        }
    }
}
// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using AC = Avalonia.Controls;
using BlazorBindings.Core;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements
{
    /// <summary>
    /// A control to allow the user to select a date
    /// </summary>
    public partial class DatePicker : BlazorBindings.AvaloniaBindings.Elements.Primitives.TemplatedControl
    {
        static DatePicker()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public string DayFormat { get; set; }
        /// <summary>
        /// Gets or sets whether the day is visible
        /// </summary>
        [Parameter] public bool? DayVisible { get; set; }
        /// <summary>
        /// Gets or sets the maximum year for the picker
        /// </summary>
        [Parameter] public DateTimeOffset? MaxYear { get; set; }
        /// <summary>
        /// Gets or sets the minimum year for the picker
        /// </summary>
        [Parameter] public DateTimeOffset? MinYear { get; set; }
        /// <summary>
        /// Gets or sets the month format
        /// </summary>
        [Parameter] public string MonthFormat { get; set; }
        /// <summary>
        /// Gets or sets whether the month is visible
        /// </summary>
        [Parameter] public bool? MonthVisible { get; set; }
        /// <summary>
        /// Gets or sets the Selected Date for the picker, can be null
        /// </summary>
        [Parameter] public Nullable<DateTimeOffset> SelectedDate { get; set; }
        /// <summary>
        /// Gets or sets the year format
        /// </summary>
        [Parameter] public string YearFormat { get; set; }
        /// <summary>
        /// Gets or sets whether the year is visible
        /// </summary>
        [Parameter] public bool? YearVisible { get; set; }
        [Parameter] public EventCallback<Nullable<DateTimeOffset>> SelectedDateChanged { get; set; }

        public new AC.DatePicker NativeControl => (AC.DatePicker)((BindableObject)this).NativeControl;

        protected override AC.DatePicker CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(DayFormat):
                    if (!Equals(DayFormat, value))
                    {
                        DayFormat = (string)value;
                        NativeControl.DayFormat = DayFormat;
                    }
                    break;
                case nameof(DayVisible):
                    if (!Equals(DayVisible, value))
                    {
                        DayVisible = (bool?)value;
                        NativeControl.DayVisible = DayVisible ?? (bool)AC.DatePicker.DayVisibleProperty.GetDefaultValue(AC.DatePicker.DayVisibleProperty.OwnerType);
                    }
                    break;
                case nameof(MaxYear):
                    if (!Equals(MaxYear, value))
                    {
                        MaxYear = (DateTimeOffset?)value;
                        NativeControl.MaxYear = MaxYear ?? (DateTimeOffset)AC.DatePicker.MaxYearProperty.GetDefaultValue(AC.DatePicker.MaxYearProperty.OwnerType);
                    }
                    break;
                case nameof(MinYear):
                    if (!Equals(MinYear, value))
                    {
                        MinYear = (DateTimeOffset?)value;
                        NativeControl.MinYear = MinYear ?? (DateTimeOffset)AC.DatePicker.MinYearProperty.GetDefaultValue(AC.DatePicker.MinYearProperty.OwnerType);
                    }
                    break;
                case nameof(MonthFormat):
                    if (!Equals(MonthFormat, value))
                    {
                        MonthFormat = (string)value;
                        NativeControl.MonthFormat = MonthFormat;
                    }
                    break;
                case nameof(MonthVisible):
                    if (!Equals(MonthVisible, value))
                    {
                        MonthVisible = (bool?)value;
                        NativeControl.MonthVisible = MonthVisible ?? (bool)AC.DatePicker.MonthVisibleProperty.GetDefaultValue(AC.DatePicker.MonthVisibleProperty.OwnerType);
                    }
                    break;
                case nameof(SelectedDate):
                    if (!Equals(SelectedDate, value))
                    {
                        SelectedDate = (Nullable<DateTimeOffset>)value;
                        NativeControl.SelectedDate = SelectedDate;
                    }
                    break;
                case nameof(YearFormat):
                    if (!Equals(YearFormat, value))
                    {
                        YearFormat = (string)value;
                        NativeControl.YearFormat = YearFormat;
                    }
                    break;
                case nameof(YearVisible):
                    if (!Equals(YearVisible, value))
                    {
                        YearVisible = (bool?)value;
                        NativeControl.YearVisible = YearVisible ?? (bool)AC.DatePicker.YearVisibleProperty.GetDefaultValue(AC.DatePicker.YearVisibleProperty.OwnerType);
                    }
                    break;
                case nameof(SelectedDateChanged):
                    if (!Equals(SelectedDateChanged, value))
                    {
                        void NativeControlSelectedDateChanged(object sender, AC.DatePickerSelectedValueChangedEventArgs e)
                        {
                            var value = NativeControl.SelectedDate;
                            SelectedDate = value;
                            InvokeEventCallback(SelectedDateChanged, value);
                        }

                        SelectedDateChanged = (EventCallback<Nullable<DateTimeOffset>>)value;
                        NativeControl.SelectedDateChanged -= NativeControlSelectedDateChanged;
                        NativeControl.SelectedDateChanged += NativeControlSelectedDateChanged;
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CheckboxSample.Components
{
    public class CheckBoxCell : Cell
    {
        public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create("IsChecked", typeof(bool), typeof(CheckBoxCell), false, propertyChanged: (obj, oldValue, newValue) =>
        {
            var checkBoxCell = (CheckBoxCell)obj;
            checkBoxCell.OnChanged?.Invoke(obj, new ToggledEventArgs((bool)newValue));
        }, defaultBindingMode: BindingMode.TwoWay);

        public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(CheckBoxCell), default(string));

        public bool IsChecked
        {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public event EventHandler<ToggledEventArgs> OnChanged;
    }
}

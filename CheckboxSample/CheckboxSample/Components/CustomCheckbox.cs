using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CheckboxSample.Components
{
    public class CustomCheckbox : View
    {
        public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create<CustomCheckbox, bool>(p => p.IsChecked, true, propertyChanged: (s, o, n) => { (s as CustomCheckbox).OnChecked(new EventArgs()); });
        public static readonly BindableProperty ColorProperty = BindableProperty.Create<CustomCheckbox, Color>(p => p.Color, Color.Default);
        public static readonly BindableProperty BindableObjectProperty = BindableProperty.Create(
            propertyName: "BindableObject",
            returnType: typeof(object),
            declaringType: typeof(CustomCheckbox),
            defaultValue: null);

        public object BindableObject
        {
            get { return (object)GetValue(BindableObjectProperty); }
            set { SetValue(BindableObjectProperty, value); }
        }

        public bool IsChecked
        {
            get
            {
                return (bool)GetValue(IsCheckedProperty);
            }
            set
            {
                SetValue(IsCheckedProperty, value);
            }
        }

        public Color Color
        {
            get
            {
                return (Color)GetValue(ColorProperty);
            }
            set
            {
                SetValue(ColorProperty, value);
            }
        }

        public event EventHandler Checked;

        protected virtual void OnChecked(EventArgs e)
        {
            if (Checked != null)
                Checked(this, e);
        }
    }
}

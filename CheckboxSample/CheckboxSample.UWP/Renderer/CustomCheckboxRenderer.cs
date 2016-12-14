using CheckboxSample.Components;
using CheckboxSample.UWP.Renderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomCheckbox), typeof(CustomCheckboxRenderer))]
namespace CheckboxSample.UWP.Renderer
{
    public class CustomCheckboxRenderer : ViewRenderer<CustomCheckbox, CheckBox>
    {
        private CheckBox nativeCheckbox;

        public CustomCheckboxRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<CustomCheckbox> e)
        {
            base.OnElementChanged(e);
            var model = e.NewElement;
            if (model == null)
            {
                return;
            }

            nativeCheckbox = new CheckBox();
            CheckboxPropertyChanged(model, null);
            model.PropertyChanged += OnElementPropertyChanged;

            nativeCheckbox.Checked += (object sender, Windows.UI.Xaml.RoutedEventArgs eargs) =>
            {
                model.IsChecked = (bool)nativeCheckbox.IsChecked;
            };

            nativeCheckbox.Unchecked += (object sender, Windows.UI.Xaml.RoutedEventArgs eargs) =>
            {
                model.IsChecked = (bool)nativeCheckbox.IsChecked;
            };

            SetNativeControl(nativeCheckbox);
        }

        private void CheckboxPropertyChanged(CustomCheckbox model, string propertyName)
        {
            if (propertyName == null || propertyName == CustomCheckbox.IsCheckedProperty.PropertyName)
            {
                nativeCheckbox.IsChecked = model.IsChecked;
            }
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (nativeCheckbox != null)
            {
                base.OnElementPropertyChanged(sender, e);

                CheckboxPropertyChanged((CustomCheckbox)sender, e.PropertyName);
            }
        }
    }
}

using CheckboxSample.Components;
using CheckboxSample.UWP.Renderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Xamarin.Forms.Platform.UWP;
using WDataTemplate = Windows.UI.Xaml.DataTemplate;
using WApplication = Windows.UI.Xaml.Application;
using Xamarin.Forms;

[assembly: ExportCell(typeof(CheckBoxCell), typeof(CheckBoxCellRenderer))]
namespace CheckboxSample.UWP.Renderer
{
    public class CheckBoxCellRenderer : ICellRenderer
    {
        public virtual WDataTemplate GetTemplate(Cell cell)
        {
            return (WDataTemplate)WApplication.Current.Resources["CheckBoxCell"];
        }
    }
}

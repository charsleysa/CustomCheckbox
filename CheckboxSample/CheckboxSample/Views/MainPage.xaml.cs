using CheckboxSample.Classes;
using CheckboxSample.Components;
using CheckboxSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CheckboxSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BaseInit();
            
            InitializeComponent();
        }

        void BaseInit()
        {
            this.BindingContext = new MainPageViewModel();
        }
    }
}

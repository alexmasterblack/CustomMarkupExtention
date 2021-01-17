using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomMarkupExtention
{
    public class Colors
    {
        public string Name { get; set; }
    }
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Colors> ListColors { get; set; }
        public MainPage()
        {
            InitializeComponent();
            ListColors = new ObservableCollection<Colors>();
            foreach (System.Drawing.Color color in AllColors.GetAllColors())
            {
                ListColors.Add(new Colors()
                {
                    Name = color.Name
                });
            }
            BindingContext = this;
        }
    }
}

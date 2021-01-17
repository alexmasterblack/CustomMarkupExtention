using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomMarkupExtention
{
    public class Extention : IMarkupExtension
    {
        public int A { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Color.FromRgba(R, G, B, A);
        }
    }
}

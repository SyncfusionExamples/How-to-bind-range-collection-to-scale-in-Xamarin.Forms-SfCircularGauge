using Syncfusion.SfGauge.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GaugeSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class ViewModel
    {
        public ObservableCollection<Range> Ranges
        {
            get;
            set;
        }

        public ViewModel()
        {
            Ranges = new ObservableCollection<Range>();
         
            Range range = new Range();
            range.StartValue = 0;
            range.EndValue = 35;
            range.Offset = 0.7;
            range.Thickness = 30;
            range.Color = Color.FromHex("#F03E3E");

            Range range1 = new Range();
            range1.StartValue = 35;
            range1.EndValue = 75;
            range1.Offset = 0.7;
            range1.Thickness = 30;
            range1.Color = Color.FromHex("#FFDD00");
            
            Range range2 = new Range();
            range2.StartValue = 75;
            range2.EndValue = 100;
            range2.Offset = 0.7;
            range2.Thickness = 30;
            range2.Color = Color.FromHex("#27beb7");

            Ranges.Add(range);
            Ranges.Add(range1);
            Ranges.Add(range2);
        }
    }
}

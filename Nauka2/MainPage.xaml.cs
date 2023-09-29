using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Nauka2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void FontSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Double.TryParse(FontSlider.Value.ToString(), out double x);
            Label1.FontSize = x;
        }

        public string[] ArrayText = { "Co tam Lola?" ,"Co dziś dobrego jadłaś?" , "Jak tam twój 'Kolega'?" };
        public int i = 0;
        
        public Color[] arrayColor = { Color.Blue, Color.Pink, Color.Green, Color.Yellow, Color.Black };
        private void NextText_Clicked(object sender, EventArgs e)
        {
            Label1.Text = ArrayText[i];
            i++;
            if (i == ArrayText.Length) { i = 0; }
        }

        private void ColorSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {

            double.TryParse(ColorSlider.Value.ToString(), out double x);

            int y = (int) Math.Round(x);
            Label1.TextColor = arrayColor[y];
            Console.WriteLine(arrayColor[y]);
            Console.WriteLine($"wartość value to {ColorSlider.Value}");
        }
    }
}

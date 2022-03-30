using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Iris_Predict
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataUI : ContentPage
    {
        public DataUI()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            double[] medidas = {
                double.Parse(sepalLength.Text),
                double.Parse(sepalWidth.Text),
                double.Parse(petalLength.Text),
                double.Parse(petalWidth.Text)};
            await Navigation.PushAsync(new Result(medidas) { });


        }

    }
}
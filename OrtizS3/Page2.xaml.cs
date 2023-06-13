using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrtizS3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2(string datoUno, int datoDos)
        {
            InitializeComponent();
            lblDatoUno.Text = "DATO UNO" + datoUno;
            lblDatoDos.Text = "DATO DOS" + datoDos.ToString();
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {
            Navigation.p

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Quantity
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnPlus_Clicked(object sender, EventArgs e)
        {
            lblCounter.Text = $"{ int.Parse(lblCounter.Text) + 1 }";
        }

        private void btnMinus_Clicked(object sender, EventArgs e)
        {
            lblCounter.Text = $"{ int.Parse(lblCounter.Text) - 1 }";
        }
    }
}

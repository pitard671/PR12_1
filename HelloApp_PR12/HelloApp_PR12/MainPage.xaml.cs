using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PR12
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Fib(object sender, EventArgs args) 
        {
            int[] fib = new int[50];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i < 50; i++) {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++) myGrid.Children.Add(new Label { Text = fib[i*10+j].ToString() }, i, j);
            }
        }
    }
}

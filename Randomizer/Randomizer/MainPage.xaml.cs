using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Randomizer
{
    public partial class MainPage : ContentPage
    {
        readonly BusinessLogic bl = new BusinessLogic();
        public List<string> numbers = new List<string>();
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnRand_Clicked(object sender, EventArgs e)
        {
            var min = txtMin.Text;
            var max = txtMax.Text;

            if (string.IsNullOrEmpty(min) || string.IsNullOrEmpty(max))
            {
                lblTxt.Text = "Type in the text below";
            }
            else
            {
                lblTxt.Text = "";
            }

            numbers = bl.GetNumbers(Convert.ToInt32(min), Convert.ToInt32(max));


            //string joinedNames = numbers.Aggregate((x, y) => x + ", " + y);

            txtRand.Text = "";
            while (numbers.Count > 1)
            {
                txtRand.Text += bl.Randomize(numbers) + "\n";
            }

            txtRand.Text += numbers.First();

        }
    }
}

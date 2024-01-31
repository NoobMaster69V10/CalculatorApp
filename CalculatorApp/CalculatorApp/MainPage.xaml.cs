using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculatorApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void clear_Clicked(object sender, EventArgs e)
        {
            result.Text = "0";
        }
        private void btn0_Clicked(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
            }
            else
                result.Text += "0";
        }
        private void btn1_Clicked(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
                result.Text += "1";
            }
            else
                result.Text += "1";
        }
        private void btn2_Clicked(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
                result.Text += "2";
            }
            else
                result.Text += "2";
        }
        private void btn3_Clicked(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
                result.Text += "3";
            }
            else
                result.Text += "3";
        }
        private void btn4_Clicked(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
                result.Text += "4";
            }
            else
                result.Text += "4";
        }
        private void btn5_Clicked(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
                result.Text += "5";
            }
            else
                result.Text += "5";
        }
        private void btn6_Clicked(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
                result.Text += "6";
            }
            else
                result.Text += "6";
        }
        private void btn7_Clicked(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
                result.Text += "7";
            }
            else
                result.Text += "7";
        }
        private void btn8_Clicked(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
                result.Text += "8";
            }
            else
                result.Text += "8";
        }
        private void btn9_Clicked(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
                result.Text += "9";
            }
            else
                result.Text += "9";
        }
        private void multi_Clicked(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
                result.Text += "*";
            }
            else
                result.Text += "*";
        }
        private void divide_Clicked(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
                result.Text += "/";
            }
            else
                result.Text += "/";
        }
        private void minus_Clicked(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
                result.Text += "-";
            }
            else
                result.Text += "-";
        }
        private void plus_Clicked(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "";
                result.Text += "+";
            }
            else
                result.Text += "+";
        }
        private void dot_Clicked(object sender, EventArgs e)
        {
            result.Text += ".";
        }
        private void delete_Clicked(object sender, EventArgs e)
        {
            string text = result.Text;

            result.Text = text.Substring(0, text.Length - 1);

        }

        private void equal_Clicked(object sender, EventArgs e)
        {
            string value = new DataTable().Compute(result.Text, null).ToString();
            result.Text = value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        double num1,num2;
        char operators;
        double result;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void revBtn(object sender, RoutedEventArgs e)
        {
            num1 = Double.Parse(txtresult.Text);
            result = -num1;
            txtresult.Text = result.ToString();
        }

        private void numBtn(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if(txtresult.Text == "0")
            {
                txtresult.Text = btn.Content.ToString();
            }
            else
            {
                txtresult.Text += btn.Content.ToString();
            }
        }

        private void pointBtn(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            txtresult.Text += btn.Content.ToString();
        }

        private void calCulate(object sender, RoutedEventArgs e)
        {
            num2 = Double.Parse(txtresult.Text);
            switch (operators)
            {
                case '+':
                    result = num1 + num2;
                    txtresult.Text = result.ToString();
                    break;
                case '-':
                    result = num1 - num2;
                    txtresult.Text = result.ToString();
                    break;
                case '*':
                    result = num1 * num2;
                    txtresult.Text = result.ToString();
                    break;
                case '/':
                    if(num2 != 0)
                    {
                        result = num1 / num2;
                        txtresult.Text = result.ToString();
                    }
                    else
                    {
                        txtresult.Text = "Maths Error";
                    }
                    break;
            }
        }

        private void basicCalculator(object sender, RoutedEventArgs e)
        {
            basicCalc.Visibility = Visibility.Visible;
            sciCalc.Visibility = Visibility.Collapsed;
        }

        private void sciCalculator(object sender, RoutedEventArgs e)
        {
            basicCalc.Visibility=Visibility.Collapsed;
            sciCalc.Visibility=Visibility.Visible;
        }

        private void clearBtn(object sender, RoutedEventArgs e)
        {
            txtresult.Text = "0";
        }

        private void divBtn(object sender, RoutedEventArgs e)
        {
            num1 = Double.Parse(txtresult.Text);
            operators = '/';
            txtresult.Text = "";
        }
        private void addBtn(object sender, RoutedEventArgs e)
        {
            num1 = Double.Parse(txtresult.Text);
            operators = '+';
            txtresult.Text = "";
        }
        private void multiBtn(object sender, RoutedEventArgs e)
        {
            num1 = Double.Parse(txtresult.Text);
            operators = '*';
            txtresult.Text = "";
        }
        private void minusBtn(object sender, RoutedEventArgs e)
        {
            num1 = Double.Parse(txtresult.Text);
            operators = '-';
            txtresult.Text = "";
        }

        private void sinBtn(object sender, RoutedEventArgs e)
        {
            num1 = Double.Parse(txtresult.Text);
            result = Math.Sin(num1);
            txtresult.Text = result.ToString();
        }

        private void cosBtn(object sender, RoutedEventArgs e)
        {
            num1 = Double.Parse(txtresult.Text);
            result = Math.Cos(num1);
            txtresult.Text = result.ToString();
        }
        private void tanBtn(object sender, RoutedEventArgs e)
        {
            num1 = Double.Parse(txtresult.Text);
            result = Math.Tan(num1);
            txtresult.Text = result.ToString();
        }
        private void rootBtn(object sender, RoutedEventArgs e)
        {
            num1 = Double.Parse(txtresult.Text);
            result = Math.Sqrt(num1);
            txtresult.Text = result.ToString();
        }
        private void percentBtn(object sender, RoutedEventArgs e)
        {
            num1 = Double.Parse(txtresult.Text);
            result = num1 / 100;
            txtresult.Text = result.ToString();
        }
        private void delBtn(object sender, RoutedEventArgs e)
        {
            txtresult.Text = txtresult.Text.Substring(0, txtresult.Text.Length - 1);
        }
    }
}


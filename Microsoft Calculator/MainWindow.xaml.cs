using System;
using System.Windows;

namespace Microsoft_Calculator;

public partial class MainWindow : Window
{
    int num1;
    int num2;
    int result;
    string operation;

    public MainWindow()
    {
        InitializeComponent();
    }

    #region Number Button Events
    private void Btn7_Click(object sender, RoutedEventArgs e)
    {
        TextBoxx.Content = TextBoxx.Content + "7";
    }

    private void Btn8_Click(object sender, RoutedEventArgs e)
    {
        TextBoxx.Content = TextBoxx.Content + "8";

    }

    private void Btn9_Click(object sender, RoutedEventArgs e)
    {
        TextBoxx.Content = TextBoxx.Content + "9";
    }

    private void Btn4_Click(object sender, RoutedEventArgs e)
    {
        TextBoxx.Content = TextBoxx.Content + "4";
    }

    private void Btn5_Click(object sender, RoutedEventArgs e)
    {
        TextBoxx.Content = TextBoxx.Content + "5";
    }

    private void Btn6_Click(object sender, RoutedEventArgs e)
    {
        TextBoxx.Content = TextBoxx.Content + "6";
    }

    private void Btn1_Click(object sender, RoutedEventArgs e)
    {
        TextBoxx.Content = TextBoxx.Content + "1";
    }

    private void Btn2_Click(object sender, RoutedEventArgs e)
    {
        TextBoxx.Content = TextBoxx.Content + "2";
    }

    private void Btn3_Click(object sender, RoutedEventArgs e)
    {
        TextBoxx.Content = TextBoxx.Content + "3";
    }

    private void Btn0_Click(object sender, RoutedEventArgs e)
    {
        TextBoxx.Content = TextBoxx.Content + "0";
    }



    #endregion Button Events


    #region Operation Button events
    private void CBtn_Click(object sender, RoutedEventArgs e)
    {
        TextBoxx.Content = string.Empty;
        num1 = 0;
        num2 = 0;
        result = 0;
    }

    private void CEtBtn_Click(object sender, RoutedEventArgs e)
    {
        TextBoxx.Content = string.Empty;
        num1 = 0;
        num2 = 0;
        result = 0;
    }

    private void DivideBtn_Click(object sender, RoutedEventArgs e)
    {
        num1 = int.Parse(TextBoxx.Content.ToString());
        operation = "/";
        TextBoxx.Content = string.Empty;
    }

    private void SubstractionBtn_Click(object sender, RoutedEventArgs e)
    {
        num1 = int.Parse(TextBoxx.Content.ToString());
        operation = "*";
        TextBoxx.Content = string.Empty;
    }

    private void MinusBtn_Click(object sender, RoutedEventArgs e)
    {
        num1 = int.Parse(TextBoxx.Content.ToString());
        operation = "-";
        TextBoxx.Content = string.Empty;
    }

    private void AddBtn_Click(object sender, RoutedEventArgs e)
    {
        num1 = int.Parse(TextBoxx.Content.ToString());
        operation = "+";
        TextBoxx.Content = string.Empty;
    }

    private void EqualBtn_Click(object sender, RoutedEventArgs e)
    {
        num2 = int.Parse(TextBoxx.Content.ToString());

        if (operation == "+")
            result = num1 + num2;
        if (operation == "-")
            result = num1 - num2;
        if (operation == "*")
            result = num1 * num2;
        
            if (operation == "/")
        {
            if (num2 == 0)
                MessageBox.Show("Can't divide zero", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                result = num1 / num2;
        }
        TextBoxx.Content = result.ToString();
    }




    #endregion Operation Button events

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        if (TextBoxx.Content.ToString().Length >0)
        {
            TextBoxx.Content = TextBoxx.Content.ToString().Substring(0, TextBoxx.Content.ToString().Length - 1);
        }
    }

    private void sqrtBtn_Click(object sender, RoutedEventArgs e)
    {
        operation = "sqrt";
        num1 = int.Parse(TextBoxx.Content.ToString());
        result = (int)Math.Sqrt(num1);
        TextBoxx.Content = result.ToString();
    }
}
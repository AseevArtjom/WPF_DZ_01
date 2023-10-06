using System;
using System.Windows;
using System.Windows.Controls;

namespace WPF_lesson_02
{
    public partial class MainWindow : Window
    {
        string Result = "";
        string LastResult = "";
        double leftOperand = 0;
        double rightOperand = 0;
        char currentOperator = ' ';

        public MainWindow()
        {
            InitializeComponent();
        }


        private void one_Click(object sender, RoutedEventArgs e)
        {
            UpdateResultBoxText(Result + "1");
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            UpdateResultBoxText(Result + "2");
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            UpdateResultBoxText(Result + "3");
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            UpdateResultBoxText(Result + "4");
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            UpdateResultBoxText(Result + "5");
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            UpdateResultBoxText(Result + "6");
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            UpdateResultBoxText(Result + "7");
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            UpdateResultBoxText(Result + "8");
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            UpdateResultBoxText(Result + "9");
        }

        private void zero_CLick(object sender, RoutedEventArgs e)
        {
            UpdateResultBoxText(Result + "0");
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            if (Result != "")
            {
                leftOperand = double.Parse(Result);
                currentOperator = '+';
                Result = "";
                ResultBox.Text += "+";
            }
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            if (Result != "")
            {
                leftOperand = double.Parse(Result);
                currentOperator = '-';
                Result = "";
                ResultBox.Text += "-";
            }
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            if (Result != "")
            {
                leftOperand = double.Parse(Result);
                currentOperator = '/';
                Result = "";
                ResultBox.Text += "/";
            }
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            if (Result != "")
            {
                leftOperand = double.Parse(Result);
                currentOperator = '*';
                Result = "";
                ResultBox.Text += "*";
            }
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            if (currentOperator != ' ')
            {
                if (double.TryParse(Result, out rightOperand))
                {
                    double result = 0;
                    switch (currentOperator)
                    {
                        case '+':
                            result = leftOperand + rightOperand;
                            break;
                        case '-':
                            result = leftOperand - rightOperand;
                            break;
                        case '/':
                            if (rightOperand == 0)
                            {
                                UpdateResultBoxText("Ошибка");
                                return;
                            }
                            result = leftOperand / rightOperand;
                            break;
                        case '*':
                            result = leftOperand * rightOperand;
                            break;
                    }
                    LastResult = leftOperand + " " + currentOperator + " " + rightOperand + " = " + result;
                    LastResults.Text = LastResult;
                    Result = "";
                    ResultBox.Text = result.ToString();
                    leftOperand = result;
                    currentOperator = ' ';
                }
            }
        }
        private void UpdateResultBoxText(string str)
        {
            Result = str;
            ResultBox.Text = Result;
        }



        private void C_Click(object sender, RoutedEventArgs e)
        {
            Result = "";
            ResultBox.Text = Result;
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            C_Click(sender, e);
            LastResult = "";
            LastResults.Text = LastResult;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Length > 0)
            {
                Result = Result.Substring(0, Result.Length - 1);
                ResultBox.Text = Result;
            }
        }

        private void point_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
using System;
using System.Windows;
using System.Windows.Controls;
using WPFCalculator.CalculateC;
using WPFCalculator.DataOperator;
using WPFCalculator.ViewModel;

namespace WPFCalculator
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        double beforeNum;
        Operators op;
        double result;
        int sv;

        public MainWindow()
        {
            InitializeComponent();
        }
        #region 숫자버튼 클릭 메소드
        private void numButton_Click(object sender, RoutedEventArgs e)
        {
            if(sender == zero)
            {
                sv = 0;
                if (resultTextBlock.Text == "0")
                {
                    resultTextBlock.Text = sv.ToString();
                    remTextBlock.Text += sv.ToString();
                }

                else
                {
                    resultTextBlock.Text += sv.ToString();
                    remTextBlock.Text += sv.ToString();
                }
            }
            if (sender == one)
            {
                sv = 1;
                if (resultTextBlock.Text == "0")
                {
                    resultTextBlock.Text = sv.ToString();
                    remTextBlock.Text += sv.ToString();
                }

                else
                {
                    resultTextBlock.Text += sv.ToString();
                    remTextBlock.Text += sv.ToString();
                }
            }
            if (sender == two)
            {
                sv = 2;
                if (resultTextBlock.Text == "0")
                {
                    resultTextBlock.Text = sv.ToString();
                    remTextBlock.Text += sv.ToString();
                }

                else
                {
                    resultTextBlock.Text += sv.ToString();
                    remTextBlock.Text += sv.ToString();
                }
            }
            if (sender == Three)
            {
                sv = 3;
                if (resultTextBlock.Text == "0")
                {
                    resultTextBlock.Text = sv.ToString();
                    remTextBlock.Text += sv.ToString();
                }

                else
                {
                    resultTextBlock.Text += sv.ToString();
                    remTextBlock.Text += sv.ToString();
                }
            }
            if (sender == four)
            {
                sv = 4;
                if (resultTextBlock.Text == "0")
                {
                    resultTextBlock.Text = sv.ToString();
                    remTextBlock.Text += sv.ToString();
                }

                else
                {
                    resultTextBlock.Text += sv.ToString();
                    remTextBlock.Text += sv.ToString();
                }
            }
            if (sender == five)
            {
                sv = 5;
                if (resultTextBlock.Text == "0")
                {
                    resultTextBlock.Text = sv.ToString();
                    remTextBlock.Text += sv.ToString();
                }

                else
                {
                    resultTextBlock.Text += sv.ToString();
                    remTextBlock.Text += sv.ToString();
                }
            }
            if (sender == six)
            {
                sv = 6;
                if (resultTextBlock.Text == "0")
                {
                    resultTextBlock.Text = sv.ToString();
                    remTextBlock.Text += sv.ToString();
                }

                else
                {
                    resultTextBlock.Text += sv.ToString();
                    remTextBlock.Text += sv.ToString();
                }
            }
            if (sender == seven)
            {
                sv = 7;
                if (resultTextBlock.Text == "0")
                {
                    resultTextBlock.Text = sv.ToString();
                    remTextBlock.Text += sv.ToString();
                }

                else
                {
                    resultTextBlock.Text += sv.ToString();
                    remTextBlock.Text += sv.ToString();
                }
            }
            if (sender == eight)
            {
                sv = 8;
                if (resultTextBlock.Text == "0")
                {
                    resultTextBlock.Text = sv.ToString();
                    remTextBlock.Text += sv.ToString();
                }

                else
                {
                    resultTextBlock.Text += sv.ToString();
                    remTextBlock.Text += sv.ToString();
                }
            }
            if (sender == nine)
            {
                sv = 9;
                if (resultTextBlock.Text == "0")
                {
                    resultTextBlock.Text = sv.ToString();
                    remTextBlock.Text += sv.ToString();
                }

                else
                {
                    resultTextBlock.Text += sv.ToString();
                    remTextBlock.Text += sv.ToString();
                }
            }
        }
        #endregion

        #region 연산버튼 클릭 메소드

        private void operationButton_Click(object sender, RoutedEventArgs e)
        {
            beforeNum = double.Parse(resultTextBlock.Text.ToString());
            resultTextBlock.Text = "0";

            if (sender == plus)
            {
                op = Operators.Addition;
                remTextBlock.Text += "+";
            }

            if (sender == minus)
            {
                op = Operators.Subtraction;
                remTextBlock.Text += "-";
            }
            if (sender == mul)
            {
                op = Operators.Multiplication;
                remTextBlock.Text += "*";
            }
            if (sender == div)
            {
                op = Operators.Division;
                remTextBlock.Text += "/";
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            resultTextBlock.Text = "0";
            remTextBlock.Text = "";
        }

        private void plusmius_Click(object sender, RoutedEventArgs e)
        {
            double lnum;

            if(double.TryParse(resultTextBlock.Text.ToString(),out lnum))
            {
                lnum = lnum * -1;
                resultTextBlock.Text = lnum.ToString();
                remTextBlock.Text = lnum.ToString();
            }
        }
        private void dot_Click(object sender, RoutedEventArgs e)
        {
            Boolean a;
            a = resultTextBlock.Text.ToString().Contains(".");
            if (resultTextBlock.Text.ToString() == "0")
                return;
            else
            {
                if (a == false)
                    resultTextBlock.Text += ".";
            }
        }

        private void Equl_Click(object sender, RoutedEventArgs e)
        {
            double resultNum = double.Parse(resultTextBlock.Text.ToString());

            switch (op)
            {
                case Operators.Addition:
                    result = CalculateMath.Add(beforeNum, resultNum);
                    break;
                case Operators.Subtraction:
                    result = CalculateMath.Subtract(beforeNum, resultNum);
                    break;
                case Operators.Division:
                    result = CalculateMath.Divide(beforeNum, resultNum);
                    break;
                case Operators.Multiplication:
                    result = CalculateMath.Multiple(beforeNum, resultNum);
                    break;

            }
            resultTextBlock.Text = result.ToString();
        }
        #endregion

    }
}

using WPFCalculator.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace WPFCalculator.ViewModel
{
    public class CalViewModel 
    {
        private Window mWindow;

        public CalViewModel(Window window)
        {
            mWindow = window;
        }
    }
}

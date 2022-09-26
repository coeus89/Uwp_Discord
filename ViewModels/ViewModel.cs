using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uwp_Discord.ViewModels
{
    public class ViewModel : INotifyPropertyChanged
    {
        private double _screenWidth;
        private double _screenHeight;

        public double ScreenWidth { get { return _screenWidth; } set { _screenWidth = value; OnPropertyChanged("ScreenWidth"); } }
        public double ScreenHeight { get { return _screenHeight; } set { _screenHeight = value; OnPropertyChanged("ScreenHeight"); } }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}

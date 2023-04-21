using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace HelloWorld
{
    internal class HelloViewModel:ViewModelBase

    {
        public RelayCommand Click { get; set; }

        public RelayCommand OutClick { get; set; }




        public HelloViewModel()
        {
            Click = new RelayCommand(OnClick);
            OutClick = new RelayCommand(OnOutClick);
        }
        private void OnOutClick()
        {
            MessageBox.Show("再见");
        }
        private void OnClick()
        {
            MessageBox.Show("你好");
        }
    }
}

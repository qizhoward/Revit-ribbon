using System.Windows;

namespace HelloWorld
{
    /// <summary>
    /// HelloView.xaml 的交互逻辑
    /// </summary>
    public partial class HelloView : Window
    {
        public HelloView()
        {

            InitializeComponent();

            DataContext = new HelloViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

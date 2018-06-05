using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MediaCaptureWPF;
using Windows.Media.Capture;
using Windows.Foundation;





namespace FloatingAppExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
        }

        protected override async void OnActivated(EventArgs e)
        {
            var capture = new MediaCapture();
            await capture.InitializeAsync();
            var preview = new CapturePreview(capture);
            Preview.Source = preview;
            await preview.StartAsync();
        }

        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}

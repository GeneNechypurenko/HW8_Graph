using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW8_Graph
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

        private void canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           Point clickPoint = e.GetPosition(canvas);

            if(clickPoint.X >= kitchenRect.Rect.Height && clickPoint.Y <= kitchenRect.Rect.Width )
            {
                MessageBox.Show("Кухня 18м2");
            }
            else if(clickPoint.X >= coridorRect.Rect.Height && clickPoint.Y <= coridorRect.Rect.Width)
            {
                MessageBox.Show("Коридор 20м2");
            }
            else if (clickPoint.X >= bedroomRect.Rect.Height && clickPoint.Y <= bedroomRect.Rect.Width)
            {
                MessageBox.Show("Спальния 23м2");
            }
            else if (clickPoint.X >= hallRect.Rect.Height && clickPoint.Y <= hallRect.Rect.Width)
            {
                MessageBox.Show("Зал 34м2");
            }
        }
    }
}
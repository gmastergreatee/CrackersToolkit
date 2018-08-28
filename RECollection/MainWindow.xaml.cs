using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Navigation;
using System.Collections.Generic;
using RECollection.Module.Classes;
using System.Windows.Media.Imaging;

namespace RECollection
{
    public partial class MainWindow : Window
    {
        WindowPosition position;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            position = new WindowPosition(Width, Height);
            Top = position.Top;
            Left = position.Left;
            Width = position.Width;
            Height = position.Height;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            position.SavePosition(Top, Left, Width, Height);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (WindowState == WindowState.Maximized)
                {
                    WindowState = WindowState.Normal;
                    var point = Mouse.GetPosition(this);
                    Top = point.Y - TitleGrid.ActualHeight;
                    Left = point.X - (ActualWidth * point.X) / SystemParameters.PrimaryScreenWidth;
                }
                DragMove();
            }
        }
    }
}

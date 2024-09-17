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
using WpfIntRim.Core;

namespace WpfIntRim
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static RimNumer rimNumer = new RimNumer();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                rimNumer.IntRim(riml, InputTextBox);
            }
        }

        private void InputTextBox_LayoutUpdated(object sender, EventArgs e)
        {
            int max = 30, min = 14;
            int InputLength = InputTextBox.Text.Length;

            int UpdateSize = max - InputLength;

            if (UpdateSize >= min)
            {
                InputTextBox.FontSize = UpdateSize;
            }
            else
            {
                InputTextBox.FontSize = min;
            }
        }

        private void riml_LayoutUpdated(object sender, EventArgs e)
        {
            int max = 32, min = 21;
            int InputLength = riml.Content.ToString().Length;

            int UpdateSize = max - InputLength;

            if (UpdateSize >= min)
            {
                riml.FontSize = UpdateSize;
            }
            else
            {
                riml.FontSize = min;
            }
        }
    }
}

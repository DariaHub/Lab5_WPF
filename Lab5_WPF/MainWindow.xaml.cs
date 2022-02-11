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

namespace Lab5_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
         
                if (int.TryParse(e.Text, out int i))
                {
                lbl.Content = "Вы пытаетесь ввести цифру";
                e.Handled = true;
                
            }
                else if (e.Text == e.Text.ToLower())
                {
                lbl.Content = "Вы пытаетесь ввести текст в нижнем регистре";
                e.Handled = true;
                
                }

            
            
        }

        private void TB_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (TB.Text == TB.Text.ToLower())
            {
                TB.Text = String.Empty;
            }
        }

        private void TB_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}

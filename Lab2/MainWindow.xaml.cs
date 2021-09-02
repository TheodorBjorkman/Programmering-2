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

namespace Lab2
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
        private void Reverse(object sender, EventArgs e)
        {
            string input = inputRuta.Text;
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                output += input[input.Length - (i + 1)];
            }
            resultatRuta.Text = output;
        }
    }
}

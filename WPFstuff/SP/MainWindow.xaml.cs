using System;
using System.IO;
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
using Microsoft.Win32;

namespace SP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            testBlock.Text = "Test";
        }

        private void TestButton(object sender, RoutedEventArgs e)
        {
            string input = testBox.Text;
            MessageBox.Show(input);
            testBlock.Text = input;
        }
        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Multiselect = true;
            openFileDialog.InitialDirectory = @"c:\";
			if(openFileDialog.ShowDialog() == true)
            {
				foreach(string filename in openFileDialog.FileNames)
					txtBox.Items.Add(System.IO.Path.GetFileName(filename));
            }
		}
    }
}

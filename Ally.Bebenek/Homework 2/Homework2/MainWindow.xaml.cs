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

namespace Homework2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("Hello World");
 
  string a = "one";
  string b = "two";
  string c = "three";
 
  string d = " ";
 
  string stringOutput2 = String.Format("{0}{1}{2}",a,b,c);
            
 
 
  int x = 2;
  int y = 4;
  MessageBox.Show((x * y - x).ToString());
 
  MessageBox.Show(ToString());
 

 
  string quotes = "\"\"\"";
 
  MessageBox.Show(quotes);
 
 
  string backslash = "\\\\\\\\";
 
  MessageBox.Show(backslash);
 
  
 
  string backslashquote1 = "\"\\\"\"";
 
  MessageBox.Show(backslashquote1);
 
  
 
  string backslashquote2 = "\"\\\"\"\"\\\\\\\"\\\"\"";
 
 MessageBox.Show(backslashquote2);

 string nullvalue1 = null;
 MessageBox.Show(nullvalue1);
 

        }

        private void Calendar_SelectedDatesChanged_1(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }
    }
}

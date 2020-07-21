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

namespace WpfCalculation
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

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            Calculate(txtNumber.Text);
        }
        private void Calculate(string strNumber)
        {
            int z = 0; int z2 = 0;
            try
            {
                for (int i = 0; i < Convert.ToInt32(strNumber); i++)
                {
                    z += 1;
                    for (int i2 = 0; i2 < Convert.ToInt32(strNumber)-1; i2++)
                    {
                        z += 1;
                    }

                }
            } catch (Exception ee)
            {
                MessageBox.Show("Exception with data.." + ee);
            }
            lblResult.Content = Convert.ToString(z);

        }
    }
}

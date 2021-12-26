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

namespace Расчет_зп
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

        private void btnTry_Click(object sender, RoutedEventArgs e)
        {
            string pass = tbPassword.Text;
            int passNum = tbPassword.Text.Length;
            int simvol = 0;
            int number = 0;
            int bigBukva = 0;
            for (int i = 0; i < tbPassword.Text.Length; i++)
                if (tbPassword.Text[i] == tbPassword.Text.ToUpper()[i])
                {
                    bigBukva++;
                }
            for (int i = 0; i < tbPassword.Text.Length; i++)
            {
                if (pass.Contains('!')|| pass.Contains('@')||pass.Contains('#') || pass.Contains('$') || pass.Contains('%') || pass.Contains('^'))
                {
                    simvol++;
                }
            }
            for (int i = 0; i < tbPassword.Text.Length; i++)
            {
                if (pass.Contains('0') || pass.Contains('1') || pass.Contains('2') || pass.Contains('3') || pass.Contains('4') || pass.Contains('5') 
                    || pass.Contains('6') || pass.Contains('7') || pass.Contains('8') || pass.Contains('9'))
                {
                    number++;
                }
            }


            if (passNum <6|| simvol <1||bigBukva<1|| number <1)
            {
                MessageBox.Show("Некорректный пароль");
            }
            else
            {
                MessageBox.Show("Корректный пароль");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbPassword.Text = (" ");
        }
    }
}

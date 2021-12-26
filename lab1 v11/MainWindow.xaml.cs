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
using Class1;

namespace lab1_v11
{
    /// <summary>
    /// Найти произведение n целых случайных чисел X., распределенных в
    /// диапазоне от 0 до n.
    /// </summary>
    /// <param name="n">Количество чисел и граница генарции</param>
    /// <returns>Произведение целых случайных чисел и сгенерированные числа </returns>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Соколов К.А. ИСП-34", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Count_Click(object sender, RoutedEventArgs e)
        {

            int value = Convert.ToInt32(Nperem.Text);
            var finding = Class.ProductEvenWithOut(value);
            AllNumbers.Text = finding.allNumbers.ToString();
            Result.Text = finding.calculations;

        }


    }
}

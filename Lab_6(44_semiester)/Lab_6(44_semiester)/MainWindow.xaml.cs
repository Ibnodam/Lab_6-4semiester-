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

namespace Lab_6_44_semiester_
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








        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            try

            {

                lb.Items.Add(Convert.ToInt32(tb_enter.Text.ToString()));

            }
            catch (Exception ex) { MessageBox.Show($"Ошибка. Подробнее:  {ex}"); }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lb.Items.Count >= 1)
                {
                    int count = 0;
                    for (int i = 0; i < lb.Items.Count; i++)
                    {
                        if ((Convert.ToDouble(lb.Items[i]) % 2 != 0)) count++;
                    }

                    int[] mas = new int[count];
                    for (int i = 0; i < lb.Items.Count; i++)
                    {
                        if ((Convert.ToDouble(lb.Items[i]) % 2 != 0)) mas[i] = Convert.ToInt32(lb.Items[i]);
                    }

                    if (count >= 1)
                    {
                        int mult = 1;
                        for (int ii = 0; ii < count; ii++) { if (Convert.ToInt32(mas[ii]) > 0) { mult *= mas[ii]; } }
                        MessageBox.Show($"Произведение положительных чисел массива: {mult}");
                    }
                    else MessageBox.Show("Нечётные числа в данном списке отсутствуют.");
                }
                else MessageBox.Show("Список Мемо пуст!");

            }
            catch (Exception ex) { MessageBox.Show($"Error:  {ex}"); }
        }





    }
}
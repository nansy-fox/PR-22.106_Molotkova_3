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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR_22._106_Molotkova_3
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
        int[] arr;
        private void btnRandomArray_Click(object sender, RoutedEventArgs e)
        {
            lbArray.Items.Clear();
            int N = 0;
            int start = 0;
            int end = 0;
            try
            {
                int.TryParse(TbStart.Text, out start);
                int.TryParse(TbEnd.Text, out end);
                start = int.Parse(TbStart.Text);
                end = int.Parse(TbEnd.Text);

                int.TryParse(TbSIze.Text, out N);
                N = int.Parse(TbSIze.Text);
            }
            catch
            {
                MessageBox.Show("Введено не число! Введите число");
            }

            string s="";
            if (start < end)
            {
                N = int.Parse(TbSIze.Text);
                arr = new int[N];
                Random rnd = new Random();
                for (int i = 0; i <= N - 1; i++)
                {
                    arr[i] = rnd.Next(start, end);
                    s += arr[i] + " ";
                }
                lbArray.Items.Add(s);
            }
            else
            {
                MessageBox.Show("Начальный элемент не может быть больше конечного!");
            }
        }

        private void btSort_Click(object sender, RoutedEventArgs e)
        {
            lbSortArray.Items.Clear();
            string text = "";
            int s = arr.Length - 1;
           
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    for (int j = s; j > i; j--)
                    {
                        if ((arr[j] % 2 == 0) && (s >= 0))
                        {
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                            break;
                        }
                    }
                    s--;
                }
                text += arr[i] + " ";
            }
            lbSortArray.Items.Add(text);
        }
    }
}

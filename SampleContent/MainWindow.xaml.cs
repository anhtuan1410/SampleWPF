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

namespace SampleContent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadCombobox();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            txt.Text = "Hello world!";
            MessageBox.Show("Error");
        }

        void LoadCombobox()
        {
            List<ComboData> ListData = new List<ComboData>();
            ListData.Add(new ComboData { Id = "1", Value = "One" });
            ListData.Add(new ComboData { Id = "2", Value = "Two" });
            ListData.Add(new ComboData { Id = "3", Value = "Three" });
            ListData.Add(new ComboData { Id = "4", Value = "Four" });
            ListData.Add(new ComboData { Id = "5", Value = "Five" });

            cbotest.ItemsSource = ListData;
            cbotest.DisplayMemberPath = "Value";
            cbotest.SelectedValuePath = "Id";

            cbotest.SelectedValue = "2";
        }

        public class ComboData
        {
            public string Id { get; set; }
            public string Value { get; set; }
        }

        private void cbotest_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var t = cbotest.SelectedValue;
            MessageBox.Show(t.ToString());
        }

        private void btnShowup_Click(object sender, RoutedEventArgs e)
        {
            firstForm f = new firstForm();
            f.ShowDialog();
        }
    }
}

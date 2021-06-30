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
using System.Windows.Shapes;

namespace SampleContent
{
    /// <summary>
    /// Interaction logic for firstForm.xaml
    /// </summary>
    public partial class firstForm : Window
    {
        public firstForm()
        {
            InitializeComponent();
        }

        private void btnXemThongTin_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Xin chào " + txtHoDem.Text + " " + txtTen.Text);
            sb.AppendLine("Ngoại ngữ: " + (rdnNam.IsChecked.Value ? "Nam" : rdnNu.IsChecked.Value ? "Nữ" : ""));
            sb.AppendLine("Quê quán: " + (lstBox.SelectedItem as ListBoxItem).Content);
            MessageBox.Show(sb.ToString());
        }
    }
}

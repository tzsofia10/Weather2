using System.IO;
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

namespace Weather
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<idojaras> varosok = new List<idojaras>();
        public MainWindow()
        {
            InitializeComponent();
           
            using StreamReader sr = new StreamReader
                (
                path: @"..\..\..\src\idojarasok.txt",
                encoding: System.Text.Encoding.UTF8
                );
            while ( !sr.EndOfStream)
            {
                varosok.Add(new idojaras(sr.ReadLine()));
            }
            sr.Close();

            foreach(var item in varosok)
            {
                listbox.Items.Add(item.Varos);
            }
        }

        private void Hozzaadas_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.Text != "")
            {
                listbox.Items.Add(textbox.Text);
            }
            else
            {
                MessageBox.Show("Valamit írj be!");
            }
        }

        private void Törlés_Click(object sender, RoutedEventArgs e)
        {
            if(listbox.SelectedItem != null)
            {
                listbox.Items.Remove(listbox.SelectedItem);
            }
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listbox.SelectedItem!=null)
            {
                int index = listbox.SelectedIndex;
                label1.Content = varosok[index].Homerseklet;
                label2.Content= varosok[index].Paratartalom;
                
            }
        }
    }
}
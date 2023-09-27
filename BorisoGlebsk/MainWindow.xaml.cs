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
using KakiaLib;

namespace BorisoGlebsk
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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            JsonEditor.Serialize<String>(TextBoxName.Text, "./data.json");
            SaveButton.Content = "Сохранено!";
            
        }

        private void ReadButton_Click(object sender, RoutedEventArgs e)
        {
            TextBlockName.Text = JsonEditor.Deserialize<String>("./data.json");
        }
    }
}

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
using WPF_UI.View;

namespace WPF_UI
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

        // закрываем окно
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // проверяем введенные данные
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string password = GetPassword(txtPassword);
            if (txtUserName.Text == "qqqq"&&password=="1111")
            {
                MenuWindow window = new MenuWindow();
                window.Show();
            }
            else
            {
                string s = "OOOOOPSS!!!!";
                MessageBox.Show(s);
            }
        }
        // метод для получения текста из PasswordBox
        public static string GetPassword(PasswordBox passwordBox)
        {
            string password = string.Empty;
            foreach(char c in passwordBox.Password)
            {
                password += c;
            }
            return password;
        }
    }
}

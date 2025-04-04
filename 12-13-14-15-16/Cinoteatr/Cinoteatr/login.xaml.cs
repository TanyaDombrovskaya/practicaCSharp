using System.IO;
using System.Linq;
using System.Windows;
using Newtonsoft.Json;
using System.IO.MemoryMappedFiles;

namespace Cinoteatr
{
    /// <summary>
    /// Логика взаимодействия для login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordBox.Password;

            UsersList usersList = LoadUsersFromJson("users.json");

            User loggedInUser = usersList.Users.FirstOrDefault(user => user.Email == email && user.Password == password);

            if (loggedInUser != null)
            {
                this.Hide();
                MainWindow main = new MainWindow();
                main.Show();
            }
            else
            {
                MessageBox.Show("Неверные учетные данные. Попробуйте снова.");
            }

            using (var mmf = MemoryMappedFile.CreateNew("CinemaSessions", 1024))
            {
                using (var stream = mmf.CreateViewStream())
                {
                    using (var writer = new StreamWriter(stream))
                    {
                        writer.AutoFlush = true;

                        writer.WriteLine("Новый сеанс: Фильм 'SuperMan' в 19:00 на 01.10.2023");
                    }
                }
            }
        }

        private UsersList LoadUsersFromJson(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<UsersList>(json);
            }
        }
    }
}

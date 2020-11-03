using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.IO;

namespace CustomerAppointmentManager
{
    public partial class LoginForm : Form
    {

        DatabaseConnection con = new DatabaseConnection();
        string id, username, password;


        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            try
            {
                UserOrPWBlank();
            }
            catch (LoginException loginException)
            {
                Console.WriteLine("\n" + loginException.Message);
                return;
            }

            con.Open();
            string query = "select userId,username,password from user WHERE username ='" + userNameTxBx.Text + "' AND password ='" + pwdTxBox.Text + "'";
            MySqlDataReader row;
            row = con.ExecuteReader(query);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    id = row["userId"].ToString();
                    username = row["username"].ToString();
                    password = row["password"].ToString();

                }

                CurrentOnlineUser.currentOnlineUserName = username;
                CurrentOnlineUser.currentOnlineUserID = id;

                FifteenMinutePrompt.checkSchedule();

                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
                WriteToLog(Int32.Parse(id), username);
            }
            else
            {
                errorLabel.Show();
             }

            con.Close();
        }

    public LoginForm()
    {
        InitializeComponent();
        IdentifyWindowsLanguage();
        
    }

        private void IdentifyWindowsLanguage()
        {
            switch (RegionInfo.CurrentRegion.EnglishName)//The full name of the country/region in English.
            {
                case "United States":
                    InEnglish();
                    break;
                case "Mexico":
                    InSpanish();
                    break;

                default:
                    InEnglish();
                    break;
            }
        }

        private void InEnglish()
        {
            this.Text = "Log In";
            loginTitleLabel.Text = "Customer Appointment Management Application";
            usernameLabel.Text = "Username";
            passwordLabel.Text = "Password";
            btnLogin.Text = "Log In";
            errorLabel.Text = "Username and password combination not found!";
        }

        private void InSpanish()
        {
            this.Text = "Iniciar sesión";
            loginTitleLabel.Text = "Aplicación de gestión de citas de clientes";
            usernameLabel.Text = "Nombre de usuario";
            passwordLabel.Text = "Contraseña";
            btnLogin.Text = "Iniciar sesión";
            errorLabel.Text = "¡No se encontró la combinación de nombre de usuario y contraseña!";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = userNameTxBx;
            errorLabel.Hide();
        }

        private void WriteToLog(int userId, string userName)
        {

            var Records = new List<LoginRecord>
            {
                 new LoginRecord() { UserID = userId, UserName = userName, Date = DateTime.UtcNow }
            };
    
            //If the file exists, it can be either overwritten or appended to. If the file does not exist, this constructor creates a new file.

            StreamWriter writer = new StreamWriter("appointmentLog.txt", true);

            foreach ( LoginRecord record in Records)
            {
                writer.WriteLine($"User Id: { record.UserID}, User name: { record.UserName}, Log In Date/Time (UTC): {record.Date}");
            }
           

            writer?.Close();

        }

        public bool UserOrPWBlank()
        {

            if(userNameTxBx.Text == "" && pwdTxBox.Text == "")
            {
                if (RegionInfo.CurrentRegion.EnglishName == "Mexico")
                {
                    throw new LoginException("l nombre de usuario y la contraseña no pueden estar en blanco!");
                }
                    throw new LoginException("Username and password cannot be blank!");
            }
            else
            {
                return false;
            }
        }
    }
}

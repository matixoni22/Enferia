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

using System.Data.SqlClient;
using System.Data;
using Enferia.Models;
using Enferia.Views;

namespace Enferia.Models
{
    class LoggingSystem
    {
        private string login_Text;
        private string pass_Text;

        public LoggingSystem (string l_text, string p_text)
        {
            this.login_Text = l_text;
            this.pass_Text = p_text;
        }
        public string Login_Passing()
        {
            SqlConnection sql_conaction = new SqlConnection("Data Source=MATIXONIPC; Initial Catalog=Enferia_database; Integrated Security=True"); //tworzenie połączenia
            SqlCommand sql_cmd = new SqlCommand("SELECT user_login FROM dbo.Users WHERE @user_login IN (user_login, user_email) AND user_password = @user_password", sql_conaction); //tworzenie komendy szukania odpowiedniego konta

            if ((string.IsNullOrWhiteSpace(login_Text) || string.IsNullOrWhiteSpace(pass_Text))) //sprawdzanie czy hasło lub login jest wpisany
            {
                return "Login i hasło muszą być wpisane!";
            }
            else
            {
                 {
                    sql_cmd.Parameters.Add("@user_password", SqlDbType.VarChar); // adding the password
                    sql_cmd.Parameters["@user_password"].Value = pass_Text; //paste the parrameter to 

                    sql_cmd.Parameters.Add("@user_login", SqlDbType.VarChar); // dodawanie parametru
                    sql_cmd.Parameters["@user_login"].Value = login_Text; //przypisywanie parametru do wartości textboxa

                    sql_conaction.Open();
                    if (login_Text == (string)sql_cmd.ExecuteScalar()) //executescalar wyświetla nam dane dane przez szukanych parametrach
                    {
                        sql_conaction.Close();
                        return "Logowanie się powiodło!";
                    }
                    else
                    {
                        sql_conaction.Close();
                        return "Błędne hasło lub login!";
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using Enferia.Models;
using Caliburn.Micro;

namespace Enferia.ViewModels
{
    class LoginPageViewModel : Screen
    {
        private readonly UserLoginParameters _user;

        public LoginPageViewModel()
        {
            _user = new UserLoginParameters();
        }

        public string login_TextBox
        {
            get { return _user.login_TextBox; }
            set
            {
                _user.login_TextBox = value;
                NotifyOfPropertyChange("login_TextBox");
            }
        }

        public string password_TextBox
        {
            get { return _user.password_TextBox; }
            set
            {
                _user.password_TextBox = value;
                NotifyOfPropertyChange("password_TextBox");
            }
        }

        public void login_Button() //logging button 
        {
            LoggingSystem login_system = new LoggingSystem(_user.login_TextBox, _user.password_TextBox);
            MessageBox.Show(login_system.Login_Passing());
        }

        /* protected override void OnViewLoaded(object view)
         {
             base.OnViewLoaded(view);
             login_TextBox = "login";
             password_TextBox = "password";
         }*/

    }
}

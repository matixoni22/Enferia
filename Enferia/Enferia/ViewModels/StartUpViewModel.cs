using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;


namespace Enferia.ViewModels
{
    class StartUpViewModel : Conductor<object>.Collection.OneActive 
    {
        private LoginPageViewModel log = new LoginPageViewModel();
        private RegistrationPageViewModel reg = new RegistrationPageViewModel();
        public StartUpViewModel()
        {
            ActivateItem(log);
        }
        
        public void aboutPage_Button()
        {
            MessageBox.Show("ja to ja");
        }

        public void registryPage_Button()
        {
            ActivateItem(reg);
        }
        
        public void loginPage_Button()
        {
            ActivateItem(log);
        }
   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace Enferia.ViewModels
{
    class MainWindowViewModel : Conductor<object>
    {
        private LoginPageViewModel log_Page = new LoginPageViewModel();
        private RegistrationPageViewModel reg = new RegistrationPageViewModel();
        private LoginPageNavigationViewModel nav_Bar = new LoginPageNavigationViewModel();

        public MainWindowViewModel()
        {    
            ActivateItem(log_Page);
        }
    }
}

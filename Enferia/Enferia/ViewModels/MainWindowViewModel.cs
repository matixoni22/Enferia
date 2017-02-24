using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace Enferia.ViewModels
{
    class MainWindowViewModel : Conductor<IScreen>
    {
        public MainWindowViewModel()
        {
            ActivateItem(new StartUpViewModel());
        }
    }
}

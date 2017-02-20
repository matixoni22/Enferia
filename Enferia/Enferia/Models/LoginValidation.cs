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
using Enferia;
using System.Data;

namespace Enferia.Models
{
    class LoginValidation
    {
        private string text;

        public LoginValidation(TextBox log_box)
        {
            this.text = log_box.Text.ToString();
        }

        private bool IsValid()
        {
            if (text.Length <= 24 || text.Length >= 6)
                return true;
            else
                return false;
        }

    }
}

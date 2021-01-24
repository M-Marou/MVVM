using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMP1.ViewModels
{
    class ShellViewModel : Screen
    {
        private string _firstName = "MarOne";

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; NotifyOfPropertyChange(() => FirstName); }
        }

    }
}

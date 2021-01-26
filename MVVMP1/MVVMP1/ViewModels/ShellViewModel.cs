using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMP1.ViewModels
{
    class ShellViewModel : Conductor<Object>
    {
        private string _firstName = "MarOne";
        private string _lastName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; 
                NotifyOfPropertyChange(() => FirstName); 
                NotifyOfPropertyChange(() => FullName); }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; 
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName); }
        }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public void LoadPageOne()
        {
            ActivateItem(new FirstChildViewModel());
        }

        public void LoadPageTwo()
        {
            ActivateItem(new SecondChildViewModel());
        }
    }
}

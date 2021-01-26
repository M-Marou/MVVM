using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGV.ViewModels
{
    public class ShellViewModel : Conductor<Object>
    {
        public void BtnDisplay ()
        {
            ActivateItem(new DisplayViewModel());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.Data;
using Catel.MVVM;

namespace TrinityCore_Manager.ViewModels.Wizard
{
    public class WizardRADetailsViewModel : ViewModelBase
    {

        public WizardRADetailsViewModel()
        {
        }

        public string Host
        {
            get
            {
                return GetValue<string>(HostProperty);
            }
            set
            {
                SetValue(HostProperty, value);
            }
        }

        public static readonly PropertyData HostProperty = RegisterProperty("Host", typeof(string));

        public int Port
        {
            get
            {
                return GetValue<int>(PortProperty);
            }
            set
            {
                SetValue(PortProperty, value);
            }
        }

        public static readonly PropertyData PortProperty = RegisterProperty("Port", typeof(int), 3443);

        public string Username
        {
            get
            {
                return GetValue<string>(UsernameProperty);
            }
        }

        public static readonly PropertyData UsernameProperty = RegisterProperty("Username", typeof(string));

        public string Password
        {
            get
            {
                return GetValue<string>(PasswordProperty);
            }
            set
            {
                SetValue(PasswordProperty, value);
            }
        }

        public static readonly PropertyData PasswordProperty = RegisterProperty("Password", typeof(string));

    }
}

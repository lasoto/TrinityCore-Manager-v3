using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.Data;
using Catel.MVVM;

namespace TrinityCore_Manager.ViewModels.Wizard
{
    public class WizardTrinityServerFolderViewModel : ViewModelBase
    {

        public WizardTrinityServerFolderViewModel()
        {
        }

        public string ServerFolderLocation
        {
            get
            {
                return GetValue<string>(ServerFolderLocationProperty);
            }
            set
            {
                SetValue(ServerFolderLocationProperty, value);
            }
        }

        public static readonly PropertyData ServerFolderLocationProperty = RegisterProperty("ServerFolderLocation", typeof(string));

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.Data;
using Catel.MVVM;

namespace TrinityCore_Manager.ViewModels.Wizard
{
    public class WizardConnectOptionViewModel : ViewModelBase
    {

        public WizardConnectOptionViewModel()
        {
        }

        public bool ConnectRemotely
        {
            get
            {
                return GetValue<bool>(ConnectRemotelyProperty);
            }
            set
            {
                SetValue(ConnectRemotelyProperty, value);
            }
        }

        public static readonly PropertyData ConnectRemotelyProperty = RegisterProperty("ConnectRemotely", typeof(bool));

        public bool ConnectLocally
        {
            get
            {
                return GetValue<bool>(ConnectLocallyProperty);
            }
            set
            {
                SetValue(ConnectLocallyProperty, value);
            }
        }

        public static readonly PropertyData ConnectLocallyProperty = RegisterProperty("ConnectLocally", typeof(bool), true);

    }
}

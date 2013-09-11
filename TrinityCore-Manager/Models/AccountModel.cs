using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Catel.Data;

namespace TrinityCore_Manager.Models
{
    [Serializable]
    public class AccountModel : ModelBase
    {

        public AccountModel(string username)
        {
            Username = username;
        }

        protected AccountModel(SerializationInfo info, StreamingContext context)
            : base(info, context) { }

        public string Username
        {
            get
            {
                return GetValue<string>(UsernameProperty);
            }
            set
            {
                SetValue(UsernameProperty, value);
            }
        }

        public static readonly PropertyData UsernameProperty = RegisterProperty("Username", typeof(string), string.Empty);

    }
}

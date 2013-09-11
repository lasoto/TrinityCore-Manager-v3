using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore_Manager.Extensions
{
    public static class AttributeExtensions
    {

        /* http://codereview.stackexchange.com/questions/5352/getting-the-value-of-a-custom-attribute-from-an-enum */
        public static TAttribute GetAttribute<TAttribute>(this Enum value)
       where TAttribute : Attribute
        {
            var type = value.GetType();
            var name = Enum.GetName(type, value);
            return type.GetField(name)
                .GetCustomAttributes(false)
                .OfType<TAttribute>()
                .SingleOrDefault();
        }

    }
}

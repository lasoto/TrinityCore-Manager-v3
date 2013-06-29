using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore_Manager.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class CharacterClassInfoAttribute : Attribute
    {

        public int Id { get; set; }
        public int BitmaskValue { get; set; }

        public CharacterClassInfoAttribute(int id, int bitmaskVal)
        {
            Id = id;
            BitmaskValue = bitmaskVal;
        }

    }
}

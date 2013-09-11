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

        public string Name { get; set; }
        public int Id { get; set; }
        public int BitmaskValue { get; set; }

        public CharacterClassInfoAttribute(string name, int id, int bitmaskVal)
        {
            Name = name;
            Id = id;
            BitmaskValue = bitmaskVal;
        }

    }
}

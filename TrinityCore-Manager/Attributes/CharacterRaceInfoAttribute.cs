using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore_Manager.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class CharacterRaceInfoAttribute : Attribute
    {

        public string Name { get; set; }
        public int Id { get; set; }
        public int BitmaskValue { get; set; }

        public CharacterRaceInfoAttribute(string name, int id, int bitmaskVal)
        {
            Name = name;
            Id = id;
            BitmaskValue = bitmaskVal;
        }

    }
}

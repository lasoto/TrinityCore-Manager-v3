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

        public int Id { get; set; }
        public int BitmaskValue { get; set; }

        public CharacterRaceInfoAttribute(int id, int bitmaskVal)
        {
            Id = id;
            BitmaskValue = bitmaskVal;
        }

    }
}

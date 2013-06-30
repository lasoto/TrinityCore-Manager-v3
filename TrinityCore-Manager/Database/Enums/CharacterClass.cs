using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore_Manager.Attributes;
using TrinityCore_Manager.Extensions;

namespace TrinityCore_Manager.Database.Enums
{

    public enum CharacterClass
    {

        [CharacterClassInfo("Warrior", 1, 1)]
        Warrior,

        [CharacterClassInfo("Paladin", 2, 2)]
        Paladin,

        [CharacterClassInfo("Hunter", 3, 4)]
        Hunter,

        [CharacterClassInfo("Rogue", 4, 8)]
        Rogue,

        [CharacterClassInfo("Priest", 5, 16)]
        Priest,

        [CharacterClassInfo("Death Knight", 6, 32)]
        DeathKnight,

        [CharacterClassInfo("Shaman", 7, 64)]
        Shaman,

        [CharacterClassInfo("Mage", 8, 128)]
        Mage,

        [CharacterClassInfo("Warlock", 9, 256)]
        Warlock,

        [CharacterClassInfo("Druid", 11, 1024)]
        Druid

    }

    public static class CharacterClassHelper
    {

        public static CharacterClass GetCharacterClass(int id)
        {

            var vals = Enum.GetValues(typeof(CharacterRace));

            foreach (var val in vals)
            {

                CharacterClass cl = (CharacterClass)val;

                if (cl.GetCharacterClassId() == id)
                    return cl;

            }

            return CharacterClass.Mage;

        }

    }

    public static class CharacterClassExtensions
    {

        public static string GetCharacterClassName(this CharacterClass cl)
        {

            var attrib = cl.GetAttribute<CharacterClassInfoAttribute>();

            return attrib.Name;

        }

        public static int GetCharacterClassId(this CharacterClass cl)
        {

            var attrib = cl.GetAttribute<CharacterClassInfoAttribute>();

            return attrib.Id;

        }

        public static int GetCharacterClassBitmask(this CharacterClass cl)
        {

            var attrib = cl.GetAttribute<CharacterRaceInfoAttribute>();

            return attrib.BitmaskValue;

        }

    }

}

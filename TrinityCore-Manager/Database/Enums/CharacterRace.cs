using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore_Manager.Attributes;
using TrinityCore_Manager.Extensions;

namespace TrinityCore_Manager.Database.Enums
{

    public enum CharacterRace
    {

        [CharacterRaceInfo("Human", 1, 1)]
        Human,

        [CharacterRaceInfo("Orc", 2, 2)]
        Orc,

        [CharacterRaceInfo("Dwarf", 3, 4)]
        Dwarf,

        [CharacterRaceInfo("Night Elf", 4, 8)]
        NightElf,

        [CharacterRaceInfo("Undead", 5, 16)]
        Undead,

        [CharacterRaceInfo("Tauren", 6, 32)]
        Tauren,

        [CharacterRaceInfo("Gnome", 7, 64)]
        Gnome,

        [CharacterRaceInfo("Troll", 8, 128)]
        Troll,

        [CharacterRaceInfo("Blood Elf", 10, 512)]
        BloodElf,

        [CharacterRaceInfo("Draenei", 11, 1024)]
        Draenei

    }

    public static class CharacterRaceHelper
    {

        public static CharacterRace GetCharacterRace(int id)
        {

            var vals = Enum.GetValues(typeof(CharacterRace));

            foreach (var val in vals)
            {

                CharacterRace race = (CharacterRace)val;

                if (race.GetCharacterRaceId() == id)
                    return race;

            }

            return CharacterRace.Human;
            
        }

    }

    public static class CharacterRaceExtensions
    {

        public static string GetCharacterRaceName(this CharacterRace race)
        {

            var attrib = race.GetAttribute<CharacterRaceInfoAttribute>();

            return attrib.Name;

        }

        public static int GetCharacterRaceId(this CharacterRace race)
        {

            var attrib = race.GetAttribute<CharacterRaceInfoAttribute>();

            return attrib.Id;

        }

        public static int GetCharacterRaceBitmask(this CharacterRace race)
        {

            var attrib = race.GetAttribute<CharacterRaceInfoAttribute>();

            return attrib.BitmaskValue;

        }

    }

}

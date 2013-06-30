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

        [CharacterRaceInfo(1, 1)]
        Human,

        [CharacterRaceInfo(2, 2)]
        Orc,

        [CharacterRaceInfo(3, 4)]
        Dwarf,

        [CharacterRaceInfo(4, 8)]
        NightElf,

        [CharacterRaceInfo(5, 16)]
        Scourge,

        [CharacterRaceInfo(6, 32)]
        Tauren,

        [CharacterRaceInfo(7, 64)]
        Gnome,

        [CharacterRaceInfo(8, 128)]
        Troll,

        [CharacterRaceInfo(10, 512)]
        BloodElf,

        [CharacterRaceInfo(11, 1024)]
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

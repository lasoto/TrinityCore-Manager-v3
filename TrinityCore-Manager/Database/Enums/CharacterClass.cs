using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore_Manager.Attributes;

namespace TrinityCore_Manager.Database.Enums
{
    public enum CharacterClass
    {

        [CharacterClassInfo(1, 1)]
        Warrior,

        [CharacterClassInfo(2, 2)]
        Paladin,

        [CharacterClassInfo(3, 4)]
        Hunter,

        [CharacterClassInfo(4, 8)]
        Rogue,

        [CharacterClassInfo(5, 16)]
        Priest,

        [CharacterClassInfo(6, 32)]
        DeathKnight,

        [CharacterClassInfo(7, 64)]
        Shaman,

        [CharacterClassInfo(8, 128)]
        Mage,

        [CharacterClassInfo(9, 256)]
        Warlock,

        [CharacterClassInfo(11, 1024)]
        Druid

    }
}

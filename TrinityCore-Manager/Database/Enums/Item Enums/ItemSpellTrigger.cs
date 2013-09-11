using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore_Manager.Database.Enums.Item_Enums
{
    public enum ItemSpellTrigger
    {
        OnUse = 0,
        OnEquip = 1,
        ChanceOnHit = 2,
        Soulstone = 4,
        UseWithNoDelay = 5,
        LearnSpellID = 6
    }
}

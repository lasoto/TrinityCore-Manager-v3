using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore_Manager.Database.Enums.Item_Enums
{
    public enum ItemBonding
    {
        NoBind = 0,
        BindsWhenPickedUp = 1,
        BindsWhenEquipped = 2,
        BindsWhenUsed = 3,
        QuestItem = 4,
        QuestItem1 = 5
    }
}

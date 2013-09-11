using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore_Manager.Database.Enums.SmartAI_Enums
{
    public enum SmartSummonType
    {
        TEMPSUMMON_TIMED_OR_DEAD_DESPAWN = 1,
        TEMPSUMMON_TIMED_OR_CORPSE_DESPAWN = 2,
        TEMPSUMMON_TIMED_DESPAWN = 3,
        TEMPSUMMON_TIMED_DESPAWN_OUT_OF_COMBAT = 4,
        TEMPSUMMON_CORPSE_DESPAWN = 5,
        TEMPSUMMON_CORPSE_TIMED_DESPAWN = 6,
        TEMPSUMMON_DEAD_DESPAWN = 7,
        TEMPSUMMON_MANUAL_DESPAWN = 8
    }
}

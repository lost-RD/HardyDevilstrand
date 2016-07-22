using RimWorld;
using Verse;

namespace HardyDevilstrand
{
    [StaticConstructorOnStartup]
    public class ModifyDefs
    {

        public static void ModifyDevilstrand()
        {
            DefDatabase<ThingDef>.GetNamed("PlantDevilstrand", true).plant.dieIfLeafless = false;
        }

        static ModifyDefs()
        {
            ModifyDevilstrand();
        }
    }
}

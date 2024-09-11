using MelonLoader;
using BTD_Mod_Helper;
using GrammarsGlobalMIB;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Simulation.Towers;

[assembly: MelonInfo(typeof(GrammarsGlobalMIB.GrammarsGlobalMIB), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace GrammarsGlobalMIB
{
    public class GrammarsGlobalMIB : BloonsTD6Mod
    {
        public override void OnApplicationStart()
        {
            ModHelper.Msg<GrammarsGlobalMIB>("GrammarsGlobalMIB loaded!");  
        }
        public override void OnTowerUpgraded(Tower tower, string upgradeName, TowerModel newBaseTowerModel)
        {
            if (upgradeName == "Monkey Intelligence Bureau" || upgradeName == "Call to Arms" || upgradeName == "Homeland Defense")
            {
                newBaseTowerModel.range = 9999;
                ModHelper.Msg<GrammarsGlobalMIB>("MIB buffed");
            }
        }
    }
}
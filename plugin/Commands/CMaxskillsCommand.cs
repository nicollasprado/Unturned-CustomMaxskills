using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using Rocket.Unturned.Skills;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMaxskills.Commands
{
    internal class CMaxskillsCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "skills";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>();

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer player = caller as UnturnedPlayer;

            if (player.HasPermission(CustomMaxskills.Main.Configuration.Instance.Permission))
            {
                player.SetSkillLevel(UnturnedSkill.Overkill, CustomMaxskills.Main.Configuration.Instance.OverkillLevel);
                player.SetSkillLevel(UnturnedSkill.Sharpshooter, CustomMaxskills.Main.Configuration.Instance.SharpshooterLevel);
                player.SetSkillLevel(UnturnedSkill.Dexerity, CustomMaxskills.Main.Configuration.Instance.DexterityLevel);
                player.SetSkillLevel(UnturnedSkill.Cardio, CustomMaxskills.Main.Configuration.Instance.CardioLevel);
                player.SetSkillLevel(UnturnedSkill.Exercise, CustomMaxskills.Main.Configuration.Instance.ExerciseLevel);
                player.SetSkillLevel(UnturnedSkill.Diving, CustomMaxskills.Main.Configuration.Instance.DivingLevel);
                player.SetSkillLevel(UnturnedSkill.Parkour, CustomMaxskills.Main.Configuration.Instance.ParkourLevel);
                player.SetSkillLevel(UnturnedSkill.Sneakybeaky, CustomMaxskills.Main.Configuration.Instance.SneakybeakyLevel);
                player.SetSkillLevel(UnturnedSkill.Vitality, CustomMaxskills.Main.Configuration.Instance.VitalityLevel);
                player.SetSkillLevel(UnturnedSkill.Survival, CustomMaxskills.Main.Configuration.Instance.SurvivalLevel);
                player.SetSkillLevel(UnturnedSkill.Healing, CustomMaxskills.Main.Configuration.Instance.HealingLevel);
                player.SetSkillLevel(UnturnedSkill.Crafting, CustomMaxskills.Main.Configuration.Instance.CraftingLevel);
                player.SetSkillLevel(UnturnedSkill.Outdoors, CustomMaxskills.Main.Configuration.Instance.OutdoorsLevel);
                player.SetSkillLevel(UnturnedSkill.Cooking, CustomMaxskills.Main.Configuration.Instance.CookingLevel);
                player.SetSkillLevel(UnturnedSkill.Fishing, CustomMaxskills.Main.Configuration.Instance.FishingLevel);
                player.SetSkillLevel(UnturnedSkill.Agriculture, CustomMaxskills.Main.Configuration.Instance.AgricultureLevel);
                player.SetSkillLevel(UnturnedSkill.Mechanic, CustomMaxskills.Main.Configuration.Instance.MechanicLevel);
                player.SetSkillLevel(UnturnedSkill.Engineer, CustomMaxskills.Main.Configuration.Instance.EngineerLevel);
                player.SetSkillLevel(UnturnedSkill.Immunity, CustomMaxskills.Main.Configuration.Instance.ImmunityLevel);
                player.SetSkillLevel(UnturnedSkill.Toughness, CustomMaxskills.Main.Configuration.Instance.ToughnessLevel);
                player.SetSkillLevel(UnturnedSkill.Warmblooded, CustomMaxskills.Main.Configuration.Instance.WarmbloodedLevel);
                player.SetSkillLevel(UnturnedSkill.Strength, CustomMaxskills.Main.Configuration.Instance.StrengthLevel);

                UnturnedChat.Say(player, CustomMaxskills.Main.Translate("MessageOnReceiveSkills"));
            }
            else
            {
                UnturnedChat.Say(player, CustomMaxskills.Main.Translate("NoPermission"));
            }
        }
    }
}

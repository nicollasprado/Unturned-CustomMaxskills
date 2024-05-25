using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using Rocket.Unturned.Skills;
using Rocket.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.API.Collections;

namespace CustomMaxskills
{
    public class CustomMaxskills : RocketPlugin<CustomMaxskillsConfiguration>
    {
        public static CustomMaxskills Main { get; private set; }

        protected override void Load()
        {
            Main = this;

            Logger.Log($"{Name} {Assembly.GetName().Version} has been sucefully loaded!");

            U.Events.OnPlayerConnected += OnPlayerConnected;
        }

        protected override void Unload()
        {
            Logger.Log($"{Name} unloaded");

            U.Events.OnPlayerConnected -= OnPlayerConnected;
        }

        public override TranslationList DefaultTranslations => new TranslationList()
        {
            { "NoPermission", "You dont have permission to use this command!"},
            { "MessageOnReceiveSkills", "You got some skills!"},
            { "MessageOnReceiveSkillsOnEnterServer", "Welcome, you got some skills!"}
        };

        public void OnPlayerConnected(UnturnedPlayer player)
        {
            if (Configuration.Instance.GetSkillsOnEnter == true)
            {
                player.SetSkillLevel(UnturnedSkill.Overkill, Configuration.Instance.OverkillLevel);
                player.SetSkillLevel(UnturnedSkill.Sharpshooter, Configuration.Instance.SharpshooterLevel);
                player.SetSkillLevel(UnturnedSkill.Dexerity, Configuration.Instance.DexterityLevel);
                player.SetSkillLevel(UnturnedSkill.Cardio, Configuration.Instance.CardioLevel);
                player.SetSkillLevel(UnturnedSkill.Exercise, Configuration.Instance.ExerciseLevel);
                player.SetSkillLevel(UnturnedSkill.Diving, Configuration.Instance.DivingLevel);
                player.SetSkillLevel(UnturnedSkill.Parkour, Configuration.Instance.ParkourLevel);
                player.SetSkillLevel(UnturnedSkill.Sneakybeaky, Configuration.Instance.SneakybeakyLevel);
                player.SetSkillLevel(UnturnedSkill.Vitality, Configuration.Instance.VitalityLevel);
                player.SetSkillLevel(UnturnedSkill.Survival, Configuration.Instance.SurvivalLevel);
                player.SetSkillLevel(UnturnedSkill.Healing, Configuration.Instance.HealingLevel);
                player.SetSkillLevel(UnturnedSkill.Crafting, Configuration.Instance.CraftingLevel);
                player.SetSkillLevel(UnturnedSkill.Outdoors, Configuration.Instance.OutdoorsLevel);
                player.SetSkillLevel(UnturnedSkill.Cooking, Configuration.Instance.CookingLevel);
                player.SetSkillLevel(UnturnedSkill.Fishing, Configuration.Instance.FishingLevel);
                player.SetSkillLevel(UnturnedSkill.Agriculture, Configuration.Instance.AgricultureLevel);
                player.SetSkillLevel(UnturnedSkill.Mechanic, Configuration.Instance.MechanicLevel);
                player.SetSkillLevel(UnturnedSkill.Engineer, Configuration.Instance.EngineerLevel);
                player.SetSkillLevel(UnturnedSkill.Immunity, Configuration.Instance.ImmunityLevel);
                player.SetSkillLevel(UnturnedSkill.Toughness, Configuration.Instance.ToughnessLevel);
                player.SetSkillLevel(UnturnedSkill.Warmblooded, Configuration.Instance.WarmbloodedLevel);
                player.SetSkillLevel(UnturnedSkill.Strength, Configuration.Instance.StrengthLevel);
                UnturnedChat.Say(player, Main.Translate("MessageOnReceiveSkillsOnEnterServer"));
            }
        }
    }
}

using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMaxskills
{
    public class CustomMaxskillsConfiguration : IRocketPluginConfiguration
    {
        public bool GetSkillsOnEnter { get; set; }

        public string Permission { get; set; }

        public byte OverkillLevel { get; set; }

        public byte SharpshooterLevel { get; set; }

        public byte DexterityLevel { get; set; }

        public byte CardioLevel { get; set; }

        public byte ExerciseLevel { get; set; }

        public byte DivingLevel { get; set; }

        public byte ParkourLevel { get; set; }

        public byte SneakybeakyLevel { get; set; }

        public byte VitalityLevel { get; set; }

        public byte ImmunityLevel { get; set; }

        public byte ToughnessLevel { get; set; }

        public byte StrengthLevel { get; set; }

        public byte WarmbloodedLevel { get; set; }

        public byte SurvivalLevel { get; set; }

        public byte HealingLevel { get; set; }

        public byte CraftingLevel { get; set; }

        public byte OutdoorsLevel { get; set; }

        public byte CookingLevel { get; set; }

        public byte FishingLevel { get; set; }

        public byte AgricultureLevel { get; set; }

        public byte MechanicLevel { get; set; }

        public byte EngineerLevel { get; set; }

        public void LoadDefaults()
        {
            GetSkillsOnEnter = true;
            Permission = "customMaxskills.skills";
            OverkillLevel = 7;
            SharpshooterLevel = 7;
            DexterityLevel = 5;
            CardioLevel = 5;
            ExerciseLevel = 5;
            DivingLevel = 5;
            ParkourLevel = 5;
            SneakybeakyLevel = 7;
            VitalityLevel = 5;
            ImmunityLevel = 5;
            ToughnessLevel = 5;
            StrengthLevel = 5;
            WarmbloodedLevel = 5;
            SurvivalLevel = 5;
            HealingLevel = 7;
            CraftingLevel = 3;
            OutdoorsLevel = 5;
            CookingLevel = 3;
            FishingLevel = 5;
            AgricultureLevel = 7;
            MechanicLevel = 5;
            EngineerLevel = 3;
        }
    }
}

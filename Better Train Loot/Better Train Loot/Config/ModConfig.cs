﻿namespace BetterTrainLoot.Config
{
    public class ModConfig
    {
        public bool enableMod { get; set; }
        public bool useCustomTrainTreasure { get; set; }
        public bool enableNoLimitTreasurePerTrain { get; set; }
        public bool showTrainingIsComingMessage { get; set; }
        public bool enableTrainWhistle { get; set; }
        public double baseChancePercent { get; set; }
        public double basePctChanceOfTrain { get; set; }
        public int trainCreateDelay { get; set; }
        public int maxTrainsPerDay { get; set; }
        public int maxNumberOfItemsPerTrain { get; set; }
        public bool enableForceCreateTrain { get; set; }
        public bool enableMultiplayerChatMessage { get; set; }
        public int configVersion { get; set; }
    }
}

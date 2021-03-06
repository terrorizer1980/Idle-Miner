﻿using Newtonsoft.Json;

namespace PG.IdleMiner.Models.DataModels
{
    public class ShaftLevelData
    {
        [JsonProperty("Miners")]
        public int Miners;

        [JsonProperty("WalkSpeed")]
        public int WalkSpeed;

        [JsonProperty("MinningSpeed")]
        public double MinningSpeed;

        [JsonProperty("WorkerCapacity")]
        public double WorkerCapacity;

        [JsonProperty("UpgradeCost")]
        public double UpgradeCost;
    }
}
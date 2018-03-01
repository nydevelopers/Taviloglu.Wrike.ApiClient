﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Taviloglu.Wrike.Core
{
    public sealed class WrikeWebHookTaskResponsiblesAddedEvent : WrikeWebHookEvent
    {
        [JsonProperty("addedResponsibles")]
        public List<string> AddedResponsibles { get; set; }
    }
}

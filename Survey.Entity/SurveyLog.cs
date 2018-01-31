using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class SurveyLog : EntityBaseInt
    {
        [JsonProperty("date")]
        public DateTimeOffset? Date { get; set; }

        [JsonProperty("thread")]
        public string Thread { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("logger")]
        public string Logger { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("exception")]
        public string Exception { get; set; }
        
    }
}

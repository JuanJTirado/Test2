using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class SurveyLog : EntityBase
    {
        [JsonProperty("id")]
        public int Id { get; set; }

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

        public override string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

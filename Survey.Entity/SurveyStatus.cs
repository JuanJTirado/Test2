using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class SurveyStatus: EntityBase
    {
        public SurveyStatus()
        {
            Surveys = new HashSet<Surveys>();
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("surveys")]
        public ICollection<Surveys> Surveys { get; set; }

        public override string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

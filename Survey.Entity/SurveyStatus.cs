using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class SurveyStatus: EntityBaseInt
    {
        public SurveyStatus()
        {
            Surveys = new HashSet<Surveys>();
        }
        
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("surveys")]
        public ICollection<Surveys> Surveys { get; set; }
        
    }
}

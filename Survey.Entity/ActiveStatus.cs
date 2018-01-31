using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class ActiveStatus : EntityBaseInt
    {
        public ActiveStatus()
        {
            SurveyTemplates = new HashSet<SurveyTemplates>();
        }
        
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("surveyTemplates")]
        public ICollection<SurveyTemplates> SurveyTemplates { get; set; }
    }
}

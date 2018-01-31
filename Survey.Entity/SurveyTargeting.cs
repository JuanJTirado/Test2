using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class SurveyTargeting : EntityBaseInt
    {
        [JsonProperty("level")]
        public int? Level { get; set; }

        [JsonProperty("surveyTemplateId")]
        public int? SurveyTemplateId { get; set; }

        [JsonProperty("surveyTemplate")]
        public SurveyTemplates SurveyTemplate { get; set; }
        
    }
}

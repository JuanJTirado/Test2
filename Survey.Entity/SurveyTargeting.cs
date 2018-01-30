using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class SurveyTargeting : EntityBase
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("level")]
        public int? Level { get; set; }

        [JsonProperty("surveyTemplateId")]
        public int? SurveyTemplateId { get; set; }

        [JsonProperty("surveyTemplate")]
        public SurveyTemplates SurveyTemplate { get; set; }

        public override string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

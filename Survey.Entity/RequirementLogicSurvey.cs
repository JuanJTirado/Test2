using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class RequirementLogicSurvey: EntityBase
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("surveyQuestionId")]
        public int? SurveyQuestionId { get; set; }

        [JsonProperty("logicString")]
        public string LogicString { get; set; }

        public override string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

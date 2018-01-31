using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class RequirementLogicSurvey: EntityBaseInt
    {

        [JsonProperty("surveyQuestionId")]
        public int? SurveyQuestionId { get; set; }

        [JsonProperty("logicString")]
        public string LogicString { get; set; }
        
    }
}

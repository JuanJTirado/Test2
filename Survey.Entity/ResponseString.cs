using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class ResponseString : EntityBaseGuid
    {
        [JsonProperty("surveyQuestionId")]
        public Guid SurveyQuestionId { get; set; }

        [JsonProperty("responseValueString")]
        public string ResponseValueString { get; set; }

        [JsonProperty("responseValueCleaned")]
        public string ResponseValueCleaned { get; set; }

        [JsonProperty("surveyQuestion")]
        public SurveyQuestions SurveyQuestion { get; set; }
        
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class ResponseBinary: EntityBaseGuid
    {
        [JsonProperty("surveyQuestionId")]
        public Guid SurveyQuestionId { get; set; }

        [JsonProperty("responseValueBinary")]
        public string ResponseValueBinary { get; set; }

        [JsonProperty("responseCleanedBinary")]
        public string ResponseCleanedBinary { get; set; }

        [JsonProperty("surveyQuestion")]
        public SurveyQuestions SurveyQuestion { get; set; }
        
    }
}

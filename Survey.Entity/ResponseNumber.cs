using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class ResponseNumber : EntityBaseGuid
    {

        [JsonProperty("surveyQuestionId")]
        public Guid SurveyQuestionId { get; set; }

        [JsonProperty("responseValueNumber")]
        public string ResponseValueNumber { get; set; }

        [JsonProperty("responseValueCleaned")]
        public string ResponseValueCleaned { get; set; }

        [JsonProperty("surveyQuestion")]
        public SurveyQuestions SurveyQuestion { get; set; }

    }
}

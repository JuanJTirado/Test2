using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class ResponseString : EntityBase
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("surveyQuestionId")]
        public Guid SurveyQuestionId { get; set; }

        [JsonProperty("responseValueString")]
        public string ResponseValueString { get; set; }

        [JsonProperty("responseValueCleaned")]
        public string ResponseValueCleaned { get; set; }

        [JsonProperty("surveyQuestion")]
        public SurveyQuestions SurveyQuestion { get; set; }

        public override string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

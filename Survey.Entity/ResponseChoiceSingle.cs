using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class ResponseChoiceSingle : EntityBase
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("surveyQuestionId")]
        public Guid SurveyQuestionId { get; set; }

        [JsonProperty("responseValueChoice")]
        public string ResponseValueChoice { get; set; }

        [JsonProperty("responseValueCleanedChoice")]
        public string ResponseValueCleanedChoice { get; set; }

        [JsonProperty("dateReviewed")]
        public DateTime? DateReviewed { get; set; }

        [JsonProperty("surveyQuestion")]
        public SurveyQuestions SurveyQuestion { get; set; }

        public override string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

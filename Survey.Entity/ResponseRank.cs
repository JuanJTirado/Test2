using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class ResponseRank : EntityBaseGuid
    {
        [JsonProperty("surveyQuestionId")]
        public Guid SurveyQuestionId { get; set; }

        [JsonProperty("rank")]
        public int? Rank { get; set; }

        [JsonProperty("choiceId")]
        public int? ChoiceId { get; set; }

        [JsonProperty("surveyQuestion")]
        public SurveyQuestions SurveyQuestion { get; set; }
        
    }
}

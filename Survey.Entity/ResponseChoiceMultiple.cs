using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class ResponseChoiceMultiple : EntityBaseGuid
    {

        [JsonProperty("surveyQuestionId")]
        public Guid SurveyQuestionId { get; set; }

        [JsonProperty("choiceId")]
        public int? ChoiceId { get; set; }

        [JsonProperty("cleanedChoiceId")]
        public int? CleanedChoiceId { get; set; }

        [JsonProperty("choice")]
        public Choices Choice { get; set; }

        [JsonProperty("cleanedChoice")]
        public Choices CleanedChoice { get; set; }

        [JsonProperty("surveyQuestion")]
        public SurveyQuestions SurveyQuestion { get; set; }
        
    }
}

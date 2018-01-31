using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class ResponseStatuses : EntityBaseInt
    {
        public ResponseStatuses()
        {
            SurveyQuestions = new HashSet<SurveyQuestions>();
        }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("surveyQuestions")]
        public ICollection<SurveyQuestions> SurveyQuestions { get; set; }
        
    }
}

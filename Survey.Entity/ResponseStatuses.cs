using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class ResponseStatuses : EntityBase
    {
        public ResponseStatuses()
        {
            SurveyQuestions = new HashSet<SurveyQuestions>();
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("surveyQuestions")]
        public ICollection<SurveyQuestions> SurveyQuestions { get; set; }

        public override string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class ApprovalStatus : EntityBase
    {
        public ApprovalStatus()
        {
            SurveyQuestions = new HashSet<SurveyQuestions>();
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("modifiedBy")]
        public string ModifiedBy { get; set; }

        [JsonProperty("dateCreated")]
        public DateTimeOffset DateCreated { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("dateModified")]
        public DateTimeOffset DateModified { get; set; }

        [JsonProperty("surveyQuestions")]
        public ICollection<SurveyQuestions> SurveyQuestions { get; set; }

        public override string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

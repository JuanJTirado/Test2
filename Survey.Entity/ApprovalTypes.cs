using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class ApprovalTypes : EntityBase
    {
        public ApprovalTypes()
        {
            SurveyTemplates = new HashSet<SurveyTemplates>();
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("approvalBasis")]
        public string ApprovalBasis { get; set; }

        [JsonProperty("surveyTemplates")]
        public ICollection<SurveyTemplates> SurveyTemplates { get; set; }

        public override string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

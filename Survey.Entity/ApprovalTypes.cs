using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class ApprovalTypes : EntityBaseInt
    {
        public ApprovalTypes()
        {
            SurveyTemplates = new HashSet<SurveyTemplates>();
        }

        [JsonProperty("approvalBasis")]
        public string ApprovalBasis { get; set; }

        [JsonProperty("surveyTemplates")]
        public ICollection<SurveyTemplates> SurveyTemplates { get; set; }

    }
}

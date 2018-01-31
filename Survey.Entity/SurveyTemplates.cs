using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class SurveyTemplates : EntityBaseInt
    {
        public SurveyTemplates()
        {
            SurveyTargeting = new HashSet<SurveyTargeting>();
            SurveyTemplateQuestions = new HashSet<SurveyTemplateQuestions>();
            Surveys = new HashSet<Surveys>();
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("approvalTypeId")]
        public int? ApprovalTypeId { get; set; }

        [JsonProperty("ownerGroupId")]
        public int? OwnerGroupId { get; set; }

        [JsonProperty("activeStatusId")]
        public int? ActiveStatusId { get; set; }

        [JsonProperty("targetLevelId")]
        public int? TargetLevelId { get; set; }

        [JsonProperty("surveyTypeId")]
        public int? SurveyTypeId { get; set; }

        [JsonProperty("activeStatus")]
        public ActiveStatus ActiveStatus { get; set; }

        [JsonProperty("approvalType")]
        public ApprovalTypes ApprovalType { get; set; }

        [JsonProperty("surveyType")]
        public SurveyTypes SurveyType { get; set; }

        [JsonProperty("targetLevel")]
        public TargetLevels TargetLevel { get; set; }

        [JsonProperty("surveyTargeting")]
        public ICollection<SurveyTargeting> SurveyTargeting { get; set; }

        [JsonProperty("surveyTemplateQuestions")]
        public ICollection<SurveyTemplateQuestions> SurveyTemplateQuestions { get; set; }

        [JsonProperty("surveys")]
        public ICollection<Surveys> Surveys { get; set; }
        
    }
}

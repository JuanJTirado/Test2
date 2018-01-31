using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class Surveys : EntityBaseGuid
    {
        public Surveys()
        {
            SurveyQuestions = new HashSet<SurveyQuestions>();
        }

        [JsonProperty("questionnaireName")]
        public string QuestionnaireName { get; set; }

        [JsonProperty("engagementId")]
        public int EngagementId { get; set; }

        [JsonProperty("id")]
        public int EngagementDeliverableId { get; set; }

        [JsonProperty("engagementDeliverableId")]
        public int Region { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ownerGroupId")]
        public int OwnerGroupId { get; set; }

        [JsonProperty("standardTemplateId")]
        public int? StandardTemplateId { get; set; }

        [JsonProperty("preApprovalStatusId")]
        public int? PreApprovalStatusId { get; set; }

        [JsonProperty("dateCreated")]
        public DateTimeOffset DateCreated { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("dateModified")]
        public DateTimeOffset? DateModified { get; set; }

        [JsonProperty("modifiedBy")]
        public string ModifiedBy { get; set; }

        [JsonProperty("dateDue")]
        public DateTimeOffset? DateDue { get; set; }

        [JsonProperty("startDate")]
        public DateTimeOffset? StartDate { get; set; }

        [JsonProperty("endDate")]
        public DateTimeOffset? EndDate { get; set; }

        [JsonProperty("surveyStatusId")]
        public int? SurveyStatusId { get; set; }

        [JsonProperty("standardTemplate")]
        public SurveyTemplates StandardTemplate { get; set; }

        [JsonProperty("surveyStatus")]
        public SurveyStatus SurveyStatus { get; set; }

        [JsonProperty("surveyQuestions")]
        public ICollection<SurveyQuestions> SurveyQuestions { get; set; }
        
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class SurveyTemplateQuestions : EntityBaseGuid
    {
        [JsonProperty("templateId")]
        public int? TemplateId { get; set; }

        [JsonProperty("questionOrder")]
        public int? QuestionOrder { get; set; }

        [JsonProperty("questionId")]
        public Guid QuestionId { get; set; }

        [JsonProperty("questionLevelId")]
        public int? QuestionLevelId { get; set; }

        [JsonProperty("dateCreated")]
        public DateTimeOffset? DateCreated { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("dateModified")]
        public DateTimeOffset? DateModified { get; set; }

        [JsonProperty("modifiedBy")]
        public string ModifiedBy { get; set; }

        [JsonProperty("question")]
        public Questions Question { get; set; }
        [JsonProperty("template")]
        public SurveyTemplates Template { get; set; }
        
    }
}

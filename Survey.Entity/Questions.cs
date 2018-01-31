using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class Questions:EntityBaseGuid
    {
        public Questions()
        {
            QuestionLevelParentQuestion = new HashSet<QuestionLevel>();
            QuestionLevelQuestion = new HashSet<QuestionLevel>();
            SurveyQuestions = new HashSet<SurveyQuestions>();
            SurveyTemplateQuestions = new HashSet<SurveyTemplateQuestions>();
        }
        
        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("questionHelp")]
        public string QuestionHelp { get; set; }

        [JsonProperty("responseTypeId")]
        public int? ResponseTypeId { get; set; }

        [JsonProperty("topicTagsId")]
        public string TopicTagsId { get; set; }

        [JsonProperty("responseRequired")]
        public bool? ResponseRequired { get; set; }

        [JsonProperty("dateCreated")]
        public DateTimeOffset? DateCreated { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("dateModified")]
        public DateTimeOffset? DateModified { get; set; }

        [JsonProperty("modifiedBy")]
        public string ModifiedBy { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("section")]
        public string Section { get; set; }

        [JsonProperty("sectionOrder")]
        public int? SectionOrder { get; set; }

        [JsonProperty("questionHelp2")]
        public string QuestionHelp2 { get; set; }

        [JsonProperty("responseType")]
        public ResponseTypes ResponseType { get; set; }

        [JsonProperty("questionLevelParentQuestion")]
        public ICollection<QuestionLevel> QuestionLevelParentQuestion { get; set; }

        [JsonProperty("questionLevelQuestion")]
        public ICollection<QuestionLevel> QuestionLevelQuestion { get; set; }

        [JsonProperty("surveyQuestions")]
        public ICollection<SurveyQuestions> SurveyQuestions { get; set; }

        [JsonProperty("surveyTemplateQuestions")]
        public ICollection<SurveyTemplateQuestions> SurveyTemplateQuestions { get; set; }
        
    }
}

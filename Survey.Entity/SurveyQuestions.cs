using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class SurveyQuestions : EntityBaseGuid
    {
        public SurveyQuestions()
        {
            ResponseBinary = new HashSet<ResponseBinary>();
            ResponseChoiceMultiple = new HashSet<ResponseChoiceMultiple>();
            ResponseChoiceSingle = new HashSet<ResponseChoiceSingle>();
            ResponseNumber = new HashSet<ResponseNumber>();
            ResponseRank = new HashSet<ResponseRank>();
            ResponseString = new HashSet<ResponseString>();
        }
        
        [JsonProperty("questionOrder")]
        public int QuestionOrder { get; set; }

        [JsonProperty("questionId")]
        public Guid QuestionId { get; set; }

        [JsonProperty("surveyId")]
        public Guid? SurveyId { get; set; }

        [JsonProperty("engagementEntityId")]
        public int? EngagementEntityId { get; set; }

        [JsonProperty("responseStatusId")]
        public int? ResponseStatusId { get; set; }

        [JsonProperty("approvalStatusId")]
        public int? ApprovalStatusId { get; set; }

        [JsonProperty("approvedBy")]
        public string ApprovedBy { get; set; }

        [JsonProperty("dateApproved")]
        public DateTimeOffset? DateApproved { get; set; }

        [JsonProperty("dateCreated")]
        public DateTimeOffset? DateCreated { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("dateModified")]
        public DateTimeOffset? DateModified { get; set; }

        [JsonProperty("modifiedBy")]
        public string ModifiedBy { get; set; }

        [JsonProperty("approvalStatus")]
        public ApprovalStatus ApprovalStatus { get; set; }

        [JsonProperty("question")]
        public Questions Question { get; set; }

        [JsonProperty("responseStatus")]
        public ResponseStatuses ResponseStatus { get; set; }

        [JsonProperty("survey")]
        public Surveys Survey { get; set; }

        [JsonProperty("responseBinary")]
        public ICollection<ResponseBinary> ResponseBinary { get; set; }

        [JsonProperty("responseChoiceMultiple")]
        public ICollection<ResponseChoiceMultiple> ResponseChoiceMultiple { get; set; }

        [JsonProperty("responseChoiceSingle")]
        public ICollection<ResponseChoiceSingle> ResponseChoiceSingle { get; set; }

        [JsonProperty("responseNumber")]
        public ICollection<ResponseNumber> ResponseNumber { get; set; }

        [JsonProperty("responseRank")]
        public ICollection<ResponseRank> ResponseRank { get; set; }

        [JsonProperty("responseString")]
        public ICollection<ResponseString> ResponseString { get; set; }
        
    }
}

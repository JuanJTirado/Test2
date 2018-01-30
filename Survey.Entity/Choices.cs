using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class Choices : EntityBase
    {
        public Choices()
        {
            ResponseChoiceMultipleChoice = new HashSet<ResponseChoiceMultiple>();
            ResponseChoiceMultipleCleanedChoice = new HashSet<ResponseChoiceMultiple>();
        }
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("questionId")]
        public int? QuestionId { get; set; }

        [JsonProperty("choiceString")]
        public string ChoiceString { get; set; }
        [JsonProperty("choiceNumber")]
        public string ChoiceNumber { get; set; }

        [JsonProperty("responseChoiceMultipleChoice")]
        public ICollection<ResponseChoiceMultiple> ResponseChoiceMultipleChoice { get; set; }
        [JsonProperty("responseChoiceMultipleCleanedChoice")]
        public ICollection<ResponseChoiceMultiple> ResponseChoiceMultipleCleanedChoice { get; set; }

        public override string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class Choices : EntityBaseInt
    {
        public Choices()
        {
            ResponseChoiceMultipleChoice = new HashSet<ResponseChoiceMultiple>();
            ResponseChoiceMultipleCleanedChoice = new HashSet<ResponseChoiceMultiple>();
        }

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
        
    }
}

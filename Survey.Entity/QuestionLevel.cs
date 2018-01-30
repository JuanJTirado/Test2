using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class QuestionLevel: EntityBase
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("questionId")]
        public Guid? QuestionId { get; set; }

        [JsonProperty("parentQuestionId")]
        public Guid? ParentQuestionId { get; set; }

        [JsonProperty("level")]
        public int? Level { get; set; }

        [JsonProperty("parentQuestion")]
        public Questions ParentQuestion { get; set; }
        [JsonProperty("question")]
        public Questions Question { get; set; }

        public override string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

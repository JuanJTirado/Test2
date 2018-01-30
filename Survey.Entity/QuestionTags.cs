using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class QuestionTags:EntityBase
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("tagName")]
        public string TagName { get; set; }

        public override string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

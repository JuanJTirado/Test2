using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class QuestionTags : EntityBaseInt
    {

        [JsonProperty("tagName")]
        public string TagName { get; set; }

    }
}

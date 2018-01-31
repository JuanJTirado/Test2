using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class RequirementLogicTemplate : EntityBaseInt
    {
        [JsonProperty("templateQuestionId")]
        public int? TemplateQuestionId { get; set; }

        [JsonProperty("logicString")]
        public string LogicString { get; set; }
        
    }
}

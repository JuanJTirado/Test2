using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class RequirementLogicTemplate : EntityBase
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("templateQuestionId")]
        public int? TemplateQuestionId { get; set; }

        [JsonProperty("logicString")]
        public string LogicString { get; set; }

        public override string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class ResponseTypes : EntityBase
    {
        public ResponseTypes()
        {
            ControlTypes = new HashSet<ControlTypes>();
            Questions = new HashSet<Questions>();
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("controlTypes")]
        public ICollection<ControlTypes> ControlTypes { get; set; }

        [JsonProperty("questions")]
        public ICollection<Questions> Questions { get; set; }

        public override string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class ResponseTypes : EntityBaseInt
    {
        public ResponseTypes()
        {
            ControlTypes = new HashSet<ControlTypes>();
            Questions = new HashSet<Questions>();
        }
        
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("controlTypes")]
        public ICollection<ControlTypes> ControlTypes { get; set; }

        [JsonProperty("questions")]
        public ICollection<Questions> Questions { get; set; }
        
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class ControlTypes: EntityBaseInt
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("responseTypeId")]
        public int? ResponseTypeId { get; set; }

        [JsonProperty("responseType")]
        public ResponseTypes ResponseType { get; set; }
        
    }
}

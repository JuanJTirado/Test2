using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Entity
{
    public abstract class EntityBaseInt : EntityBase
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}

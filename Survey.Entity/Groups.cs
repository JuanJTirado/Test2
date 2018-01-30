using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class Groups : EntityBase
    {
        public Groups()
        {
            GroupMembers = new HashSet<GroupMembers>();
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("clientId")]
        public int? ClientId { get; set; }

        [JsonProperty("groupMembers")]
        public ICollection<GroupMembers> GroupMembers { get; set; }

        public override string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

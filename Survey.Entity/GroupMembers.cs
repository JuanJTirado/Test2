using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class GroupMembers : EntityBaseInt
    {

        [JsonProperty("groupId")]
        public int? GroupId { get; set; }

        [JsonProperty("userId")]
        public int? UserId { get; set; }

        [JsonProperty("userIsGroupAdmin")]
        public bool? UserIsGroupAdmin { get; set; }

        [JsonProperty("group")]
        public Groups Group { get; set; }
        [JsonProperty("user")]
        public Users User { get; set; }
        
    }
}

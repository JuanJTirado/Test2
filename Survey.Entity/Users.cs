using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class Users : EntityBaseInt
    {
        public Users()
        {
            GroupMembers = new HashSet<GroupMembers>();
        }

        [JsonProperty("fname")]
        public string Fname { get; set; }

        [JsonProperty("lname")]
        public string Lname { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("groupMembers")]
        public ICollection<GroupMembers> GroupMembers { get; set; }

    }
}

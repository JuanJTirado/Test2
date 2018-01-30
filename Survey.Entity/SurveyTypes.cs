using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class SurveyTypes : EntityBase
    {
        public SurveyTypes()
        {
            SurveyTemplates = new HashSet<SurveyTemplates>();
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }

        [JsonProperty("image")]
        public byte[] Image { get; set; }

        [JsonProperty("isConfigurable")]
        public bool? IsConfigurable { get; set; }

        [JsonProperty("staticSurveyPageId")]
        public int? StaticSurveyPageId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("surveyTemplates")]
        public ICollection<SurveyTemplates> SurveyTemplates { get; set; }

        public override string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

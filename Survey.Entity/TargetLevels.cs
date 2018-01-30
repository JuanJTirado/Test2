using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class TargetLevels : EntityBase
    {
        public TargetLevels()
        {
            SurveyTemplates = new HashSet<SurveyTemplates>();
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("levelName")]
        public string LevelName { get; set; }

        [JsonProperty("surveyTemplates")]
        public ICollection<SurveyTemplates> SurveyTemplates { get; set; }

        public override string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

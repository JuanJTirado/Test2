using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Survey.Entity
{
    public partial class TargetLevels : EntityBaseInt
    {
        public TargetLevels()
        {
            SurveyTemplates = new HashSet<SurveyTemplates>();
        }

        [JsonProperty("levelName")]
        public string LevelName { get; set; }

        [JsonProperty("surveyTemplates")]
        public ICollection<SurveyTemplates> SurveyTemplates { get; set; }

    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Entity
{
    public abstract class EntityBase
    {
        public virtual string GetJson()
        {
            var settings = new JsonSerializerSettings()
            {
                DateTimeZoneHandling = DateTimeZoneHandling.Utc
            };
            return JsonConvert.SerializeObject(this, settings);
        }
    }
}

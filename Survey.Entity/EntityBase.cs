using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Entity
{
    public abstract class EntityBase
    {
        public abstract string GetJson();
    }
}

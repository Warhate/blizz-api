using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json;


namespace JSONParser
{
    public class Parser
    {
        public static T ParseJSON<T>(string source)
        {
            return JsonConvert.DeserializeObject<T>(source);
        }
    }
}

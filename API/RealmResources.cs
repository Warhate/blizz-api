using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public static class RealmResources
    {
        public enum RealmStatus
        {
            Unknown = -1,
            Idle = 0,
            Populating = 1,
            Active = 2,
            Concluded = 3
        }

        public static string Url = "http://us.battle.net/api/wow/realm/status";

        public static string GetStatus()
        {
            string answer = "";
            WebRequest request = WebRequest.Create(Url);

            Stream stream = request.GetResponse().GetResponseStream();
            if (stream != null)
            {
                answer = new StreamReader(stream, Encoding.UTF8).ReadToEnd();
            }

            return answer;
        }
    }
}

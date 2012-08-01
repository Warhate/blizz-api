using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using JSONParser;

namespace API
{
    public static class RealmResources
    {
        public static string Url = "/api/wow/realm/status";

        /// <summary>
        /// Get all  realms
        /// </summary>
        /// <param name="host">Host URL (""http://us.battle.net"")</param>
        /// <returns>All realms info</returns>
        public static List<Realm> GetRealms(string host)
        {
            string response = ReadStream(host + Url);

            RealmContainer container = Parser.ParseJSON<RealmContainer>(response);

            return container.Realms;
        }
        
        /// <summary>
        /// Get realm info
        /// </summary>
        /// <param name="host">Host URL (""http://us.battle.net"")</param>
        /// <param name="name">Slug of realm</param>
        /// <returns>Realm info</returns>
        public static Realm GetRealm(string host,string name)
        {
            var response = ReadStream(host + Url + "?realms=" + name);

            Realm realm = Parser.ParseJSON<Realm>(response);

            return realm;
        }

       private  static string ReadStream(string url)
        {
            string answer = "";
            WebRequest request = WebRequest.Create(url);

            Stream stream = request.GetResponse().GetResponseStream();
            if (stream != null)
            {
                answer = new StreamReader(stream, Encoding.UTF8).ReadToEnd();
            }
            return answer;
        }
    }
}

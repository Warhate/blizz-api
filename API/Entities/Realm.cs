using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    [DataContract]
    public class Realm
    {
        public enum RealmType
        {
            PVE,
            PVP,
            RPPVP,
            RPPVE
        }

        public enum PopulationLevel
        {
            Low,
            Normal,
            High
        }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "queue")]
        public bool Queue { get; set; }

        [DataMember(Name = "status")]
        public bool Status { get; set; }

        [DataMember(Name = "population")]
        public string Population { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "slug")]
        public string Slug { get; set; }

        [DataMember(Name = "wintergrasp")]
        public Battleground Win { get; set; }
        
        [DataMember(Name = "tol-barad")]
        public Battleground TolBarad { get; set; }

        [DataContract]
        public class Battleground
        {
            /// <summary>
            /// Area id
            /// </summary>
            [DataMember(Name = "area")]
            public int Area { get; set; }

            /// <summary>
            /// 0 - Horde
            /// 1 - Aliance
            /// </summary>
            [DataMember(Name = "controlling-faction")]
            public int ControllingFaction { get; set; }

            /// <summary>
            /// 0 - off
            /// 1 - on
            /// </summary>
            [DataMember(Name = "status")]
            public int Status { get; set; }

            [DataMember(Name = "next")]
            public long Next { get; set; }
        }
    }
}

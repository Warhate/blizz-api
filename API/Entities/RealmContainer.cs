using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public class RealmContainer
    {
        public RealmContainer()
        {
            Realms = new List<Realm>();
        }

        public List<Realm> Realms { get; set; }
    }
}

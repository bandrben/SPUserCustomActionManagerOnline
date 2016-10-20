using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BandR
{

    public class CustomRegistrySettings
    {
        public string siteUrl { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
        public string domain { get; set; }
        public string isSPOnline { get; set; }
    }

    public class UserActionObject
    {
        public string id { get; set; }
        public string name { get; set; }
        public string descr { get; set; }
        public int seq { get; set; }
        public string scriptSrc { get; set; }
        public string scriptBlock { get; set; }

        public bool selected { get; set; }
    }

}

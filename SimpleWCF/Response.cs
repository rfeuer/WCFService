using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SimpleWCF
{
    [DataContract]
    public class Response
    {
        [DataMember]
        public string Content { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SimpleWCF
{
    public class Service1 : IService1
    {
        public Response GetData(string value)
        {
            return new Response() { Content = string.Format("You entered: {0}", value) };
        }

    }
}

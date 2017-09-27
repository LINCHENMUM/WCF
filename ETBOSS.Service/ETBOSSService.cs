using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ETBOSSService
{
    // 
    public class ETBOSSService : IETBOSSServiceChanged
    {
        public string GetCustomerNameChanged(string name)
        {
            return "The customer name is "+name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ETBOSSServiceHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(ETBOSSService.ETBOSSService)))
            {
                host.Open();
                Console.WriteLine("ETBOSS Host started @ " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}

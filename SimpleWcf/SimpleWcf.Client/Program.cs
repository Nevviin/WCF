using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWcf.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            // var simpleWcfService = new simplewcfserviceProxy();

            var simpleWcfService = new Service1Client();
            var returnValue = simpleWcfService.GetData(1);
            

        }
    }
}

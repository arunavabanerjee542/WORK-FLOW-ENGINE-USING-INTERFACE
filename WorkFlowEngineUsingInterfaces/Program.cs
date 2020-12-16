using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngineUsingInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkFlow w = new WorkFlow();

            w.AddActivities(new Email());
            w.AddActivities(new DataBase());
            w.AddActivities(new WebService());
            w.AddActivities(new CloudStorage());

            w.ShowWorkFlow();

        }
    }
}

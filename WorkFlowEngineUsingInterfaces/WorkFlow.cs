using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngineUsingInterfaces
{
    class WorkFlow
    {
       private  List<Activities> ActivityList;

        public WorkFlow()
        {
           ActivityList = new List<Activities>();
        }

        public void ShowWorkFlow( )
        {
            
            foreach(var act in ActivityList)
            {
                act.Execute();
            }

        }


        public void AddActivities(Activities a )
        {
            ActivityList.Add(a);
        }


        



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema82_SOLID_Principles.Interface_Segregation_Principle
{
    public class TeamLead : IProgrammer,ILead
    {

        public void AssignTask()
        {
            //Code to assign a task.
        }

        public void CreateSubTask()
        {
            //Code to create a sub task
        }
        public void WorkOnTask()
        {
            //Code to implement perform assigned task.
        }
    }
}

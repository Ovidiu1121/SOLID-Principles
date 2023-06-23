using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema82_SOLID_Principles.Interface_Segregation_Principle
{
    //public class Manager : ILead
    //{
    //    public void AssginTask()
    //    {
    //        //Code to assign a task.
    //    }
    //    public void CreateSubTask()
    //    {
    //        //Code to create a sub task.
    //    }
    //    public void WorkOnTask()
    //    {
    //        throw new Exception("Manager can't work on Task");
    //    }
    //}

    public class Manager : ILead
    {
        public void AssignTask()
        {
            //Code to assign a Task
        }
        public void CreateSubTask()
        {
            //Code to create a sub taks from a task.
        }
    }

}

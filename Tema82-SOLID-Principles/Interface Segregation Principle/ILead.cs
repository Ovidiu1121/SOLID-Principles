using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema82_SOLID_Principles.Interface_Segregation_Principle
{
    //public interface ILead
    //{
    //    void CreateSubTask();
    //    void AssginTask();
    //    void WorkOnTask();
    //}

    public interface ILead
    {
        void AssignTask();
        void CreateSubTask();
    }

}

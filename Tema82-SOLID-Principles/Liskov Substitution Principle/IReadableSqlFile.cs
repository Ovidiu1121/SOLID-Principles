using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema82_SOLID_Principles.Liskov_Substitution_Principle
{
    public interface IReadableSqlFile
    {
        string LoadText();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Business.Interface
{
    public interface IBusinessClass
    {
        string GetKeyWord();
        string GetKeyWordWithId(int Id);
    }
}

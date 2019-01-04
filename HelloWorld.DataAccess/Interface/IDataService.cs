using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.DataAccess.Interface
{
    public interface IDataService
    {
        string GetKeyWords();
        string GetKeyWordById(int Id);
    }
}

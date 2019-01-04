using System.Configuration;
using HelloWorld.Business.Interface;
using HelloWorld.DataAccess.Interface;
using HelloWorld.DataAccess.Implementation;

namespace HelloWorld.Business.Implementation
{
    public class BusinessClass : IBusinessClass
    {
        private readonly IDataService _dataService;

        public BusinessClass()
        {
            _dataService = new DataService();
        }

        public string GetKeyWord()
        {
            var result = _dataService.GetKeyWords();
                //ConfigurationManager.AppSettings["APIKeyWord"];

            return result;
        }

        public string GetKeyWordWithId(int Id)
        {
            var result = ConfigurationManager.AppSettings["APIKeyWord"];

            return string.Format("{0} {1}", result, Id.ToString());
        }
    }
}

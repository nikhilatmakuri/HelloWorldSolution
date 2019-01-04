using System;
using System.Configuration;
using System.Text;
using BusinessLayer.Interface;

namespace BusinessLayer.Implementation
{
    public class BusinessClass : IBusinessClass
    {
        public string GetKeyWord()
        {
            var resultWord = ConfigurationManager
        }

        public string GetKeyWordWithId()
        {
            throw new NotImplementedException();
        }
    }
}

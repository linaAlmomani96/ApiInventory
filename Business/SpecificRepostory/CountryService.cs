using DataAccess.Entity;
using DataAccess.Generic;
using System.Collections.Generic;

namespace Business.SpecificRepostory
{
    public class CountryService:ICountryService
    {
      private readonly  IServiceGeneric<Country> serviceGeneric;
        public CountryService(IServiceGeneric<Country> _serviceGeneric)
        {
            serviceGeneric = _serviceGeneric;
        }

        public List<Country> GetAll()
        {
            return serviceGeneric.GetAll();
        }
    }
}
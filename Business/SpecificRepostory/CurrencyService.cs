using DataAccess.Entity;
using DataAccess.Generic;
using System.Collections.Generic;

namespace Business.SpecificRepostory
{
    public class CurrencyService:ICurrencyService
    {
       private readonly IServiceGeneric<Currency> serviceGeneric;
      public  CurrencyService(IServiceGeneric<Currency> _serviceGeneric) {
            serviceGeneric = _serviceGeneric;
        }

        public List<Currency> GetAll()
        {
            return serviceGeneric.GetAll();
        }
    }
}
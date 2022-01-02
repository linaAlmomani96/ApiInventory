using DataAccess.Entity;
using System.Collections.Generic;

namespace Business.SpecificRepostory
{
    public interface ICurrencyService
    {
        List<Currency> GetAll();
    }
}
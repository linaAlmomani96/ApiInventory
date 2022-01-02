using DataAccess.Entity;
using System.Collections.Generic;

namespace Business.SpecificRepostory
{
    public interface ICountryService
    {
        List<Country> GetAll();
    }
}
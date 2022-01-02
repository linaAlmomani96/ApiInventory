using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.Generic;
using System.Collections.Generic;
using System.Linq;

namespace Business.SpecificRepostory
{
    public class CompanyService:ICompanyService
    {
        IServiceGeneric<Company> serviceGeneric;
        InventoryContext Context;
        public CompanyService(IServiceGeneric<Company> _serviceGeneric, InventoryContext _Context)
        {
            serviceGeneric = _serviceGeneric;
            Context = _Context;
        }

        public void Insert(Company company)
        {
            serviceGeneric.Insert(company);
        }
        public void Update(Company company)
        {
            serviceGeneric.Update(company);
        }
        //public void Delete(int id)
        //{
        //    serviceGeneric.Delete(id);

        //}

        public Company GetById(int id)
        {
            return serviceGeneric.GetById(id);

        }
        //public List<Company> GetAll()
        //{
        //    return serviceGeneric.GetAll();
        //}

       
    }
}
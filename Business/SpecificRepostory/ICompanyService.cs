using DataAccess.Entity;

namespace Business.SpecificRepostory
{
    public interface ICompanyService
    {
        void Insert(Company company);
        void Update(Company company);
       Company GetById(int id);
   }
}
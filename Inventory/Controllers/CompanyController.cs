using Business.SpecificRepostory;
using DataAccess.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService companyService;
        private readonly ICurrencyService currencyService;
        private readonly ICountryService countryService;

        public CompanyController(ICompanyService _companyService, ICurrencyService _currencyService, ICountryService _countryService)
        {
            companyService = _companyService;
            currencyService = _currencyService;
            countryService = _countryService;
        }
        [HttpPost]
        public ActionResult Insert(Company company)
        {
            companyService.Insert(company);
            return StatusCode(StatusCodes.Status200OK);
        }
        [HttpPost]
        [Route("update")]
        public ActionResult Update(Company company)
        {
            companyService.Update(company);
            return StatusCode(StatusCodes.Status200OK);

        }
      
      
        [HttpGet]
        [Route("GetById/{id}")]
        public Company GetById(int id)
        {
            return companyService.GetById(id);

        }


        [HttpGet]
        [Route("GetAllCountries")]
        public List<Country> GetAllCountries()
        {
            return countryService.GetAll();

        }

        [HttpGet]
        [Route("GetAllCurenies")]
        public List<Currency> GetAllCurenies()
        {
            return currencyService.GetAll();

        }
    }
}

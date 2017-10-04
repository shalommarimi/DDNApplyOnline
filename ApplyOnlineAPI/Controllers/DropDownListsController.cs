using DAL.DBContext;
using DAL.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ApplyOnlineAPI.Controllers
{
    [RoutePrefix("api/DropDownLists")]
    public class DropDownListsController : ApiController
    {

        ApplyDbContext db = new ApplyDbContext();



        [HttpGet]
        [Route("GetGenderList")]
        public IEnumerable<Gender> GetAllGenders()
        {
            return db.Gender.ToList();
        }


        [HttpGet]
        [Route("GetPopulationList")]
        public IEnumerable<Population> GetAllPopulations()
        {
            return db.Populations.ToList();
        }



        [HttpGet]
        [Route("GetNationalityList")]
        public IEnumerable<Nationality> GetAllNationality()
        {
            return db.Nationalities.ToList();
        }


        [HttpGet]
        [Route("GetMaritalStatusList")]
        public IEnumerable<MaritalStatus> GetAllMaritalStatus()
        {
            return db.MaritalStatus.ToList();
        }


        [HttpGet]
        [Route("GetApplicationFieldList")]
        public IEnumerable<ApplicationField> GetAllApplicationField()
        {
            return db.ApplicationField.ToList();
        }


        [HttpGet]
        [Route("GetApplicationTypeList")]
        public IEnumerable<ApplicationType> GetAllApplicationType()
        {
            return db.ApplicationTypes.ToList();
        }


    }
}

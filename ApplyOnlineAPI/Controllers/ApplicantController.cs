﻿using ApplyOnlineAPI.Filters;
using BL.BL.Interfaces;
using BL.DTO;
using DAL.DBContext;
using DAL.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ApplyOnlineAPI.Controllers
{
    [RoutePrefix("api/Applicant")]
    public class ApplicantController : BaseController
    {

        public ApplicantController(IRegister iRegister, IFileService iImageService, IUpdate iUpdate)
            : base(iRegister, iImageService, iUpdate) { }

        [Route("Apply")]
        [HttpPost]
        [ModelValidator]
        public IHttpActionResult Apply(PersonalDTO _PersonalDTO)
        {
            try
            {

                IRegister.RegisterUser(_PersonalDTO);
                return Ok("Thank you for applying");
            }
            catch (System.Exception)
            {

                return BadRequest("Unable to Send Application");
            }


        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Personal> GetAll()
        {
            var db = new ApplyDbContext();

            return db.Personal.ToList();
        }



        [Route("Update")]
        [HttpPut]
        [ModelValidator]
        public IHttpActionResult Update(PersonalDTO _PersonalDTO)
        {
            try
            {
                IUpdate.UpdateUser(_PersonalDTO);
                return Ok(_PersonalDTO);
            }
            catch (System.Exception)
            {
                return BadRequest("Unable to Update");
            }

        }

    }
}

using BL.BL.Interfaces;
using BL.Services;
using System.Web.Http;

namespace ApplyOnlineAPI.Controllers
{
    public abstract class BaseAPIController : ApiController
    {
        private IImageService _IImageService;
        private IRegister _IRegister;
        private IApplicantUpdate _IApplicantUpdate;
        private ISubscribe _ISubscribe;

        protected BaseAPIController(IRegister iRegister, IImageService iImageService, IApplicantUpdate iApplicantUpdate)
        {

            _IApplicantUpdate = iApplicantUpdate;
            _IImageService = iImageService;
            _IRegister = iRegister;

        }

        protected BaseAPIController(ISubscribe iSubscribe)
        {
            _ISubscribe = iSubscribe;

        }

        protected ISubscribe ISubscribe
        {
            get { return _ISubscribe; }
        }


        protected IImageService IImageService
        {
            get { return _IImageService; }
        }

        protected IRegister IRegister
        {
            get { return _IRegister; }
        }

        protected IApplicantUpdate IApplicantUpdate
        {
            get { return _IApplicantUpdate; }
        }



    }

}
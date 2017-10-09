using BL.BL.Interfaces;
using BL.Services;
using System.Web.Http;

namespace ApplyOnlineAPI.Controllers
{
    public abstract class BaseController : ApiController
    {
        private IFileService _IImageService;
        private IRegister _IRegister;
        private IUpdate _IUpdate;
        private ISubscribe _ISubscribe;


        protected BaseController(IRegister iRegister, IFileService iImageService, IUpdate iUpdate)
        {

            _IUpdate = iUpdate;
            _IImageService = iImageService;
            _IRegister = iRegister;


        }

        protected BaseController(ISubscribe iSubscribe)
        {
            _ISubscribe = iSubscribe;


        }

        protected ISubscribe ISubscribe
        {
            get { return _ISubscribe; }
        }





        protected IFileService IImageService
        {
            get { return _IImageService; }
        }

        protected IRegister IRegister
        {
            get { return _IRegister; }
        }

        protected IUpdate IUpdate
        {
            get { return _IUpdate; }
        }



    }

}
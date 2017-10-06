using BL.BL.Interfaces;
using BL.Services;
using System.Web.Http;

namespace ApplyOnlineAPI.Controllers
{
    public abstract class BaseController : ApiController
    {
        private IImageService _IImageService;
        private IRegister _IRegister;
        private IUpdate _IUpdate;
        private ISubscribe _ISubscribe;
        private IGeneratePDF _IGeneratePDF;

        protected BaseController(IRegister iRegister, IImageService iImageService, IUpdate iUpdate, IGeneratePDF iGeneratePDF)
        {

            _IUpdate = iUpdate;
            _IImageService = iImageService;
            _IRegister = iRegister;
            _IGeneratePDF = iGeneratePDF;

        }

        protected BaseController(ISubscribe iSubscribe)
        {
            _ISubscribe = iSubscribe;


        }

        protected ISubscribe ISubscribe
        {
            get { return _ISubscribe; }
        }

        protected IGeneratePDF IGeneratePDF
        {
            get { return _IGeneratePDF; }
        }



        protected IImageService IImageService
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
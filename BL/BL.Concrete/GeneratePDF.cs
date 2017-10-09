using AutoMapper;
using BL.BL.Interfaces;
using BL.DTO;
using DAL.Entities;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Web;

namespace BL.BL.Concrete
{
    public class GeneratePDF : BaseDbContext, IGeneratePDF
    {
        private readonly IFileService _IImageService;

        public GeneratePDF(IFileService iImageService)
        {
            _IImageService = iImageService;
        }
        public void CreatePDF(PersonalDTO _PersonalDTO)
        {


            //Mapping 
            var config = new MapperConfiguration(cfg => cfg.CreateMap<PersonalDTO, Personal>());
            var mapper = config.CreateMapper();
            var model = mapper.Map<PersonalDTO, Personal>(_PersonalDTO);


            var document = new Document();
            document.SetPageSize(PageSize.A4);


            string TempPath = HttpContext.Current.Server.MapPath("~/CVs/");
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(TempPath + model.FirstName + " " + model.LastName + " Resumé " + ".pdf", FileMode.Create));

            document.Open();

            //Font For Caption
            Font arialCaption = FontFactory.GetFont("Arial", 22, BaseColor.BLACK);
            arialCaption.SetStyle(Font.BOLD);

            //Font For Headings
            Font arialHeading = FontFactory.GetFont("Arial", 19, BaseColor.BLACK);
            arialHeading.SetStyle(Font.BOLD);


            //Font For the Details
            Font arialContent = FontFactory.GetFont("Arial", 14, BaseColor.BLACK);
            arialContent.SetStyle(Font.NORMAL);

            //Paragraphs
            var Caption = new Paragraph();
            var Headings = new Paragraph();
            var Content = new Paragraph();

            //Setting FontStyle
            Caption.Font = arialCaption;
            Headings.Font = arialHeading;
            Content.Font = arialContent;

            //Spacing after text
            Caption.SpacingAfter = 15;
            Headings.SpacingAfter = 10;
            Content.SetLeading(2, 2);



            Caption.Add("Curriculum Vitae Of " + model.FirstName + " " + model.LastName + "\n");

            Headings.Add("Personal Particulars" + "\n");
            Content.Add("First Names: " + model.FirstName + "\n");
            Content.Add("Last Name: " + model.LastName + "\n");
            //  Content.Add("Gender: " + model.Gender + "\n");
            Content.Add("DOB: " + model.DOB.ToShortDateString() + "\n");
            Content.Add("Identity Number: " + model.IdNumber + "\n");
            Content.Add("Nationality: " + model.FirstName + "\n");
            Content.Add("Population: " + model.FirstName + "\n");
            Content.Add("Cell Number: " + model.CellNumber + "\n");
            Content.Add("Email Address: " + model.EmailAddress + "\n");
            Content.Add("Drivers's Licence: " + model.DriversLicence + "\n");
            Content.Add("Marital Status: " + model.FirstName + "\n");
            Content.Add("Home Language: " + model.HomeLanguage + "\n");
            Content.Add("Prefered Language: " + model.Prefered + "\n");
            Content.Add("Other Language 1: " + model.FirstOtherLanguage + "\n");
            Content.Add("Other Language 2: " + model.SecondOtherLanguage + "\n");
            Content.Add("Other Language 3: " + model.ThirdOtherLanguage + "\n");
            Content.Add("Application Fied: " + model.FirstName + "\n");
            Content.Add("Application Type: " + model.FirstName + "\n");

            document.Add(Caption);
            document.Add(Headings);
            document.Add(Content);

            document.Close();

        }
    }
}

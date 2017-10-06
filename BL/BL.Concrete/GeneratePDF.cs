using AutoMapper;
using BL.BL.Interfaces;
using BL.DTO;
using DAL.Entities;
using iTextSharp.text;
using System.IO;
using System.Web;

namespace BL.BL.Concrete
{
    public class GeneratePDF : IGeneratePDF
    {
        public void CreatePDF(PersonalDTO _PersonalDTO)
        {


            //Mapping 
            var config = new MapperConfiguration(cfg => cfg.CreateMap<PersonalDTO, Personal>());
            var mapper = config.CreateMapper();
            var model = mapper.Map<PersonalDTO, Personal>(_PersonalDTO);


            var document = new Document();
            document.SetPageSize(PageSize.A4.Rotate());



            string TempPath = HttpContext.Current.Server.MapPath("~/CVs");

            //Checking if Folder exist, if not, its created
            if (!Directory.Exists(TempPath))
            {
                Directory.CreateDirectory(TempPath);
            }


            iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(document, new FileStream(TempPath + model.FirstName + "_" + model.LastName + ".pdf", FileMode.Create));

            document.Open();


            //Font For Caption
            Font arialCaption = FontFactory.GetFont("Arial", 30, BaseColor.BLACK);
            arialCaption.SetStyle(Font.BOLD);

            //Font For Headings
            Font arialHeading = FontFactory.GetFont("Arial", 20, BaseColor.BLACK);
            arialHeading.SetStyle(Font.BOLD);


            //Font For the Details
            Font arialContent = FontFactory.GetFont("Arial", 12, BaseColor.BLACK);
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
            Headings.SpacingAfter = 14;
            Content.SpacingAfter = 5;



            string space = "";
            Caption.Add("Curriculum Vitae Of ");
            Caption.Add(space);
            Headings.Add("Personal Particulars");
            Content.Add("First Names ");
            Caption.Add(space);

            document.Add(Caption);
            document.Add(Headings);
            document.Add(Content);

            document.Close();



        }
    }
}

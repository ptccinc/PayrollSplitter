using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SplitLib.Models;

namespace SplitLib.Services
{
    public class SplitService
    {
        private readonly SettingsService _settingsService;

        public SplitService(SettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        public List<PayStub> GenerateIndividualStubs(string filename)
        {

            List<PayStub> stubs=new List<PayStub>();
            using (var reader = new PdfReader(filename))
            {
                
                for (var page = 1; page <= reader.NumberOfPages; page++)
                {
                    //extract page text
                    var strategy = new iTextSharp.text.pdf.parser.SimpleTextExtractionStrategy();
                    var currentText = iTextSharp.text.pdf.parser.PdfTextExtractor.GetTextFromPage(reader, page, strategy);

      
                    var paystub = FindPayStubMatch(currentText);
                    if (paystub == null) continue;

                    //write this individual page into a temp file
                    var outFileName = System.IO.Path.GetTempPath() + Guid.NewGuid() + ".pdf";

                    var pdfDoc = new Document(reader.GetPageSizeWithRotation(page));
                    var stream = new MemoryStream();
                    var pdf = new PdfCopy(pdfDoc, stream);
                    pdf.CloseStream = false;
                    pdfDoc.Open();
                    pdf.AddPage(pdf.GetImportedPage(reader, page));                    
                    pdf.Close();
                    pdfDoc.Close();
                    stream.Position = 0;
                  
                    var stamper = new PdfStamper(new PdfReader(stream), new FileStream(outFileName,FileMode.Create));
                    if ((paystub.Password + "").Length > 0)
                    {
                        stamper.SetEncryption(Encoding.ASCII.GetBytes(paystub.Password), Encoding.ASCII.GetBytes(paystub.Password), PdfWriter.ALLOW_PRINTING,
                            PdfWriter.ENCRYPTION_AES_128 | PdfWriter.DO_NOT_ENCRYPT_METADATA);
                    }
                    stamper.Close();
                    stream.Close();

                    paystub.Filename = outFileName;                
                    stubs.Add(paystub);

                }


            }
            return stubs;
        }

        private PayStub FindPayStubMatch(string content)
        {
             
            foreach (var e in _settingsService.Employees)
            {
                if (string.IsNullOrEmpty(e.UniqueIdentifier) || string.IsNullOrEmpty(e.Name)) continue;
                if (!content.ToLower().Contains(e.UniqueIdentifier.ToLower())) continue;
                var paystub = new PayStub
                {
                    Name = e.Name,
                    Password = e.Password,
                    Email = e.Email
                };

                return paystub;
            }

            return null;
        }

        


    }
}

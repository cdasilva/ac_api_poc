using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AssessmentCenter.Models.Xml;
using AssessmentCenter.Models.Database;
using AssessmentCenter.Models.Forms;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AssessmentCenter.Controllers
{
    [Authorize]
    [ApiController]
    public class FormsController : Controller
    {
        private readonly AssessmentCenterContext _context;

        public FormsController(AssessmentCenterContext context)
        {
            _context = context;
        }

        [HttpGet("2014-01/Forms/")]
        public async Task<ActionResult<MultiFormViewModel>> GetAllForms([FromQuery]string CODING_SYSTEM)
        {
            var model = await GetAllFormsAsync(CODING_SYSTEM);

            return View(model);
        }

        [HttpGet("2014-01/Forms/.{format}"), FormatFilter]
        public Task<MultiFormViewModel> GetAllFormsFormatted([FromQuery] string CODING_SYSTEM)
        {
            var model = GetAllFormsAsync(CODING_SYSTEM);

            return model;
        }

        [HttpGet("2014-01/Forms/{OID}")]
        public async Task<ActionResult<SingleFormViewModel>> GetSingleForm(Guid OID)
        {
            var model = await GetSingleFormAsync(OID);

            return View(model);
        }

        [HttpGet("2014-01/Forms/{OID}.{format}"), FormatFilter]
        public Task<SingleFormViewModel> GetSingleFormFormatted(Guid OID)
        {
            var model = GetSingleFormAsync(OID);

            return model;
        }

        private async Task<MultiFormViewModel> GetAllFormsAsync(string codingSystem)
        {
            if( codingSystem == "LOINC")
            {
                var loincData = await _context.LoincCodes.Include(c => c.Form).ToListAsync();

                var loincFormData = loincData.Where(c => c.Form != null && c.Form.Status == null).ToList();

                MultiFormViewModel model = new MultiFormViewModel()
                {
                    Form = new List<FormMetaDataViewModel>(loincFormData.Count)
                };

                foreach (var loinc in loincFormData)
                    model.Form.Add(new FormMetaDataViewModel()
                    {
                        OID = loinc.Form.FormOID,
                        Name = loinc.Form.Description,
                        LoincCode = loinc.Code
                    });

                return model;
            }
            else
            {
                var formData = await _context.Forms.Where(f => f.Status == null).ToListAsync();

                MultiFormViewModel model = new MultiFormViewModel()
                {
                    Form = new List<FormMetaDataViewModel>(formData.Count)
                };

                foreach (var form in formData)
                    model.Form.Add(new FormMetaDataViewModel()
                    {
                        OID = form.FormOID,
                        Name = form.Description
                    });

                return model;
            }
        }

        private async Task<SingleFormViewModel> GetSingleFormAsync(Guid OID)
        {
            var formData = await _context.FindAsync<FormData>(OID);

            XmlSerializer serializer = new XmlSerializer(typeof(FormXml));
            var formXml = (FormXml)serializer.Deserialize(new StringReader(formData.FormXml));

            var model = new SingleFormViewModel(formXml);
            return model;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentCenter.Models.Forms;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentCenter.Controllers
{
    [Authorize]
    [ApiController]
    public class FormsController : Controller
    {
        public FormsController()
        {
            //TODO: Inject database context
        }

        [HttpGet("2014-01/Forms/")]
        public async Task<ActionResult<AllFormsResponse>> GetAllForms()
        {
            var model = await GetAllFormsResponseAsync();

            return View(model);
        }

        [HttpGet("2014-01/Forms/.{format}"), FormatFilter]
        public Task<AllFormsResponse> GetAllFormsFormatted()
        {
            var model = GetAllFormsResponseAsync();

            return model;
        }

        [HttpGet("2014-01/Forms/{OID}")]
        public async Task<ActionResult<IndividualFormResponse>> GetIndividualForm(Guid OID)
        {
            var model = await GetIndividualFormResponseAsync(OID);

            return View(model);
        }

        [HttpGet("2014-01/Forms/{OID}.{format}"), FormatFilter]
        public Task<IndividualFormResponse> GetIndividualFormFormatted(Guid OID)
        {
            var model = GetIndividualFormResponseAsync(OID);

            return model;
        }


        private async Task<AllFormsResponse> GetAllFormsResponseAsync()
        {
            //TODO: Implement database calls
            AllFormsResponse response = new AllFormsResponse()
            {
                Form = new List<FormIdentifier>()
                {
                    new FormIdentifier() { OID = new Guid("C4ADCFAB-6B75-498E-9E94-AFD3BA211DC4"), Name = "PROMIS Bank v1.0 - Pain Behavior" },
                    new FormIdentifier() { OID = new Guid("29654543-C99B-4CE9-884B-3D401B4AD857"), Name = "PROMIS Bank v2.0 - Emotional Support" },
                }
            };

            return response;
        }

        private async Task<IndividualFormResponse> GetIndividualFormResponseAsync(Guid OID)
        {
            //TODO: Implement database calls
            IndividualFormResponse response = new IndividualFormResponse()
            {
                DateFinished = "",
                Items = new List<FormItem>()
                {
                    new FormItem()
                    {
                        FormItemOID = "77C86585-CAFF-43C3-80B0-1023496FAED2",
                        ItemResponseOID = "",
                        Response = "",
                        ID = "PAINBE2",
                        Order = "1",
                        ItemType = "",
                        Elements = new List<FormElement>()
                        {
                            new FormElement()
                            {
                                ElementOID = "8AB8BA58-3BB0-40B6-B656-C24F1169069B",
                                Description = "In the past 7 days",
                                ElementOrder = "1"
                            },
                            new FormElement()
                            {
                                ElementOID = "3AD1A30F-4E80-4DFE-8099-B3294F2BF4E0",
                                Description = "When I was in pain I became irritable",
                                ElementOrder = "2"
                            },
                            new FormElement()
                            {
                                ElementOID = "C54EF195-0904-4A9A-9789-510D2F2894A5",
                                Description = "ContainerForC54EF195-0904-4A9A-9789-510D2F2894A5",
                                ElementOrder = "3",
                                Map = new List<FormMap>()
                                {
                                    new FormMap()
                                    {
                                        ElementOID = "3D86FC4B-516C-42AF-A5EA-028339A0B123",
                                        Description = "Had no pain",
                                        FormItemOID = "77C86585-CAFF-43C3-80B0-1023496FAED2",
                                        ItemResponseOID = "B153BE2F-4CEB-4C86-9CB4-20534298DF48",
                                        Value = "1",
                                        Position = "1"
                                    },
                                    new FormMap()
                                    {
                                        ElementOID = "C279A7CB-A5C4-4211-B615-0B1090AE91C8",
                                        Description = "Never",
                                        FormItemOID = "77C86585-CAFF-43C3-80B0-1023496FAED2",
                                        ItemResponseOID = "F4CE265C-EC1A-4AC1-A3A4-D25143D283C5",
                                        Value = "2",
                                        Position = "2"
                                    },
                                    new FormMap()
                                    {
                                        ElementOID = "78A4D40B-4756-4506-AB49-D10EDF187033",
                                        Description = "Rarely",
                                        FormItemOID = "77C86585-CAFF-43C3-80B0-1023496FAED2",
                                        ItemResponseOID = "C5C00432-13FD-4C5D-A0D4-75A2611C4CD6",
                                        Value = "3",
                                        Position = "3"
                                    },
                                    new FormMap()
                                    {
                                        ElementOID = "6AAC64C7-C474-43CB-9B93-62D14B6978B9",
                                        Description = "Sometimes",
                                        FormItemOID = "77C86585-CAFF-43C3-80B0-1023496FAED2",
                                        ItemResponseOID = "3337474D-7B55-44CF-BCA4-A41E520089C3",
                                        Value = "4",
                                        Position = "4"
                                    },
                                    new FormMap()
                                    {
                                        ElementOID = "C0855A96-447F-472D-8B3B-A51AA4AA86EE",
                                        Description = "Often",
                                        FormItemOID = "77C86585-CAFF-43C3-80B0-1023496FAED2",
                                        ItemResponseOID = "7B115BEF-E247-4CD3-BCCC-D584439555C9",
                                        Value = "5",
                                        Position = "5"
                                    },
                                    new FormMap()
                                    {
                                        ElementOID = "D1288A7D-DFB4-4D89-B2BE-3C6CE2776F2C",
                                        Description = "Always",
                                        FormItemOID = "77C86585-CAFF-43C3-80B0-1023496FAED2",
                                        ItemResponseOID = "080AC0B0-7054-49D4-A4EC-6541D783B5BB",
                                        Value = "6",
                                        Position = "6"
                                    }
                                }
                            }
                        }
                    }
                }
            };

            return response;
        }
    }
}
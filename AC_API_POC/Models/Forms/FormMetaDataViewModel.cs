using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AssessmentCenter.Models.Forms
{
    public class FormMetaDataViewModel
    {
        public FormMetaDataViewModel()
        {
        }

        [XmlAttribute]
        public Guid OID
        {
            get;
            set;
        }

        [XmlAttribute]
        public string Name
        {
            get;
            set;
        }

        [XmlAttribute("LOINC_NUM")]
        [JsonProperty("LOINC_NUM", NullValueHandling = NullValueHandling.Ignore)]
        public string LoincCode
        {
            get;
            set;
        }
    }
}

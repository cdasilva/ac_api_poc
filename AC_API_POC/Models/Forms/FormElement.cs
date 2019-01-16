using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AssessmentCenter.Models.Forms
{
    public class FormElement
    {
        [XmlAttribute]
        public string ElementOID
        {
            get;
            set;
        }

        [XmlAttribute]
        public string Description
        {
            get;
            set;
        }

        [XmlAttribute]
        public string ElementOrder
        {
            get;
            set;
        }

        [XmlElement(ElementName = "Map")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<FormMap> Map
        {
            get;
            set;
        }
    }
}

using AssessmentCenter.Models.Xml;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AssessmentCenter.Models.Forms
{
    public class ElementViewModel
    {
        public ElementViewModel()
        {
        }

        public ElementViewModel(ElementXml element)
        {
            ElementOID = element.ElementOID ?? "";
            Description = element.Description ?? "";
            ElementOrder = element.ElementOrder ?? "";

            if (element.Mappings.Count > 0)
            {
                Map = new List<MapViewModel>(element.Mappings.Count);
                foreach (var map in element.Mappings)
                    Map.Add(new MapViewModel(map));
            }
        }

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
        public List<MapViewModel> Map
        {
            get;
            set;
        }
    }
}

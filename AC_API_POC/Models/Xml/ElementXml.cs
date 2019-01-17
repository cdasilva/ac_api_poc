using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AssessmentCenter.Models.Xml
{
    public class ElementXml
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

        [XmlArrayItem(ElementName = "Map")]
        public List<MapXml> Mappings
        {
            get;
            set;
        }
    }
}
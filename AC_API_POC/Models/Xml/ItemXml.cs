using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AssessmentCenter.Models.Xml
{
    public class ItemXml
    {
        [XmlAttribute]
        public string ItemDataOID
        {
            get;
            set;
        }

        [XmlAttribute]
        public string FormItemOID
        {
            get;
            set;
        }

        [XmlAttribute]
        public string ItemResponseOID
        {
            get;
            set;
        }

        [XmlAttribute]
        public string Response
        {
            get;
            set;
        }

        [XmlAttribute]
        public string ResponseTime
        {
            get;
            set;
        }

        [XmlAttribute]
        public string Position
        {
            get;
            set;
        }

        [XmlAttribute]
        public string Section
        {
            get;
            set;
        }

        [XmlAttribute]
        public string Order
        {
            get;
            set;
        }

        [XmlAttribute]
        public string ID
        {
            get;
            set;
        }

        [XmlAttribute]
        public string ItemType
        {
            get;
            set;
        }

        [XmlArrayItem(ElementName = "Element")]
        public List<ElementXml> Elements
        {
            get;
            set;
        }
    }
}
using System;
using System.Xml.Serialization;

namespace AssessmentCenter.Models.Xml
{
    public class MapXml
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
        public string Value
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
        public string FormItemOID
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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AssessmentCenter.Models.Forms
{
    public class FormItem
    {
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
        public string ID
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
        public string ItemType
        {
            get;
            set;
        }

        [XmlElement(ElementName = "Element")]
        public List<FormElement> Elements
        {
            get;
            set;
        }
    }
}

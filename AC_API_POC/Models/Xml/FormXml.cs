using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AssessmentCenter.Models.Xml
{
    [XmlRoot(ElementName = "Form")]
    public class FormXml
    {
        [XmlAttribute]
        public string Status
        {
            get;
            set;
        }

        [XmlAttribute]
        public string DateFinished
        {
            get;
            set;
        }

        [XmlAttribute]
        public string Engine
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

        [XmlArrayItem(ElementName = "Item")]
        public List<ItemXml> Items
        {
            get;
            set;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AssessmentCenter.Models.Forms
{
    [XmlRoot(ElementName = "forms")]
    public class AllFormsResponse
    {
        [XmlElement(ElementName = "form")]
        public List<FormIdentifier> Form
        {
            get;
            set;
        }
    }
}

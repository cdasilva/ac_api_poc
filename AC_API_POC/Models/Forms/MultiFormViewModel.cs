using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AssessmentCenter.Models.Forms
{
    [XmlRoot(ElementName = "forms")]
    public class MultiFormViewModel
    {
        public MultiFormViewModel()
        {
        }

        [XmlElement(ElementName = "form")]
        public List<FormMetaDataViewModel> Form
        {
            get;
            set;
        }
    }
}

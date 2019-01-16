using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AssessmentCenter.Models.Forms
{

    // Note: these models use strings to get the JSON formatting matching the old AC_API better.
    // DateFinished: null vs. DateFinished: "". I would recommend using real nullable data types 
    // (e.g. DateTime?) and let consumers handle the nulls as nulls instead of empty strings.

    [XmlRoot(ElementName = "Form")]
    public class IndividualFormResponse
    {
        [XmlAttribute]
        public string DateFinished
        {
            get;
            set;
        }

        [XmlElement(ElementName = "Item")]
        public List<FormItem> Items
        {
            get;
            set;
        }
    }
}

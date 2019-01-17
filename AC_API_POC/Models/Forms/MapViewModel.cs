using AssessmentCenter.Models.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AssessmentCenter.Models.Forms
{
    public class MapViewModel
    {
        public MapViewModel()
        {
        }

        public MapViewModel(MapXml map)
        {
            ElementOID = map.ElementOID ?? "";
            Description = map.Description ?? "";
            FormItemOID = map.FormItemOID ?? "";
            ItemResponseOID = map.ItemResponseOID ?? "";
            Value = map.Value ?? "";
            Position = map.Position ?? "";
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
        public string Value
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
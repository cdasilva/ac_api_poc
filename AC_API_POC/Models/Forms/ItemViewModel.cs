using AssessmentCenter.Models.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AssessmentCenter.Models.Forms
{
    public class ItemViewModel
    {
        public ItemViewModel()
        {
        }

        public ItemViewModel(ItemXml item)
        {
            FormItemOID = item.FormItemOID ?? "";
            ItemResponseOID = item.ItemResponseOID ?? "";
            Response = item.Response ?? "";
            ID = item.ID ?? "";
            Order = item.Order ?? "";
            ItemType = item.ItemType ?? "";

            if (item.Elements.Count > 0)
            {
                Elements = new List<ElementViewModel>(item.Elements.Count);
                foreach (var element in item.Elements)
                    Elements.Add(new ElementViewModel(element));
            }
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
        public List<ElementViewModel> Elements
        {
            get;
            set;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentCenter.Models.Database
{
    public class FormData
    {
        [Key]
        public Guid FormOID
        {
            get;
            set;
        }

        [Column("Form")]
        public string FormXml
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public int? Status
        {
            get;
            set;
        }

        public int? TermValue
        {
            get;
            set;
        }

        public DateTime? DateCreated
        {
            get;
            set;
        }

        public DateTime? LastModified
        {
            get;
            set;
        }

        public int? AdministeredCount
        {
            get;
            set;
        }
    }
}

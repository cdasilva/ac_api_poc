using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentCenter.Models.Database
{
    public class RegistrationData
    {
        [Key]
        public Guid RegistrationOID
        {
            get;
            set;
        }

        public Guid Token
        {
            get;
            set;
        }
    }
}

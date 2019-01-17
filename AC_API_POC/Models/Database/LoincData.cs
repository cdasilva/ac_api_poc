using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentCenter.Models.Database
{
    public class LoincData
    {
        [Key]
        [Column("LOINC_NUM")]
        public string Code
        {
            get;
            set;
        }

        [Column("METHOD_TYP")]
        public string MethodType
        {
            get;
            set;
        }

        public string Class
        {
            get;
            set;
        }

        public string Status
        {
            get;
            set;
        }

        [Column("LONG_COMMON_NAME")]
        public string LongCommonName
        {
            get;
            set;
        }

        [Column("SURVEY_QUEST_TEXT")]
        public string SurveyQuestionText
        {
            get;
            set;
        }

        public string VariableName
        {
            get;
            set;
        }

        public FormData Form
        {
            get;
            set;
        }
    }
}

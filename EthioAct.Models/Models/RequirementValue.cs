using System;
using System.Collections.Generic;

namespace EthioAct.Models.Models
{
    public partial class RequirementValue
    {
        public int RequirementValueID { get; set; }
        public Nullable<int> requirementTypeId { get; set; }
        public string Value { get; set; }
    }
}

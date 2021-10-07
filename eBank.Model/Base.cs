using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBank.Model
{
    public class Base
    {
        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}

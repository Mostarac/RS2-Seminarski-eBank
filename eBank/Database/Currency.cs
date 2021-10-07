using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eBank.WebAPI.Database
{
    public class Currency
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string CurrencyId { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        
        //public byte[] Icon { get; set; }
    }
}

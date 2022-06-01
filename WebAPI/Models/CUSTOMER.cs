using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public partial class CUSTOMER
    {
        [Key]
        public int CUSTOMER_ID { get; set; }
        public int PLANT_ID { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public DateTime CUSTOMER_DATETIME { get; set; }
        public string CUSTOMER_USER_NAME_ID { get; set; }
        public int CUSTOMER_ACTIVATED { get; set; }
    }
}

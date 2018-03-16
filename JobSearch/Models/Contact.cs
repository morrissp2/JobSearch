using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobSearch.Models
{
    public class Contact
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContactID { get; set; }
        public string Name { get; set;  }
        public string Phone_Number { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        //public ICollection<Job> Jobs { get; set; }
    }
}

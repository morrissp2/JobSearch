using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models
{
    public class Job
    {
        public int JobID { get; set; }
        public string Title { get; set; }
        public string Description { get; set;  }
        public string Job_Number { get; set; }
        public DateTime Date_Applied { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public ICollection<Note> Notes { get; set; }
    }
}

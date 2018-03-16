using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models
{
    public class Note
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NoteID { get; set; }
        public string Note_type { get; set; }
        public string Description { get; set; }
        //public ICollection<Job> Jobs { get; set; }

    }
}

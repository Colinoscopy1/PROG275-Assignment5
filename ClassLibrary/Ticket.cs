using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastEdited { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public int CreatedBy { get; set; }
        public int AssignedTo { get; set; }
        public int AcceptedBy { get; set; }
    }
}

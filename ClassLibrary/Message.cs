using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Message
    {
        public int Id { get; set; }
        public DateTime MessageDate { get; set; }
        public string Content { get; set; }
        public User Sender { get; set; }
        public User Recipient { get; set; }
    }
}

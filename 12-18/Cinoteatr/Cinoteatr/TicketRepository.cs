using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinoteatr
{
    public class TicketRepository
    {
        [Key]
        public int ID { get; set; }
        public string TIME { get; set; }
    }
}

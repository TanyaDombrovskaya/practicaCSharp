using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinoteatr
{
    public class SessionRepository
    {
        [Key]
        public int ID_FILM { get; set; }
        public string FILM { get; set; }
    }
}

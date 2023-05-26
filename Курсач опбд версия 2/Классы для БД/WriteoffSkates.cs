using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач_опбд_версия_2
{
    public class WriteoffSkates
    {
        public int Id { get; set; }
        public DateTime WriteOffDate { get; set; }
        public int SkatesId { get; set; }
        public Skates Skates { get; set; }
    }
}
